using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Runtime.InteropServices;
using WebApplication2.Helpers;
using WebApplication2.Models.Club;
using WebApplication2.Models.User;
using WebApplication2.ViewModel;

namespace WebApplication2.Controllers
{
    public class ClubController : Controller
    {
        private readonly IClubRepository _clubRepository;
        private readonly IPhotoService _photoService;

        public ClubController(IClubRepository clubRepository, IPhotoService photoService)
        {
            this._clubRepository = clubRepository;
            this._photoService = photoService;
        }
        public async Task<IActionResult> Index()
        {
            var clubs = await this._clubRepository.GetAll();
            return View(clubs);
        }

        public async Task<IActionResult> Details(int id)
        {
            var clubDetails = await _clubRepository.GetById(id);
            ViewBag.ClubDetails = clubDetails;
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateClubViewModel clubVm)
        {
            if (ModelState.IsValid)
            {
                var result = await _photoService.AddPhotoAsync(clubVm.Image);

                var club = new Club
                {
                    Title = clubVm.Title,
                    Description = clubVm.Description,
                    Address = new Models.Address
                    {
                        Street = clubVm.Address.Street,
                        City = clubVm.Address.City,
                        State = clubVm.Address.State
                    },
                    Image = result.Url.ToString()
                };
                _clubRepository.Add(club);
                return RedirectToAction("Index");
            }else
            {
                ModelState.AddModelError("", "Photo Upload failed");
            }
            
              return View(clubVm);  
            
        }

        public async Task<IActionResult> Edit(int id)
        {
            var club = await _clubRepository.GetById(id);
            if (club == null) return View("Error");
            var editClubVm = new EditClubViewModel
            {
                Id = club.Id,
                Title = club.Title,
                Description = club.Description,
                Address = club.Address,
                AddressId = club.AddressId,
                Url = club.Image,
                ClubCategory = club.ClubCategory
            };
            return View(editClubVm);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, EditClubViewModel clubVM)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Failed to edit club");
                return View("Edit", clubVM);
            }

            var userClub = await _clubRepository.GetByIdNoTracking(id);

            if (userClub == null)
            {
                return View("Error");
            }

            var photoResult = await _photoService.AddPhotoAsync(clubVM.Image);

            if (photoResult.Error != null)
            {
                ModelState.AddModelError("Image", "Photo upload failed");
                return View(clubVM);
            }

            if (!string.IsNullOrEmpty(userClub.Image))
            {
                await _photoService.DeletePhotoAsync(userClub.Image);
            }

            var club = new Club
            {
                Id = id,
                Title = clubVM.Title,
                Description = clubVM.Description,
                Image = photoResult.Url.ToString(),
                AddressId = clubVM.AddressId,
                Address = clubVM.Address,
            };

            _clubRepository.Update(club);

            return RedirectToAction("Index");
        }

    }
  
}

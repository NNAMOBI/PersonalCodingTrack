using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models.Race;

namespace WebApplication2.Controllers
{
    public class RaceController : Controller
    { 
        private readonly IRaceRepository _raceRepository;
        public RaceController(IRaceRepository raceRepository)
        {
            this._raceRepository = raceRepository;
        }
        public IActionResult Index()
        {
            var races = this._raceRepository.GetAll().ToList();
            return View(races);
        }
        public IActionResult Details(int id)
        {
            var raceDetails = _raceRepository.GetById(id);
            ViewBag.Race = raceDetails;
            return View();
        }
    }
}

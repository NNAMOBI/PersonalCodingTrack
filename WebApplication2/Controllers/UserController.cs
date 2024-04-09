using Microsoft.AspNetCore.Mvc;
using WebApplication2.Mappers;
using WebApplication2.Models.User;
using WebApplication2.ViewModel;

namespace WebApplication2.Controllers
{
    public class UserController : Controller
    {
        IUserRepository _userRepository;
        public UserController(IUserRepository userRepository)
        {
            this._userRepository = userRepository;
        }
        public IActionResult Index(int id)        
        {
           throw new NotImplementedException();
        }
        public IActionResult Detail(int id)
        {
            var user = this._userRepository.GetById(id);

            UserDetailsViewModel userVm = new UserDetailsViewModel
            {
                User = user,
                Header = "User Details"
            };
            return View(userVm);
        }
        public IActionResult GetAllUsers(int id)
        {
           var user = _userRepository.GetAll().ToList().Select(s => s.ToUserDto("users"));
            return Ok(user);
        }
    }
}

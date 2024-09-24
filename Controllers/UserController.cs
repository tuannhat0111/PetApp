using Microsoft.AspNetCore.Mvc;

namespace PetApp.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

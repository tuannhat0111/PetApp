using Microsoft.AspNetCore.Mvc;

namespace PetApp.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

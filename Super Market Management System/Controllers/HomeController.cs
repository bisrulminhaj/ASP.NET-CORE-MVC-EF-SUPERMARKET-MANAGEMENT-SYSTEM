using Microsoft.AspNetCore.Mvc;

namespace Super_Market_Management_System.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

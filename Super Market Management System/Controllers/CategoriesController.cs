using Microsoft.AspNetCore.Mvc;
using Super_Market_Management_System.Models;

namespace Super_Market_Management_System.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Edit(int? id)
        {
            var category = new Category { CategoryID = id.HasValue ? id.Value : 0 };

            return View(category);
        }
    }
}

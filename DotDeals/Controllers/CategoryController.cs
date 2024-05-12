using Microsoft.AspNetCore.Mvc;

namespace DotDeals.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace BookStoreTest.Controllers
{
    public class GenreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

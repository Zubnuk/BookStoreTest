using Microsoft.AspNetCore.Mvc;

namespace BookStoreTest.Controllers
{
    public class ReviewsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

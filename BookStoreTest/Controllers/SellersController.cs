using Microsoft.AspNetCore.Mvc;

namespace BookStoreTest.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

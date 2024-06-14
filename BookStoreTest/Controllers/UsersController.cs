using Microsoft.AspNetCore.Mvc;

namespace BookStoreTest.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

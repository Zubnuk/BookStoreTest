using Microsoft.AspNetCore.Mvc;

namespace BookStoreTest.Controllers
{
    public class RolesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

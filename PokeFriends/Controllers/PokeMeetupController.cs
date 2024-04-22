using Microsoft.AspNetCore.Mvc;

namespace PokeFriends.Controllers
{
    public class PokeMeetupController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

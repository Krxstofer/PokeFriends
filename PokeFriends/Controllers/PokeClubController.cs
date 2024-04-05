using Microsoft.AspNetCore.Mvc;

namespace PokeFriends.Controllers
{
    public class PokeClubController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace ourApp8.Controllers
{
    public class PlayersController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
    }
}

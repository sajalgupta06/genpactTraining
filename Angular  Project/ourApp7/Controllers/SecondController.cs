using Microsoft.AspNetCore.Mvc;

namespace ourApp7.Controllers
{
    public class SecondController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

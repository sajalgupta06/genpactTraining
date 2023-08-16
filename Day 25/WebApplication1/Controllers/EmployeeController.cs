using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {

            ViewBag.msg = "Welcome To Employee Index";

            return View();
        }
    }
}

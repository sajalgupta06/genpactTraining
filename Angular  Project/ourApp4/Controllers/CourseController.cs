using Microsoft.AspNetCore.Mvc;
using ourApp4.Data;
using ourApp4.Models;

namespace ourApp4.Controllers
{
   
    public class CourseController : Controller
    {
        public readonly ApplicationDbContext _db;
        public CourseController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Course>obj = _db.Courses.ToList();
            return View(obj);
        }
    }
}

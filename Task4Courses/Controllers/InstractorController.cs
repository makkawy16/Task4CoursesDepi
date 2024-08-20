using Microsoft.AspNetCore.Mvc;
using Task4Courses.Data;

namespace Task4Courses.Controllers
{
    public class InstractorController : Controller
    {
        private readonly AppDbContext context ;

        public InstractorController(AppDbContext context) {
            this.context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetAllInstarctors() { 
        
            var instarctors = context.Instractors.ToList();
            

            return View("Instractors",instarctors);
        }
    }
}

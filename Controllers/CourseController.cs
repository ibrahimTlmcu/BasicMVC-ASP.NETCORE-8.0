using BasicMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace BasicMVC.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            var kurs = new Course();
            kurs.id = 1;
            kurs.Title = " ASP.NET Core Kursu";
            kurs.Description = " Guzel bir kurstu";

            return View(kurs);           
        }

        

        public IActionResult List()
        {
            var kurslar = new List<Course>
            {
                new Course() {id = 14,Title ="ASPNET Kursu",Description ="Guzel bir kurstu",Image="asp.jpg" },
                new Course() {id = 2,Title ="php Kursu",Description ="Guzel bir kurstu",Image= "11.PNG"},
                new Course() {id = 3,Title ="django Kursu",Description ="Guzel bir kurstu",Image = "13.JPG" }
            };

            return View(kurslar);
        }
        public IActionResult Details(int id)
        {
            var kurslar = new List<Course>
            {
                new Course() {id = 14,Title ="ASPNET Kursu",Description ="Guzel bir kurstu",Image="asp.jpg" },
                new Course() {id = 2,Title ="php Kursu",Description ="Guzel bir kurstu",Image= "11.PNG"},
                new Course() {id = 3,Title ="django Kursu",Description ="Guzel bir kurstu",Image = "13.JPG" }
            };

            var course = kurslar.FirstOrDefault(c => c.id == id);
            // Kurs bilgilerini View'e gönder
            return View(course);
        }
    }

}

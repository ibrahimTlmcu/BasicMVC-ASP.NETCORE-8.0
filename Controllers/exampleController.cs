using Microsoft.AspNetCore.Mvc;

namespace BasicMVC.Controllers
{
    public class exampleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

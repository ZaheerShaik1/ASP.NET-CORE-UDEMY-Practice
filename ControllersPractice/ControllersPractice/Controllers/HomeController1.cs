using Microsoft.AspNetCore.Mvc;

namespace ControllersPractice.Controllers
{
    public class HomeController1 : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }
    }
}

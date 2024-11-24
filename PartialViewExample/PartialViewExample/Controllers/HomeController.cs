using Microsoft.AspNetCore.Mvc;

namespace PartialViewExample.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            ViewData["ListTitle"] = "Cities";
            ViewData["ListItems"] = new List<string>()
            {
                "New York", "Delhi" , "Brisbane" , "London" ,"Japan"
            };
            return View();
        }
        [Route("/about")]
        public IActionResult About()
        {
            return View();
        }
        [Route("/contact")]
        public IActionResult Contact()
        {
            return View();
        }
    }
}

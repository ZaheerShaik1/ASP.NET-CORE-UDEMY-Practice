using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace ControllersPractice.Controllers
{
    [Controller]
    public class Home : Controller
    {       
        public IActionResult Index()
        {
            return Content("Inside Index");
        }
    }
}

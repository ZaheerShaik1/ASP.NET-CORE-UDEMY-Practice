using Microsoft.AspNetCore.Mvc;
using ModelValidationsExample.Models;

namespace ModelValidationsExample.Controllers
{
    public class HomeController : Controller
    {
        [Route("register")]
        public IActionResult Index(Person person)
        {
            if (!ModelState.IsValid)
            {
                //using linq
                string errors = string.Join("\n", ModelState.Values.SelectMany(value => value.Errors).Select(err => err.ErrorMessage));

                //List<string> errorList = new List<string>();
                //foreach (var value in ModelState.Values)
                //{
                //    foreach (var error in value.Errors)
                //    {
                //        errorList.Add(error.ErrorMessage);
                //    }
                //}
                //string errors = string.Join(", ", errorList);
                return BadRequest(errors);
            }
            

            return Content($"{person}");  
        }
    }
}

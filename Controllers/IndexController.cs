using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace YourNamespace.Controllers 
{
    public class IndexController : Controller   
    {
        [HttpGet]       
        [Route("")]     
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("method")]
        public IActionResult Method(string YourName, string Location, string Language, string Comments)
        {
            return RedirectToAction("ReturnResults", new { name = YourName, location = Location, language = Language, comments = Comments });
        }

        [HttpGet]       
        [Route("result")] 
        public IActionResult ReturnResults(string name, string location, string language, string comments)
        {
            ViewBag.Name = name;
            ViewBag.Location = location;
            ViewBag.Language = language;
            ViewBag.Comments = comments;
            return View("Result");
        }
    }
}
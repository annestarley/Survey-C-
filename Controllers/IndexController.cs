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
        public IActionResult Method()
        {
            return RedirectToAction("ReturnResults");
        }

        [HttpGet]       
        [Route("result")] 
        public IActionResult ReturnResults()
        {
            return View("Result");
        }
    }
}
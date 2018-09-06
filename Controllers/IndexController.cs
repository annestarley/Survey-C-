using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Survey.Models;

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

        [HttpPost("survey")]
        public IActionResult Submission(SurveyData yourSurvey)
        {
            return RedirectToAction("ReturnResults", yourSurvey);
        }

        [HttpGet]       
        [Route("result")] 
        public IActionResult ReturnResults(SurveyData yourSurvey)
        {
            return View("Result", yourSurvey);
        }
    }
}
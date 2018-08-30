    using Microsoft.AspNetCore.Mvc;
    namespace YourNamespace.Controllers 
    {
        public class ResultController : Controller   
        {
            [HttpGet]       
            [Route("result")]     
            public IActionResult Index()
            {
                return View();
            }
        }
    }
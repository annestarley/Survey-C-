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
        }
    }
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace WordSearch02.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Splash()
        {
            return View();
        }
    }
}

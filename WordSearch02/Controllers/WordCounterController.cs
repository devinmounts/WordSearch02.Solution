using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WordSearch02.Models;
using WordSearch02.Controllers;

namespace WordSearch02.Controllers
{
    public class WordCounterController : Controller
    {
        [HttpGet("/counter-form")]
        public ActionResult WordCounterForm()
        {
            return View();
            //return new EmptyResult();
        }

        [HttpPost("counter-results")]
        public ActionResult WordCounterResults(string targetWord, string phrase)
        {
            RepeatCounter counter = new RepeatCounter();
            counter.CheckSplitPhrase(targetWord, phrase);
            counter.GetResult();

            //return View(counter);
            return new EmptyResult();
        }
    }
}

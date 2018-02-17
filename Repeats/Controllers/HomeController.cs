using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Repeats.Models;
using System;

namespace Repeats.Controllers
{
    public class HomeController : Controller
    {
      [HttpGet("/")]
          public ActionResult Index()
          {
            RepeatCounter newRepeatCounter = new RepeatCounter();
            return View(newRepeatCounter);

          }
          [HttpPost("/")]
          public ActionResult Result()
          {
            string testWord = Request.Form["testWord"];
            string targetString = Request.Form["targetString"];
            RepeatCounter newRepeatCounter = new RepeatCounter();
            newRepeatCounter.SetTestWord(testWord);
            newRepeatCounter.SetTargetString(targetString);
            newRepeatCounter.SetRemovals();
            newRepeatCounter.CleanTargetStrings();
            newRepeatCounter.CompareStrings();
            return View("Index", newRepeatCounter);
          }


    }
}

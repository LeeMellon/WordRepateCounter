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
            
            return View();
          }


    }
}

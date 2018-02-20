using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Repeats.Controllers;
using Repeats.Models;

namespace Repeats.Tests
{
  [TestClass]
  public class HomeControllerTest
  {
    [TestMethod]
    public void Index_ReturnCorrectView_Green()
    {
      //arrange
      HomeController controller = new HomeController();

      //act
      IActionResult indexView = controller.Index();
      ViewResult result = indexView as ViewResult;

      //assert
      Assert.IsInstanceOfType(result, typeof(ViewResult));
    }

    [TestMethod]
    public void Index_HasCorrectModelType_Green()
    {
      //arrange
      ViewResult IndexView = new HomeController().Index() as ViewResult;
      //act
      var result = IndexView.ViewData.Model;

      //assert
      Assert.IsInstanceOfType(result, typeof(RepeatCounter));
    }
  }

}

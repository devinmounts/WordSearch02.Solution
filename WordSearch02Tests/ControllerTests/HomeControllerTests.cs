using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WordSearch02.Controllers;
using WordSearch02.Models;

namespace WordSearch02Tests.ControllerTests
{
    [TestClass]
    public class HomeControllerTests 
    {
        //public void Dispose()
        //{
        //    RepeatCounter.ClearAll();
        //}
        [TestMethod]
        public void Splash_ReturnsCorrectView_True()
        {
            HomeController controller = new HomeController();
            ActionResult splashView = controller.Splash();
            Assert.IsInstanceOfType(splashView, typeof(ViewResult));

        }
    }
}

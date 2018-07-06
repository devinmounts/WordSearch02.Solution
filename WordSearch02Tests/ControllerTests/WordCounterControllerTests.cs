using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WordSearch02.Controllers;
using WordSearch02.Models;

namespace WordSearch02Tests.ControllerTests
{
    [TestClass]
    public class WordCounterControllerTests
    {
        [TestMethod]
        public void Splash_ReturnsCorrectView_True()
        {
            WordCounterController controller = new WordCounterController();
            ActionResult formView = controller.WordCounterForm();
            Assert.IsInstanceOfType(formView, typeof(ViewResult));

        }
    }
}

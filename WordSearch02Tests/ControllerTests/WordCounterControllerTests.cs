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
        public void WordCounterForm_ReturnsCorrectView_True()
        {
            WordCounterController controller = new WordCounterController();
            ActionResult formView = controller.WordCounterForm();
            Assert.IsInstanceOfType(formView, typeof(ViewResult));
        }

        [TestMethod]
        public void WordCounterResult_ReturnsCorrectView_True()
        {
            WordCounterController controller = new WordCounterController();
            ActionResult resultsView = controller.WordCounterResults("cat", "the cAt");
            Assert.IsInstanceOfType(resultsView, typeof(ViewResult));
        }

        [TestMethod]
        public void WordCounterResults_HasCorrectModelType_RepeatCounter()
        {
            ViewResult wordCounterResultsView = new WordCounterController().WordCounterResults("cat", "the CaT") as ViewResult;
            var result = wordCounterResultsView.ViewData.Model;
            Assert.IsInstanceOfType(result, typeof(RepeatCounter));
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WordSearch02.Models;

namespace WordSearch02.Tests
{
    [TestClass]
    public class RepeatCounterTests : IDisposable
    {
        public void Dispose()
        {
            RepeatCounter.ClearAll();
        }
        [TestMethod]
        public void GetSetTargetWord_ReturnTargetWord_String()
        {
            //Arrange
            string testTarget = "the";
            RepeatCounter testCounter = new RepeatCounter(testTarget);

            //Act
            string result = testCounter.GetTargetWord();

            //Assert
            Assert.AreEqual(testTarget, result);
        }

        [TestMethod]
        public void SetTargetWord_SetNewTargetWord_String()
        {
            //Arrange
            RepeatCounter testCounter = new RepeatCounter();

            //Act
            string newTestTarget = "cat";
            testCounter.SetTargetWord(newTestTarget);
            string result = testCounter.GetTargetWord();

            //Assert
            Assert.AreEqual(newTestTarget, result);
        }

        [TestMethod]
        public void SetTargetWord_SetNewTargetWordToLower_String()
        {
            //Arrange
            //string testTarget = "the";
            RepeatCounter testCounter = new RepeatCounter();

            //Act
            string newTestTarget = "CAT";
            testCounter.SetTargetWord(newTestTarget);
            string result = testCounter.GetTargetWord();

            //Assert
            Assert.AreEqual("cat", result);
        }

        [TestMethod]
        public void SplitCompareString_ReturnStringArray_String()
        {
            //Arrange
            string testPhrase = "The cat is walking";
            RepeatCounter testCounter = new RepeatCounter();

            //Act
            testCounter.SetSplitCompareString(testPhrase);
            string[] resultArray = testCounter.GetComparePhrase();


            //Assert
            Assert.AreEqual(4, resultArray.Length);

        }

        [TestMethod]
        public void CheckSplitPhrase_ReturnNumberOfMatches_Int()
        {
            //Arrange
            string testWord = "The";
            string testPhrase = "The Cat walked down THe street to THE store.";
            RepeatCounter testCounter = new RepeatCounter();

            //Act
            int result = testCounter.CheckSplitPhrase(testWord, testPhrase);

            //Assert
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void GetResult_ReturnResult_Int()
        {
            //Arrange
            string testWord = "The";
            string testPhrase = "The Cat walked down THe street to THE store.";
            RepeatCounter testCounter = new RepeatCounter();

            //Act
            testCounter.CheckSplitPhrase(testWord, testPhrase);
            int result = testCounter.GetResult();

            //Assert
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void RunRepeatCounter_ReturnFinalResult_Int()
        {
            //Arrange
            string testWord = "The";
            string testPhrase = "The Cat walked down THe street to THE store.";
            RepeatCounter testCounter = new RepeatCounter();

            //Act
            int result = testCounter.RunCounter(testWord, testPhrase);

            //Assert
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void TestSplitChars_ReturnFinalResult_Int()
        {
            //Arrange
            string testWord = "the";
            string testPhrase = "The,!! #cat@()cat (the),.the?CAT!";
            RepeatCounter testCounter = new RepeatCounter();

            //Act
            int result = testCounter.RunCounter(testWord, testPhrase);

            //Assert
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void SavesGetsList_SavesReturnsList_List()
        {
            string testWord01 = "cat";
            string testWord02 = "dog";
            RepeatCounter save01 = new RepeatCounter();
            RepeatCounter save02 = new RepeatCounter();
            save01.SaveWord(testWord01);
            save02.SaveWord(testWord02);
            List<RepeatCounter> testList = new List<RepeatCounter> { save01, save02 };
            CollectionAssert.AreEqual(testList, RepeatCounter.GetAll());

        }

    }
}
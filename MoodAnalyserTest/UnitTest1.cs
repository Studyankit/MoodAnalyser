using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserProject;
using System;

namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [TestCategory("Happy Mood")]
        public void GivenMessageShouldReturnHappy()
        {
            ///Follow AAA strategy
            ///Arrange , Act and in last Assert
            MoodAnalyser mood = new MoodAnalyser();
            string message = "I am in Happy Mood";
            string excepted = "happy";
            var actual = mood.Mood(message);
            Assert.AreEqual(excepted, actual);
        }
        [TestMethod]
        [TestCategory("SAD Mood")]
        public void GivenMessageShouldReturnSad()
        {
            ///Follow AAA strategy
            ///Arrange , Act and in last Assert
            MoodAnalyser mood = new MoodAnalyser();
            string message = "I am in SAD Mood";
            string excepted = "sad";
            var actual = mood.Mood(message);
            Assert.AreEqual(excepted, actual);
        }
        [TestMethod]
        [TestCategory(null)]
        public void GivenMessageShouldReturnHappyIfNull()
        {
            //Follow AAA strategy
            ///Arrange , Act and in last Assert
            MoodAnalyser mood = new MoodAnalyser();
            string message = "";
            string excepted = "happy";
            var actual = mood.Mood(message);
            Assert.AreEqual(excepted, actual);
        }
    }

}
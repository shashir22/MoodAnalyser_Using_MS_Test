using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {


        [TestMethod]
        public void GivenMoodHappy_ShouldReturnSad()
        {
            //Arrange
            string expected = "HAPPY";
            string message = "I am in Happy Mood";
            MoodAnalyser1 moodAnalyzer = new MoodAnalyser1(message);

            //Act
            string mood = moodAnalyzer.AnalyzeMood();

            //Assert
            Assert.AreEqual(expected, mood);
        }
        [TestMethod]
        [DataRow("I am in Happy Mood")]
        public void GivenHAPPYMoodShouldReturnHappy(string message)
        {
            //Arrange
            string expected = "HAPPY";
            MoodAnalyser1 moodAnalyzer = new MoodAnalyser1(message);

            //Act
            string mood = moodAnalyzer.AnalyzeMood();

            //Assert
            Assert.AreEqual(expected, mood);
        }
        [TestMethod]
        public void GivenMoodEmpty_ShouldThrowException()
        {
            try
            {
                string message = "";
                MoodAnalyser1 moodAnalyzer = new MoodAnalyser1(message);
                string mood = moodAnalyzer.AnalyzeMood();
            }
            catch (MoodAnalyserCustomException e)
            {
                Assert.AreEqual("Mood should not be empty", e.Message);
            }

        }
        //Testcase 3.1
        [TestMethod]
        public void GivenMoodNull_ShouldThrowException()
        {
            try
            {
                string? message = null;
                MoodAnalyser1 moodAnalyzer = new MoodAnalyser1(message);
                string mood = moodAnalyzer.AnalyzeMood();
            }
            catch (MoodAnalyserCustomException e)
            {
                Assert.AreEqual("Mood should not be null", e.Message);
            }

        }

    }
}





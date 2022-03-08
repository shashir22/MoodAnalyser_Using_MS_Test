using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;

namespace MoodAnalyserUnitTest
{

    [TestClass]
    public class UnitTest1
    {


        [TestMethod]
        public void GivenMoodHappy_ShouldReturnHappy()
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
    }
}


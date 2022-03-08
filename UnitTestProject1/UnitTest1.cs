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
        //Testcase 4.1
        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject()
        {
            string? message = null;
            object expected = new MoodAnalyser1(message);
            object obj = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyser.MoodAnalyser1", "MoodAnalyser1");
            expected.Equals(obj);

        }
        //Testcase 5.1
        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject_UsingParameterisedConstructor()
        {
            object expected = new MoodAnalyser1("HAPPY");
            object obj = MoodAnalyserFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyser.MoodAnalyser1", "MoodAnalyser1", "HAPPY");
            expected.Equals(obj);

        }
    }
}

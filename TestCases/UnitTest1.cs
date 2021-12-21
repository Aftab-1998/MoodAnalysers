using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;

namespace TestCases
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// TC 1.1:Given ? I am in Sad mood? message should Return SAD.
        
        /// </summary>
        [TestMethod]
        
        //public void GivenSadMoodShouldReturnSAD()
        
        //{
        //    //Arrange
        //    string expected = "SAD";
        //    string message = "I am in Sad Mood";
        //    MoodStatus moodAnalyse = new MoodStatus(message);

        //    //Act
        //    string mood = moodAnalyse.AnalyseMood();

        //    //Assert
        //    Assert.AreEqual(expected, mood);
        //}

        public void GivenAnyMoodShouldReturnHAPPY()

        {
            //Arrange
            string expected = "HAPPY";
            string message = "I am in Happy Mood";
            MoodStatus moodAnalyse = new MoodStatus(message);

            //Act
            string mood = moodAnalyse.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, mood);
        }
    }
}
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GoGetFitTests;

namespace GoGetFitTests
{
    [TestClass]
    public class DeleteWorkoutTest : TestHelper
    {
        [TestMethod]
        public void ScenarioDeleteWorkout()
        {
            GivenThereAreXWorkouts(1);
            WhenIClick("Delete Workout");
            AndIShouldSeeXWorkouts(0);
            AndTheButtonShouldBeEnabled("Add Workout");
            WhenIClick("Add Workout");
            ThenIShouldSeeWorkoutForm();
            AndTheButtonShouldBeDisabled("Add Workout");

        }
    }
}

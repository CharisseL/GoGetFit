using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.BDDfy;

namespace GoGetFitTests
{
    [TestClass]
    public class EditWorkoutTest : TestHelper
    {
        [TestMethod]
        public void ScenarioEditWorkout()
        {
            GivenThereAreXWorkouts(1);
            WhenIClick("Edit");
            ThenIShouldSeeWorkoutForm();
            AndTheButtonShouldBeDisabled("Edit");

            WhenIEditWorkoutWith("Yellow Trail Run");
            AndIChooseTheWorkoutDate("02/14/15");
            AndIClick("Add");
            ThenIShouldNotSeeWorkoutForm();
            AndIShouldSeeXWorkouts(1);
            AndTheButtonShouldBeEnabled("Edit");
        }
 
        [TestMethod]
        public void ScenarioCancelWorkoutEdit()
        {
            GivenThereAreNoWorkouts();
            WhenIClick("Add Workout");
            WhenIFillInWorkoutWith("Blue Trail Run");
            AndIChooseTheWorkoutDate("02/14/15");
            AndIClick("Cancel");
            ThenIShouldNotSeeWorkoutForm();
            AndIShouldSeeXWorkouts(0);
            AndTheButtonShouldBeEnabled("Add Workout");
            WhenIClick("Add Workout");
            ThenIShouldSeeWorkoutForm();
            AndTheButtonShouldBeDisabled("Add Workout");

        }

    }
}

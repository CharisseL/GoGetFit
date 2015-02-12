using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.BDDfy;

namespace GoGetFitTests
{
    [TestClass]
    public class CreateWorkoutTest : TestHelper
    {
        [TestMethod]
        public void ScenarioCreateWorkout()
        {
            //As a user
            //In order keep track of my workouts
            //I want to create a new workout
            //Click "Add Workout" to get the add new workout form
            //Workout must contain at least one character
            //Event is required
            //Click "Add" to add the workout
            //The event shows up in the workout grid list and the form goes away
            //Click "x" to close the form

            GivenThereAreNoWorkouts();
            WhenIClick("Add Workout");
            ThenIShouldSeeWorkoutForm();
            AndTheButtonShouldBeDisabled("Add Workout");

            WhenIFillInWorkoutWith("Blue Trail Run");
            AndIChooseTheWorkoutDate("02/14/15");
            AndIClick("Add");
            ThenIShouldNotSeeWorkoutForm();
            AndIShouldSeeXWorkouts(1);
            AndTheButtonShouldBeEnabled("Add Workout");
        }
        
        [TestMethod]
        public void ScenarioDataValidationForWorkoutCreation()
        {
            GivenThereAreNoWorkouts();
            WhenIClick("Add Workout");
            ThenIShouldNotSeeWorkoutForm();
            WhenIFillInWorkoutWith("Blue Trail Run");
            AndIChooseTheWorkoutDate("02/14/15");
            AndIClick("Add");
            ThenIShouldNotSeeWorkoutForm();
            AndIShouldSeeXWorkouts(1);
        }

        [TestMethod]
        public void ScenarioCancelOutOfWorkoutCreation()
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

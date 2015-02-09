using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.BDDfy;

namespace GoGetFitTests
{
    [TestClass]
    public class StoryTests : TestHelper
    {
        [TestMethod]
        public void WorkoutCreation()
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
        }

    }
}

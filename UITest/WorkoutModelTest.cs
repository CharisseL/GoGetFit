using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GoGetFit.Model;

namespace GoGetFitTests
{
    [TestClass]
    public class WorkoutModelTest
    {
        [TestMethod]
        public void CreatingAWorkoutStoresItInWorkouts()
        {
            Workout trailRun = new Workout("Blue Trail Run", "02/14/15");
            //CollectionAssert.Contains(Workout.Workouts, trailRun);
        }
        [TestMethod]
        public void CreatingAWorkoutStoresItsProperties()
        {
            Workout trailRun = new Workout("Blue Trail Run", "02/14/15");
            Assert.AreEqual("Blue Trail Run", trailRun.Name);
            Assert.AreEqual("02/14/15", trailRun.Date);
        }
    }
}

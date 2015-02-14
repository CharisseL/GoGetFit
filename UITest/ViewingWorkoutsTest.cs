using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GoGetFit.Model;

namespace GoGetFitTests
{
    [TestClass]
    public class ViewingWorkoutsTest : TestHelper
    {
        [TestMethod]
        public static void SetupTests(TestContext _context)
        {
            TestHelper.Setup(_context);
        }

        [ClassCleanup]
        public static void CleanUp()
        {
            TestHelper.CleanUp();
        }

        [TestMethod]
        public void ScenarioViewingWorkouts()
        {
            GivenTheseWorkouts(
                new Workout("Blue Trail Run", "02/14/15"),
                new Workout("Red Trail Run", "05/03/15")
                );
            ThenIShouldSeeXEvents(2);
            AndIShouldSeeAWorkoutFor("Blue Trail Run", "02/14/15");
            AndIShouldSeeAWorkoutFor("Red Trail Run", "05/03/15");
            AndTheButtonShouldBeEnabled("Add Workout");
        }

       
    }
}

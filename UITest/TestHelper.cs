using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.White.UIItems.WindowItems;
using TestStack.White;
using System.IO;
using TestStack.White.Factory;
using TestStack.White.UIItems.ListBoxItems;
using System.Collections.Generic;
using GoGetFit.Model;


namespace GoGetFitTests
{
    public class TestHelper 
    {
        private static TestContext test_context;
        private static Window window;
        private static Application application;

        public static void Setup(TestContext _context)
        {
            test_context = _context;
            var applicationDir = _context.DeploymentDirectory;
            var applicationPath = Path.Combine(applicationDir, "..\\..\\..\\GoGetFitTests\\bin\\Debug\\GoGetFit");
            application = Application.Launch(applicationPath);
            window = application.GetWindow("MainWindow", InitializeOption.NoCache);
        }

        public void AndIShouldSeeXWorkouts(int expected)
        {
            Assert.IsNotNull(window);
            ListBox workouts = window.Get<ListBox>("WorkoutList");
            Assert.AreEqual(expected, workouts.Items.Count);
        }

        public void ThenIShouldNotSeeWorkoutForm()
        {
            throw new NotImplementedException();
        }

        public void AndIClick(string p)
        {
            throw new NotImplementedException();
        }

        public void AndIChooseTheWorkoutDate(string p)
        {
            throw new NotImplementedException();
        }

        public void WhenIFillInWorkoutWith(string p)
        {
            throw new NotImplementedException();
        }

        public void AndTheButtonShouldBeDisabled(string p)
        {
            throw new NotImplementedException();
        }

        public void ThenIShouldSeeWorkoutForm()
        {
            throw new NotImplementedException();
        }

        public void WhenIClick(string p)
        {
            throw new NotImplementedException();
        }

        public void GivenThereAreNoWorkouts()
        {
            throw new NotImplementedException();
        }

        public void AndTheButtonShouldBeEnabled(string p)
        {
            throw new NotImplementedException();
        }

        public void WhenIEditWorkoutWith(string p)
        {
            throw new NotImplementedException();
        }

        public void GivenThereAreXWorkouts(int p)
        {
            throw new NotImplementedException();
        }

        public void AndIShouldSeeAWorkoutFor(string p1, string p2)
        {
            throw new NotImplementedException();
        }

        public void ThenIShouldSeeXEvents(int p)
        {
            throw new NotImplementedException();
        }

        public void GivenTheseWorkouts(Workout workout1, Workout workout2)
        {
            throw new NotImplementedException();
        }

        public static void CleanUp()
        {
            window.Close();
            application.Close();
        }


    }
}

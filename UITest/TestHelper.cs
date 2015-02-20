using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.White.UIItems.WindowItems;
using TestStack.White;
using System.IO;
using System.Reflection;
using TestStack.White.Factory;
using TestStack.White.UIItems.ListBoxItems;
using TestStack.White.UIItems.Finders;
using System.Collections.Generic;
using GoGetFit.Model;
using GoGetFit.Repository;
using GoGetFit;


namespace GoGetFitTests
{
    public class TestHelper 
    {
        private static TestContext test_context;
        private static Window window;
        private static Application application;
        private static WorkoutRepository repo = new WorkoutRepository();
        private static WorkoutContext context;

        public static void Setup(TestContext _context)
        {
            test_context = _context;

            var applicationDir = _context.DeploymentDirectory;
            var applicationPath = Path.Combine(applicationDir, "..\\..\\..\\GoGetFitTests\\bin\\Debug\\GoGetFit");
           
            application = Application.Launch(applicationPath);
          
            window = application.GetWindow("MainWindow", InitializeOption.NoCache);
            //repo = new WorkoutRepository();
            context = repo.Context();
        }

        public void AndIShouldSeeXWorkouts(int expected)
        {
            Assert.IsNotNull(window);
            SearchCriteria searchCriteria = SearchCriteria.ByAutomationId("WorkoutList").AndIndex(0);
            ListBox list_box = (ListBox)window.Get(searchCriteria);
            Assert.AreEqual(expected, list_box.Items.Count);
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
            Assert.AreEqual(0, repo.GetWorkoutCount());
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
            var e = repo.GetByDate(p2);
            Assert.IsNotNull(window);
            SearchCriteria searchCriteria = SearchCriteria.ByAutomationId("WorkoutList").AndIndex(0);
            ListBox list_box = (ListBox)window.Get(searchCriteria);
            var item = list_box.Items.Find(i => i.Text == p1);
            Assert.AreEqual(p1, item.Text);
        }

        public void ThenIShouldSeeXEvents(int p)
        {
            throw new NotImplementedException();
        }

        public void GivenTheseWorkouts(params Workout[] workouts)
        {
            repo.Add(workouts[0]);
            repo.Add(workouts[1]);
        }

        public static void CleanUp()
        {
            window.Close();
            repo.Clear();
            application.Close();
        }


    }
}

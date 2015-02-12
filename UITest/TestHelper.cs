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

        public void AndIShouldSeeXWorkouts(int p)
        {
            throw new NotImplementedException();
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



    }
}

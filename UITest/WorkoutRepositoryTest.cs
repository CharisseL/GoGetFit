using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GoGetFit.Repository;
using GoGetFit;
using GoGetFit.Model;

namespace GoGitFitTests
{
    [TestClass]
    public class WorkoutRepositoryTest
    {
        [TestMethod]
        public void TestAddToDatabase()
        {
            WorkoutRepository repo = new WorkoutRepository();
            repo.GetDbSet().Add(new Workout("Daily Burn", "12/08/2015"));
            Assert.AreEqual(1, repo.GetDbSet().Local.Count);
        }

        [TestMethod]
        public void TestAllMethod()
        {
            WorkoutRepository repo = new WorkoutRepository();
            LinkedList<Workout> list = new LinkedList<Workout>();

            list.AddLast(new Workout("Red Trail Run", "05/03/2015"));
            list.AddLast(new Workout("Blue Trail Run", "02/14/2015"));
            repo.Add(new Workout("Red Trail Run", "05/03/2015"));
            repo.Add(new Workout("Blue Trail Run", "02/14/2015"));
            Assert.AreEqual(list, repo);
        }

        [TestMethod]
        public void TestGetWorkoutCount()
        {
            WorkoutRepository repo = new WorkoutRepository();
            Assert.AreEqual(0, repo.GetWorkoutCount());
            repo.Add(new Workout("Red Trail Run", "05/03/2015"));
        }

        [TestMethod]
        public void TestClear()
        {
            WorkoutRepository repo = new WorkoutRepository();
            repo.Add(new Workout("Red Trail Run", "05/03/2015"));
            repo.Clear();
            Assert.AreEqual(0, repo.GetWorkoutCount());
        }
    }
}

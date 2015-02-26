using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoGetFit;
using System.Data.Entity;

namespace GoGetFit.Repository
{
    public class WorkoutRepository : IWorkoutRepository
    {
        private WorkoutContext _dbContext;

        public WorkoutRepository()
        {
            _dbContext = new WorkoutContext();
            _dbContext.Workouts.Load();

        }
        
        public WorkoutContext Context()
        {
            return _dbContext;
        }
        public DbSet<Model.Workout> GetDbSet()
        {
            return _dbContext.Workouts;
        }
        
        
        public int GetWorkoutCount()
        {
            return _dbContext.Workouts.Count<Model.Workout>();
        }

        public void Add(Model.Workout E)
        {
            _dbContext.Workouts.Add(E);
            _dbContext.SaveChanges();
        }

        public void Delete(Model.Workout E)
        {
            throw new NotImplementedException();
        }

        

        public void Clear()
        {
            var a = this.All();
            _dbContext.Workouts.RemoveRange(a);
            _dbContext.SaveChanges();
        }

        public List<Model.Workout> PastWorkouts()
        {
            throw new NotImplementedException();
        }

        public int CalculateMonth(Model.Workout E)
        {
            throw new NotImplementedException();
        }

        public List<Model.Workout> All()
        {
            var worklist = from Workout in _dbContext.Workouts
                           select Workout;
            return worklist.ToList<Model.Workout>();
        }

        public Model.Workout GetById(int id)
        {
            var query = from Workout in _dbContext.Workouts
                        where Workout.WorkoutId == id
                        select Workout;
            return query.First<Model.Workout>();
        }

        public Model.Workout GetByDate(string date)
        {
            var query = from Workout in _dbContext.Workouts
                        where Workout.Date == date
                        select Workout;
            return query.First<Model.Workout>();
        }

        public IQueryable<Model.Workout> SearchFor(System.Linq.Expressions.Expression<Func<Model.Workout, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public DbSet<Model.Workout> GetAllWorkouts()
        {
            return _dbContext.Workouts;
        }
    }    
}

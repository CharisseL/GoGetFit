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
        }
        
        public DbSet<Model.Workout> GetDbSet()
        {
            return _dbContext.Workouts;
        }
        
        
        public int GetWorkoutCount()
        {
            throw new NotImplementedException();
        }

        public void Add(Model.Workout E)
        {
            throw new NotImplementedException();
            //_dbContext.SaveChanges();
        }

        public void Delete(Model.Workout E)
        {
            throw new NotImplementedException();
        }

        

        public void Clear()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public IQueryable<Model.Workout> SearchFor(System.Linq.Expressions.Expression<Func<Model.Workout, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }    
}

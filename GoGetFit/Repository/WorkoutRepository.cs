using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoGetFit.Repository
{
    class WorkoutRepository : IWorkoutRepository
    {
        public int GetWorkoutDays()
        {
            throw new NotImplementedException();
        }

        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Model.Workout> PastWorkouts()
        {
            throw new NotImplementedException();
        }

        public int CalculateMonth()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Model.Workout> All()
        {
            throw new NotImplementedException();
        }

        public Model.Workout GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Model.Workout GetByDate(string date)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Model.Workout> SearchFor(System.Linq.Expressions.Expression<Func<Model.Workout, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoGetFit.Model;
using System.Linq.Expressions; 
namespace GoGetFit.Repository

{
    public interface IWorkoutRepository
    {
        int GetWorkoutDays();
        void Add();
        void Delete();
        void Update();
        void Clear();
        IQueryable<Workout> PastWorkouts();
        int CalculateMonth();
        IQueryable<Workout> All();
        Workout GetById(int id);
        Workout GetByDate(string date);
        IQueryable<Workout> SearchFor(Expression<Func<Workout, bool>> predicate);

    }
}

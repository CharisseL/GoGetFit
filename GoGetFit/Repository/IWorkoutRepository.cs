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
        int GetWorkoutCount();
        void Add(Workout E);
        void Delete(Workout E);
        void Clear();
        List<Workout> PastWorkouts();
        int CalculateMonth(Workout E);
        List<Workout> All();
        Workout GetById(int id);
        Workout GetByDate(string date);
        IQueryable<Workout> SearchFor(Expression<Func<Workout, bool>> predicate);

    }
}

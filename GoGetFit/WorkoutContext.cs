using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using GoGetFit.Model;

namespace GoGetFit
{
    public class WorkoutContext: DbContext
    {
        public DbSet<Workout> Workouts { get; set; }

        public WorkoutContext()
        {

        }

    }
}

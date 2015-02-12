using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoGetFit.Model
{
    public class Workout
    {
        public string Date;
        public string Name;

        public Workout(string WorkoutName, string WorkoutDate)
        {
            this.Name = WorkoutName;
            this.Date = WorkoutDate;
        }
       
    }
}

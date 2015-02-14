using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace GoGetFit.Model
{
    public class Workout
    {
        public static ObservableCollection<Workout> Workouts = new ObservableCollection<Workout>();
        public int WorkoutId { get; set; }
        public string Date { get; set; }
        public string Name { get; set; }

        public Workout(string WorkoutName, string WorkoutDate)
        {
            this.Name = WorkoutName;
            this.Date = WorkoutDate;
            Workouts.Add(this);
        }
       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace GoGetFit.Model
{
    public class Workout : INotifyPropertyChanged
    {
        public static ObservableCollection<Workout> Workouts = new ObservableCollection<Workout>();
        public int WorkoutId { get; set; }
        public string Date { get; set; }
        public string Name { get; set; }
      
       

        public Workout(string WorkoutName, string WorkoutDate)
        {
            this.Name = WorkoutName;
            this.Date = WorkoutDate;
           
        }

        public Workout()
        {

        }


        public event PropertyChangedEventHandler PropertyChanged;
    }
}

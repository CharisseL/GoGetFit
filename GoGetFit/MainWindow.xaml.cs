using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GoGetFit.Model;
using GoGetFit;

namespace GoGetFit
{
    public partial class MainWindow : Window 
    {
        public ObservableCollection<Workout> Workouts;
        public WorkoutContext _dbContext;
        public MainWindow()
            {
                using(var _dbContext = new WorkoutContext())
                {
                    _dbContext.Workouts.Add(new Workout("Boxing Class", "06/30/2015"));
                    _dbContext.Workouts.Add(new Workout("Yoga", "11/29/2015"));
                    _dbContext.SaveChanges();
                    //Workouts= new ObservableCollection<Workout>();
                }                 
                InitializeComponent();
                //WorkoutList.DataContext = _dbContext.Workouts.Local;
        }

            private void AddWorkoutButton_Click(object sender, RoutedEventArgs e)
            {

            }

      
    

    }
}

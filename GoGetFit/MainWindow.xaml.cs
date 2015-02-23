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
using System.Data.Entity;
using GoGetFit.Model;
using GoGetFit.Repository;
using GoGetFit;

namespace GoGetFit
{
    public partial class MainWindow : Window 
    {
        //public ObservableCollection<Workout> Workouts;
        //public WorkoutContext _dbContext;
        public static WorkoutRepository repo = new WorkoutRepository();
        public MainWindow()
            {
               InitializeComponent();
                WorkoutList.DataContext = repo.GetAllWorkouts();
            }                 
            private void AddWorkoutButton_Click(object sender, RoutedEventArgs e)
            {
                var viewWorkoutForm = new WorkoutForm();
                viewWorkoutForm.Show();
            }

      
    

    }
}

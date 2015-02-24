using GoGetFit.Model;
using GoGetFit.Repository;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;


namespace GoGetFit
{
    /// <summary>
    /// Interaction logic for WorkoutForm.xaml
    /// </summary>
    public partial class WorkoutForm : Window
    {
        //private WorkoutRepository repo;
        //private Workout workout;
        public WorkoutForm()
        //storage container variables here
        {
            InitializeComponent();
         }    
       
        private void AddWorkout_Click(object sender, RoutedEventArgs e)
        {
           // new Workout(NewWorkoutTextbox.Text);
           // NewWorkoutTextbox.Clear();
            
            /*repo = new WorkoutRepository();
            string workout_date = Workout_Date.Text;
            string workout_name = Workout_Name.Text;
            string workout_location = Workout_Location.Text;
            wrkout = new Workout(workout_date, workout_name, workout_location);
            repo.Add(wrkout);
            Workout_Date.Text = "";
            Workout_Name.Text = "";
            Workout_Location.Text = "";*/
        }
    }
}

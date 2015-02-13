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

namespace GoGetFit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
      

            public MainWindow()
            {
                new Workout("Blue Trail Run", "05/03/15");
               
                InitializeComponent();
                WorkoutList.DataContext = Workout.Workouts;
        }

        private void AddWorkoutButton_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}

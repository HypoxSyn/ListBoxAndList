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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ListBoxAndList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Match> matches = new List<Match> ();
            matches.Add(new Match()  { Team1 = "Denver Roller Derby", Team2 = "Arch Rival", Score1 = 180,  Score2 = 78, Completion = 85 });
            matches.Add(new Match()  { Team1 = "Denver Roller Derby", Team2 = "Angel City", Score1 = 120, Score2 = 7, Completion = 70 });
            matches.Add(new Match()  { Team1 = "Denver Roller Derby", Team2 = "Gotham City", Score1 = 110, Score2 = 100, Completion = 62 });
            matches.Add(new Match()  { Team1 = "Denver Roller Derby", Team2 = "Rose City", Score1 = 400, Score2 = 399, Completion = 57 });
            lbMatches.ItemsSource = matches; //the Method ItemsSource is a method that uses the element preceding to attach a data source to it's display component

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if(lbMatches.SelectedItem != null)
            {
                MessageBox.Show("Selected Match: "
                   +(lbMatches.SelectedItem as Match).Team1 + " " +
                    (lbMatches.SelectedItem as Match).Score1 + " " +
                    (lbMatches.SelectedItem as Match).Score2 + " " +
                    (lbMatches.SelectedItem as Match).Team2);
            }
        }
    }

    public class Match
    {
        public int Score1 { get; set; }
        public int Score2 { get; set; }
        public string Team1 { get; set; }
        public string Team2 { get; set; }
        public int Completion { get; set; }


    }
}

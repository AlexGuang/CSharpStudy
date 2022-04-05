using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.MobileControls;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace ListBoxWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
          
            List<Match> matches = new List<Match>();
            matches.Add(new Match() { Team1="Bayern Munichfddddddddddddddddddsadsadsadsadsaddddddddddddddd", Team2="Real Madridhgfhgfhfghgfhfghfghgf", Score1="3", Score2="2",Process= 80 });

            listBox.ItemsSource = matches;
        }
    }
    public class Match
    {
        public string Team1 { get; set; }
        public string Team2 { get; set; }
        public string Score1 { get; set; }
        public string Score2 { get; set; }
        public int Process { get; set; }
    }
}

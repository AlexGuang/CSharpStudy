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

namespace LISTBOXWPF2
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
            matches.Add(new Match()
            {
                Team1 = "鲁能",
                Team2 = "恒大",
                Score1 = "3",
                Score2 = "2",
                Completion = 80

            });
            matches.Add(new Match()
            {
                Team1 = "上港",
                Team2 = "泰达",
                Score1 = "1",
                Score2 = "0",
                Completion = 30

            });
            matches.Add(new Match()
            {
                Team1 = "康师傅",
                Team2 = "华润",
                Score1 = "2",
                Score2 = "3",
                Completion = 60

            });
            matches.Add(new Match()
            {
                Team1 = "拜仁慕尼黑",
                Team2 = "巴塞罗那",
                Score1 = "1",
                Score2 = "1",
                Completion = 10

            });
            matches.Add(new Match()
            {
                Team1 = "皇家马德里",
                Team2 = "尤文图斯",
                Score1 = "4",
                Score2 = "5",
                Completion = 88

            });
            lbsource.ItemsSource = matches;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (lbsource.SelectedItem!= null)
            {
                MessageBox.Show("Selected Match:" +
                    (lbsource.SelectedItem as Match).Team1 + " " +
                    (lbsource.SelectedItem as Match).Score1 + " " +
                    (lbsource.SelectedItem as Match).Team2 + " " +
                    (lbsource.SelectedItem as Match).Score2);

            }
        }
    }
    public class Match
    {
        public string Team1 { get; set; }
        public string Score1 { get; set; }
        public string Team2 { get; set; }
        public string Score2 { get; set; }
        public int Completion { get; set; }
    }
}

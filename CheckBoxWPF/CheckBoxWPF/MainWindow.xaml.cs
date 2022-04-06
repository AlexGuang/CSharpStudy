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

namespace CheckBoxWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnAllCheckedChanged(object sender, RoutedEventArgs e)
        {
            if (cbAllTopings.IsChecked != null)
            {
                bool ifchecked = ((bool) cbAllTopings.IsChecked == true);
                cbAllTopings.IsChecked = ifchecked;
                cbMozzarella.IsChecked = ifchecked;
                cbMushroom.IsChecked = ifchecked;
                cbSalami.IsChecked = ifchecked;
            }
           
        }

        private void OnSingleCheckedChanged(object sender, RoutedEventArgs e)
        {
            cbAllTopings.IsChecked = null;
            if ((cbSalami.IsChecked == true) && cbMushroom.IsChecked == true && cbMozzarella.IsChecked == true)
            {
                cbAllTopings.IsChecked = true;
            }
            else if ((cbSalami.IsChecked == false) && cbMushroom.IsChecked == false && cbMozzarella.IsChecked == false)
            {
                cbAllTopings.IsChecked = false;
            }
        }
    }
}

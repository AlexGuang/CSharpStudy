﻿using System;
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

namespace RadioButtonWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            rbMaybe.IsChecked = true;
        }

        private void OnYesChecked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Thank you, I love you baby!");
        }
        private void OnNoCheacked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Please select Yes!");
        }
        private void OnMaybeChecked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Please select Yes!");
        }
    }
}

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

namespace WPF02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Grid grid = new Grid();
            this.Content = grid;
            Button button = new Button();
            button.Width = 300;
            button.Height = 160;
            button.FontSize = 26;

            WrapPanel wrapPanel = new WrapPanel();
            TextBlock textBlock = new TextBlock();
            textBlock.Text = "Multi";
            textBlock.Foreground = Brushes.Blue;
            wrapPanel.Children.Add(textBlock);

            textBlock = new TextBlock();
            textBlock.Text = "Color";
            textBlock.Foreground = Brushes.Red;
            wrapPanel.Children.Add(textBlock);

            textBlock = new TextBlock();
            textBlock.Text = "Button";
            textBlock.Foreground = Brushes.Green;
            wrapPanel.Children.Add(textBlock);

            button.Content = wrapPanel;
            grid.Children.Add(button);




        }
    }
}

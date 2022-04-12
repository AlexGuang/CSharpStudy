using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
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

namespace ThreadTasksWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       public static readonly DependencyProperty HtmlProperty = DependencyProperty.RegisterAttached("Html", typeof(string), typeof(MainWindow),new FrameworkPropertyMetadata(OnHtmlChanged));
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MyButton_Click(object sender, RoutedEventArgs e)
        {
            Task.Run(() =>
            {
                Debug.WriteLine($"The current thread is no.{Thread.CurrentThread.ManagedThreadId}");
                HttpClient webclient = new HttpClient();
                string html = webclient.GetStringAsync("https://google.com").Result;

                MyButton.Dispatcher.Invoke(() =>
                {
                    MyButton.Content = "Done";
                    Debug.WriteLine($"The current thread is no.{Thread.CurrentThread.ManagedThreadId}");

                });
                

            });
          
        }
        private async void MyButton_Click3(object sender, RoutedEventArgs e)
        {
            string myHtml = "haha";

            Debug.WriteLine($"The current thread is no.{Thread.CurrentThread.ManagedThreadId} before await task");
            await Task.Run(async() =>
            {
                Debug.WriteLine($"The current thread is no.{Thread.CurrentThread.ManagedThreadId} during await task");
                HttpClient webclient = new HttpClient();
                string html = webclient.GetStringAsync("https://abc.net.au/").Result;
                myHtml = html;
            });
           
            
                MyButton2.Content = "爱宝贝";
                Debug.WriteLine($"The current thread is no.{Thread.CurrentThread.ManagedThreadId} after await task" );       
                MyWebBrowser.SetValue(HtmlProperty, myHtml);

        }
        private async void MyButton_Click1(object sender, RoutedEventArgs e)
        {
            string myHtml = "haha";

            Debug.WriteLine($"The current thread is no.{Thread.CurrentThread.ManagedThreadId} before await task");
            await Task.Run(async () =>
            {
                Debug.WriteLine($"The current thread is no.{Thread.CurrentThread.ManagedThreadId} during await task");
                HttpClient webclient = new HttpClient();
                string html = webclient.GetStringAsync("https://google.com").Result;
                myHtml = html;
            });


            MyButton.Content = "爱宝贝";
            Debug.WriteLine($"The current thread is no.{Thread.CurrentThread.ManagedThreadId} after await task");
            MyWebBrowser.SetValue(HtmlProperty, myHtml);

        }
        private async void MyButton_Click2(object sender, RoutedEventArgs e)
        {
            string myHtml = "haha";

            Debug.WriteLine($"The current thread is no.{Thread.CurrentThread.ManagedThreadId} before await task");
            await Task.Run(async () =>
            {
                Debug.WriteLine($"The current thread is no.{Thread.CurrentThread.ManagedThreadId} during await task");
                HttpClient webclient = new HttpClient();
                string html = webclient.GetStringAsync("https://tianqi.com/coutury_australia/").Result;
                myHtml = html;
            });


            MyButton1.Content = "爱宝贝";
            Debug.WriteLine($"The current thread is no.{Thread.CurrentThread.ManagedThreadId} after await task");
            MyWebBrowser.SetValue(HtmlProperty, myHtml);

        }
        private async void MyButton_Click4(object sender, RoutedEventArgs e)
        {
            string myHtml = "haha";

            Debug.WriteLine($"The current thread is no.{Thread.CurrentThread.ManagedThreadId} before await task");
            await Task.Run(async () =>
            {
                Debug.WriteLine($"The current thread is no.{Thread.CurrentThread.ManagedThreadId} during await task");
                HttpClient webclient = new HttpClient();
                string html = webclient.GetStringAsync("https://youtube.com/").Result;
                myHtml = html;
            });


            MyButton3.Content = "爱宝贝";
            Debug.WriteLine($"The current thread is no.{Thread.CurrentThread.ManagedThreadId} after await task");
            MyWebBrowser.SetValue(HtmlProperty, myHtml);

        }
        private async void MyButton_Click5(object sender, RoutedEventArgs e)
        {
            string myHtml = "haha";

            Debug.WriteLine($"The current thread is no.{Thread.CurrentThread.ManagedThreadId} before await task");
            await Task.Run(async () =>
            {
                Debug.WriteLine($"The current thread is no.{Thread.CurrentThread.ManagedThreadId} during await task");
                HttpClient webclient = new HttpClient();
                string html = webclient.GetStringAsync("https://world.taobao.com/").Result;
                myHtml = html;
            });


            MyButton4.Content = "爱宝贝";
            Debug.WriteLine($"The current thread is no.{Thread.CurrentThread.ManagedThreadId} after await task");
            MyWebBrowser.SetValue(HtmlProperty, myHtml);

        }

        private static void OnHtmlChanged(DependencyObject o, DependencyPropertyChangedEventArgs dependency)
        {
            WebBrowser webbrowser = o as WebBrowser;
            if (webbrowser != null)
            {
                webbrowser.NavigateToString(dependency.NewValue as string);
            }
        }
    }
}

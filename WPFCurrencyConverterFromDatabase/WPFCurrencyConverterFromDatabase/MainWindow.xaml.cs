using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using System.Configuration;
using System.Data;

namespace WPFCurrencyConverterFromDatabase
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection sqlConnection ;
        SqlCommand sqlCommand = new SqlCommand();
        SqlDataAdapter sqlAdapter = new SqlDataAdapter();

        public MainWindow()
        {
            InitializeComponent();
            ShowData();
        }
        private void ConnectDatabase()
        {
            string sqlConnectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            sqlConnection = new SqlConnection(sqlConnectionString);
            sqlConnection.Open();
        }
        private void ShowData()
        {
            ConnectDatabase();
            sqlCommand = new SqlCommand("select * from Currency_Master",sqlConnection) ;
            sqlCommand.CommandType = CommandType.Text;
            sqlAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlAdapter.Fill(dataTable);

            DataRow newRow = dataTable.NewRow();

            newRow["Id"] = 0;
            newRow["CurrencyName"] = "--Select--";
            dataTable.Rows.Add(newRow);// 可以替代为 dt.Rows.InsertAt(newRow,0);
            if (dataTable!= null && dataTable.Rows.Count> 0)
            {
                cmbFromCurrency.ItemsSource = dataTable.DefaultView;
                cmbFromCurrency.DisplayMemberPath = dataTable.Columns[2].ColumnName;
                cmbFromCurrency.SelectedValuePath = dataTable.Columns[1].ColumnName;
                cmbFromCurrency.SelectedIndex = 0;




                cmbToCurrency.ItemsSource = dataTable.DefaultView;
                cmbToCurrency.DisplayMemberPath = dataTable.Columns[2].ColumnName;
                cmbToCurrency.SelectedValuePath = dataTable.Columns[1].ColumnName;
                cmbToCurrency.SelectedIndex = 0;
            }
            else
            {
                dgvCurrency.ItemsSource=null;
            }
         
            sqlConnection.Close();


        }

        private void btnConvert_Click(object sender, RoutedEventArgs e)
        {
            double convertedMount;
            if (textBoxConverter.Text== null || textBoxConverter.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter a value:","Information",MessageBoxButton.OK,MessageBoxImage.Information);
                textBoxConverter.Focus();
                return;
            }
            else if (cmbFromCurrency.SelectedIndex == 0 || cmbFromCurrency.SelectedItem == null)
            {
                MessageBox.Show("Please select a value in the original currency:", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                cmbFromCurrency.Focus();
                return;
            }
            else if (cmbToCurrency.SelectedIndex == 0 || cmbToCurrency.SelectedItem == null)
            {
                MessageBox.Show("Please select a value in the aim currency:", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                cmbToCurrency.Focus();
                return;
            }
            else
            {
                convertedMount = double.Parse(cmbFromCurrency.SelectedIndex.ToString())/ double.Parse(cmbToCurrency.SelectedIndex.ToString())* double.Parse(textBoxConverter.Text.ToString());
                labelCurrency.Content = convertedMount.ToString("N3");
                return;
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            ClearControls();

        }
        private void ClearControls()
        {
            textBoxConverter.Text = string.Empty;
            if (cmbFromCurrency.SelectedIndex > 0 && cmbFromCurrency.Items.Count> 0)
            {
                cmbFromCurrency.SelectedIndex = 0;
            }
            if (cmbToCurrency.SelectedIndex > 0 && cmbToCurrency.Items.Count > 0)
            {
                cmbToCurrency.SelectedIndex = 0;

            }
            labelCurrency.Content = "";
        }
    }
}

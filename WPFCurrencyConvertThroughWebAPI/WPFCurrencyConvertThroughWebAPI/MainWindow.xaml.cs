using Newtonsoft.Json;
using System;
using System.Collections.Generic;
//This is for create DataTable
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Text;
//This library is used for Regular Expression
using System.Text.RegularExpressions;
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

namespace WPFCurrencyConvertThroughWebAPI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static Root val;


        public MainWindow()
        {
            
            InitializeComponent();
        

            //ResetControl method  is used to clear all control values
            ResetControl();

            //BindCurrency is used to bind Currency name with the rates in the combobox
            GetValue();




        }
        private static  async Task<Root> GetData<T>(string url)
        {
            var myRoot = new Root();
            try
            {
                using(var client = new HttpClient())
                {
                    client.Timeout = TimeSpan.FromMinutes(1);
                    HttpResponseMessage response = await client.GetAsync(url);
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var ResponceString = await response.Content.ReadAsStringAsync();
                        var ResponceObject = JsonConvert.DeserializeObject<Root>(ResponceString);

                        return ResponceObject;
                    }
                    return myRoot;
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return myRoot;
            }
        }
        private async void GetValue()
        {
           val = await GetData<Root>("https://openexchangerates.org/api/latest.json?app_id=7374b7d844da4633a965ce669f5cc97e");
            BindCurrency();
        }
        #region Bind Currency from and to combobox
        private void BindCurrency()
        {
            //Create a Datatable Object
            DataTable dataTable = new DataTable();
            
            //Add the text column in the DataTable
            dataTable.Columns.Add("Text");// the name column of the currency

            //Add the rate column in the DataTable
            dataTable.Columns.Add("Rates");// the base rate of the currency

            //Add rows in the DataTable with text and value
            dataTable.Rows.Add("--SELECT--", 0);
            dataTable.Rows.Add("CNY", val.rates.CNY);
            dataTable.Rows.Add("USD", val.rates.USD);
            dataTable.Rows.Add("JPY", val.rates.JPY);
            dataTable.Rows.Add("AUD", val.rates.AUD);
            dataTable.Rows.Add("CAD", val.rates.CAD);
            dataTable.Rows.Add("EUR", val.rates.EUR);
            dataTable.Rows.Add("GBP", val.rates.GBP);
            dataTable.Rows.Add("RUB", val.rates.RUB);
            dataTable.Rows.Add("INR", val.rates.INR);// Add many currency names and rates into the data table

            //DataTable data assigned to the  From currency combobox
            cmbFromCurrency.ItemsSource = dataTable.DefaultView;
            
            //SelectedValuePath property is used to set the value in the combobox
            cmbFromCurrency.SelectedValuePath = "Rates";

            //DisplayMemberPath is used to display data in the combobox
            cmbFromCurrency.DisplayMemberPath = "Text";

            //SelectedIndex property is used to bind the combobox to its default selected item
            cmbFromCurrency.SelectedIndex = 0;

            //DataTable data assigned to the  To currency combobox
            cmbToCurrency.ItemsSource = dataTable.DefaultView;
            

            //All properties are set to  To Currency combobox as it is in the From Currency Combobox
            cmbToCurrency.SelectedValuePath = "Rates";
            cmbToCurrency.DisplayMemberPath = "Text";
            cmbToCurrency.SelectedIndex = 0;
        }
        #endregion


        /// <summary>
        /// Convert the button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvert_Click(object sender, RoutedEventArgs e)
        {
            //Create the variable as ConvertedValue with double datatype to store currency converted value
            double currencyValue;

            //Check if the amount textbox is Null or Blank
            if (txtCurrency.Text == null || txtCurrency.Text.Trim() == "")
            {
                //If textbox is null or blank it will show this message box
                MessageBox.Show("Please Enter Currency.", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                
                //After clicking on messagebox Ok set focus on text box
                txtCurrency.Focus();
                return;

            }
            //Else if  FromCurrency combo box is not selected or select a default value -- select--
            else if (cmbFromCurrency.SelectedIndex== 0 || cmbFromCurrency.SelectedValue == null)
            {
                // show the message
                MessageBox.Show("Please Select Currency From.", "Information", MessageBoxButton.OK, MessageBoxImage.Information);

                //Set focus on the from combobox
                cmbFromCurrency.Focus();
                return;

            }
            //Else if ToCurrency Combo box is not selected or select default text --Select--
            else if (cmbToCurrency.SelectedIndex == 0 || cmbToCurrency.SelectedValue == null)
            {
                //show the message
                MessageBox.Show("Please Select Currency To.", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                
                //Set focus on the To combo box
                cmbToCurrency.Focus();
                return;
            }
            else
            {
                //Calculation for currency converter is From Currency value mutiply(*) with the textbox value and then that total divided(/) with To currency combobox value
                currencyValue = Double.Parse(cmbToCurrency.SelectedValue.ToString())/Double.Parse(cmbFromCurrency.SelectedValue.ToString()) * Double.Parse(txtCurrency.Text.ToString());
                
                //Show the label converted currency and converted currency name.
                lblCurrency.Content = cmbToCurrency.Text.ToString() +": "+ currencyValue.ToString("N3");
            }

        }

        /// <summary>
        /// Clear Button click event,used to clear all controls value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            
            ResetControl();

        }
        private void ResetControl()
        {
            txtCurrency.Text = string.Empty;
            if (cmbToCurrency.Items.Count>0) // if there is no element inside the combo box, the program would crash.
            {
                cmbToCurrency.SelectedIndex = 0;
            }
            if (cmbFromCurrency.Items.Count> 0)// if there is no element inside the combo box, the program would crash.
            {
                cmbFromCurrency.SelectedIndex = 0;
            }          
           
           
            lblCurrency.Content = "";
            txtCurrency.Focus();
        }
        /// <summary>
        /// Event method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="ee"></param>
        private void InputInspecktion(object sender, TextCompositionEventArgs ee)// Allow only integer in the text box
        {
            Regex regrx = new Regex("[^(0-9)]+");//Regular Expression is used to add regex
            
            //Add Library using System.Text.RegularExpressions;
            ee.Handled = regrx.IsMatch(ee.Text);
        }

       
    }
}

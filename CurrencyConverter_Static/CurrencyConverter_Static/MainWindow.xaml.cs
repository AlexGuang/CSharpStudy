using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
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

namespace CurrencyConverter_Static
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
   
        public partial class MainWindow : Window
        {
            public MainWindow()
            {
                InitializeComponent();

                //ClearControls method is used to clear all control values
                ClearControls();

                //BindCurrency is used to bind currency name with the value in the Combobox
                BindCurrency();
            }

            #region Bind Currency From and To Combobox
            private void BindCurrency()

            {
                //Create a Datatable Object
                DataTable dtCurrency = new DataTable();

                //Add the text column in the DataTable
                dtCurrency.Columns.Add("Text");

                //Add the value column in the DataTable
                dtCurrency.Columns.Add("Value");

                //Add rows in the Datatable with text and value
                dtCurrency.Rows.Add("--SELECT--", 0);
                dtCurrency.Rows.Add("INR", 1);
                dtCurrency.Rows.Add("USD", 75);
                dtCurrency.Rows.Add("EUR", 85);
                dtCurrency.Rows.Add("SAR", 20);
                dtCurrency.Rows.Add("POUND", 5);
                dtCurrency.Rows.Add("DEM", 43);

                //Datatable data assigned from the currency combobox
                cmbFromCurrency.ItemsSource = dtCurrency.DefaultView;

                //DisplayMemberPath property is used to display data in the combobox
                cmbFromCurrency.DisplayMemberPath = "Text";

                //SelectedValuePath property is used to set the value in the combobox
                cmbFromCurrency.SelectedValuePath = "Value";

                //SelectedIndex property is used to bind the combobox to its default selected item 
                cmbFromCurrency.SelectedIndex = 0;

                //All properties are set to To Currency combobox as it is in the From Currency combobox
                cmbToCurrency.ItemsSource = dtCurrency.DefaultView;
                cmbToCurrency.DisplayMemberPath = "Text";
                cmbToCurrency.SelectedValuePath = "Value";
                cmbToCurrency.SelectedIndex = 0;
            }
            #endregion

            #region Button Click Event

            //Convert the button click event
            private void Convert_Click(object sender, RoutedEventArgs e)
            {
                //Create the variable as ConvertedValue with double datatype to store currency converted value
                double ConvertedValue;

                //Check if the amount textbox is Null or Blank
                if (txtCurrency.Text == null || txtCurrency.Text.Trim() == "")
                {
                    //If amount textbox is Null or Blank it will show this message box
                    MessageBox.Show("Please Enter Currency", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                    //After clicking on messagebox OK set focus on amount textbox
                    txtCurrency.Focus();
                    return;
                }
                //Else if currency From is not selected or select default text --SELECT--
                else if (cmbFromCurrency.SelectedValue == null || cmbFromCurrency.SelectedIndex == 0)
                {
                    //Show the message
                    MessageBox.Show("Please Select Currency From", "Information", MessageBoxButton.OK, MessageBoxImage.Information);

                    //Set focus on the From Combobox
                    cmbFromCurrency.Focus();
                    return;
                }
                //Else if currency To is not selected or select default text --SELECT--
                else if (cmbToCurrency.SelectedValue == null || cmbToCurrency.SelectedIndex == 0)
                {
                    //Show the message
                    MessageBox.Show("Please Select Currency To", "Information", MessageBoxButton.OK, MessageBoxImage.Information);

                    //Set focus on the To Combobox
                    cmbToCurrency.Focus();
                    return;
                }

                //Check if From and To Combobox selected values are same
                if (cmbFromCurrency.Text == cmbToCurrency.Text)
                {
                    //Amount textbox value set in ConvertedValue.
                    //double.parse is used for converting the datatype String To Double.
                    //Textbox text have string and ConvertedValue is double Datatype
                    ConvertedValue = double.Parse(txtCurrency.Text);

                    //Show the label converted currency and converted currency name and ToString("N3") is used to place 000 after the dot(.)
                    lblCurrency.Content = cmbToCurrency.Text + " " + ConvertedValue.ToString("N3");
                }
                else
                {
                    //Calculation for currency converter is From Currency value multiply(*) 
                    //With the amount textbox value and then that total divided(/) with To Currency value
                    ConvertedValue = (double.Parse(cmbFromCurrency.SelectedValue.ToString()) * double.Parse(txtCurrency.Text)) / double.Parse(cmbToCurrency.SelectedValue.ToString());

                    //Show the label converted currency and converted currency name.
                    lblCurrency.Content = cmbToCurrency.Text + " " + ConvertedValue.ToString("N3");
                }
            }

            //Clear Button click event
            private void Clear_Click(object sender, RoutedEventArgs e)
            {
                //ClearControls method is used to clear all controls value
                ClearControls();
            }
            #endregion

            #region Extra Events

            //ClearControls method is used to clear all controls value
            private void ClearControls()
            {
                txtCurrency.Text = string.Empty;
                if (cmbFromCurrency.Items.Count > 0)
                    cmbFromCurrency.SelectedIndex = 0;
                if (cmbToCurrency.Items.Count > 0)
                    cmbToCurrency.SelectedIndex = 0;
                lblCurrency.Content = "";
                txtCurrency.Focus();
            }

            private void NumberValidationTextBox(object sender, TextCompositionEventArgs e) //Allow Only Integer in Text Box
            {
                //Regular Expression is used to add regex.
                // Add Library using System.Text.RegularExpressions;
                Regex regex = new Regex("[^0-9]+");
                e.Handled = regex.IsMatch(e.Text);
            }
            #endregion
        }
    
}

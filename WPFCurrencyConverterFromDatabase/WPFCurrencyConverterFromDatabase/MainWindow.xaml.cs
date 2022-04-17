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

        private int currentId = 0;
        private double amountFrom;
        private double amountTo;
        public MainWindow()
        {
            InitializeComponent();
            BindingData();
            GetData();
        }
        private void ConnectDatabase()
        {
            string sqlConnectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            sqlConnection = new SqlConnection(sqlConnectionString);
            sqlConnection.Open();
        }
        private void BindingData()
        {
            ConnectDatabase();
            sqlCommand = new SqlCommand("select * from Currency_Master",sqlConnection) ;
            sqlCommand.CommandType = CommandType.Text;
            sqlAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlAdapter.Fill(dataTable);

            DataRow newRow = dataTable.NewRow();
            newRow["Id"] = 0;
            newRow["CurrencyName"] = "--SELECT--";
            dataTable.Rows.InsertAt(newRow,0);

           
            if (dataTable!= null && dataTable.Rows.Count> 0)
            {
                cmbFromCurrency.ItemsSource = dataTable.DefaultView;    
                cmbToCurrency.ItemsSource = dataTable.DefaultView;
               



            }
            cmbFromCurrency.SelectedValuePath = "Id";
            cmbToCurrency.SelectedValuePath = "Id";
            cmbFromCurrency.DisplayMemberPath = "CurrencyName";
            cmbToCurrency.DisplayMemberPath = "CurrencyName";
            cmbFromCurrency.SelectedIndex = 0;
            cmbToCurrency.SelectedIndex = 0; ;


        }
        private void GetData()
        {
            ConnectDatabase();
            string cmd = "select * from Currency_Master";
            sqlCommand = new SqlCommand(cmd,sqlConnection);
            sqlAdapter = new SqlDataAdapter(sqlCommand);

            DataTable da = new DataTable();
            sqlAdapter.Fill(da);
            if (da!= null && da.Rows.Count > 1)
            {
                dgvCurrency.ItemsSource = da.DefaultView;
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
                convertedMount = double.Parse(textBoxConverter.Text.ToString())* amountFrom/amountTo;
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

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            ConnectDatabase();
            if (currentId != 0 )
            {
                if (textBoxAmount.Text!=null&& textBoxAmount.Text.Trim()!="" && textBoxCurrency.Text!=null &&textBoxCurrency.Text.Trim()!="")
                {
                    int enterAmont;
                    if (int.TryParse(textBoxAmount.Text.ToString(),out enterAmont))
                    {
                        if (MessageBox.Show("Do you want to update?","Information",MessageBoxButton.YesNo,MessageBoxImage.Question) == MessageBoxResult.Yes)
                        {
                            string cmdString = "Update Currency_Master set Amount = @amount, CurrencyName= @cName where Id = @id";
                            sqlCommand = new SqlCommand(cmdString, sqlConnection);
                            sqlCommand.Parameters.AddWithValue("@id", currentId);
                            sqlCommand.Parameters.AddWithValue("@cName", textBoxCurrency.Text);
                            sqlCommand.Parameters.AddWithValue("@amount", textBoxAmount.Text);

                            sqlCommand.ExecuteNonQuery();
                            sqlConnection.Close();

                            MessageBox.Show("Data has been saved.");
                            ClearMaster();
                        }
                        else
                        {
                            ClearMaster();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Enter a whole number:");
                    }
                   

                }
                else
                {
                    MessageBox.Show("Please Enter amount or currency name", "Information",MessageBoxButton.OK,MessageBoxImage.Information);
                }

            }
            else
            {
                if (textBoxAmount.Text != null && textBoxAmount.Text.Trim() != "" && textBoxCurrency.Text != null && textBoxCurrency.Text.Trim() != "")
                {
                    int enterAmont;
                    if (int.TryParse(textBoxAmount.Text.ToString(), out enterAmont))
                    {
                        if (MessageBox.Show("Do you want to save?", "Information", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                        {
                            string cmdString = "insert into Currency_Master (Amount, CurrencyName) values (@amount, @cName)";
                            sqlCommand = new SqlCommand(cmdString, sqlConnection);
                           
                            sqlCommand.Parameters.AddWithValue("cName", textBoxCurrency.Text);
                            sqlCommand.Parameters.AddWithValue("amount", textBoxAmount.Text);

                            sqlCommand.ExecuteNonQuery();
                            sqlConnection.Close();

                            MessageBox.Show("Data has been saved.");
                            ClearMaster();
                        }
                        else
                        {
                            ClearMaster();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Enter a whole number:");
                    }


                }
                else
                {
                    MessageBox.Show("Please Enter amount or currency name", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                }

            }
        }
        private void ClearMaster()
        {
            textBoxAmount.Text = string.Empty;
            textBoxCurrency.Text = string.Empty;
            btnUpdate.Content = "Save";
            GetData();
            currentId = 0;           
            BindingData();
            textBoxAmount.Focus();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ClearMaster();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                
            }
        }

        private void dgvCurrency_SelectionChanged1(object sender, SelectedCellsChangedEventArgs e)
        {
            try
            {
                DataGrid dg = (DataGrid)sender;
                DataRowView rowSelected = dg.CurrentItem as DataRowView;

                if (rowSelected != null)
                {
                    if (dgvCurrency.Items.Count > 0)
                    {
                        if (dg.SelectedCells.Count > 0)
                        {
                            currentId = Int32.Parse(rowSelected["Id"].ToString());

                            if (dg.SelectedCells[0].Column.DisplayIndex == 0)
                            {
                                textBoxAmount.Text = rowSelected["Amount"].ToString();

                                textBoxCurrency.Text = rowSelected["CurrencyName"].ToString();

                                btnUpdate.Content = "Update";
                            }
                            if (dg.SelectedCells[0].Column.DisplayIndex == 1)
                            {

                                if (MessageBox.Show("Are you sure to delete the row? ", "Information", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                                {
                                    ConnectDatabase();
                                    string delete = "delete from Currency_Master where Id = @id";
                                    sqlCommand = new SqlCommand(delete, sqlConnection);
                                    sqlCommand.CommandType = CommandType.Text;
                                    sqlCommand.Parameters.AddWithValue("@id", currentId);
                                    sqlCommand.ExecuteNonQuery();

                                    sqlConnection.Close();

                                    MessageBox.Show("Data deleted successfully", "Information", MessageBoxButton.OK, MessageBoxImage.Information);

                                    ClearMaster();
                                }

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Error", MessageBoxButton.OK, MessageBoxImage.Error);

            }

        }

        private void cmbFromCurrency_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //ConnectDatabase();
            //int index = cmbFromCurrency.SelectedIndex;
            //DataTable da = new DataTable();
            //string cmd = "select Amount from Currency_Master where Id = @id";
            //sqlCommand = new SqlCommand(cmd, sqlConnection);
            //sqlCommand.Parameters.AddWithValue("@id", index);

            //sqlAdapter = new SqlDataAdapter(sqlCommand);
            //sqlAdapter.Fill(da);
            //amountFrom = int.Parse(da.Rows[0].ToString());
            try
            {
                if (cmbFromCurrency.SelectedValue!=null && int.Parse(cmbFromCurrency.SelectedValue.ToString())!=0 && cmbFromCurrency.SelectedIndex!=0)
                {
                    int CurrencyFromId = int.Parse(cmbFromCurrency.SelectedValue.ToString());
                    ConnectDatabase();
                    DataTable dt = new DataTable();
                    sqlCommand = new SqlCommand("Select Amount from Currency_Master where Id = @id", sqlConnection);
                    sqlCommand.CommandType = CommandType.Text;

                    if (CurrencyFromId != null && CurrencyFromId!= 0)
                    {
                        sqlCommand.Parameters.AddWithValue("@id", CurrencyFromId);

                    }
                    sqlAdapter = new SqlDataAdapter(sqlCommand);
                    sqlAdapter.Fill(dt);

                    if (dt!= null&& dt.Rows.Count>0)
                    {
                        amountFrom = double.Parse(dt.Rows[0]["Amount"].ToString());
                    }
                    sqlConnection.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Error",MessageBoxButton.OK,MessageBoxImage.Error);
            }

        }

        private void cmbToCurrency_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                
                if (cmbToCurrency.SelectedValue != null && int.Parse(cmbToCurrency.SelectedValue.ToString()) != 0 && cmbToCurrency.SelectedIndex != 0)
                {
                   int cmbToCurrencyf = int.Parse(cmbToCurrency.SelectedValue.ToString());
                    ConnectDatabase();
                    sqlCommand = new SqlCommand("select Amount from Currency_Master where Id = @id",sqlConnection);
                    sqlCommand.CommandType = CommandType.Text;
                    if (cmbToCurrencyf != 0 && cmbToCurrencyf != null)
                    {
                        sqlCommand.Parameters.AddWithValue("@id", cmbToCurrencyf);
                    }
                    DataTable dt = new DataTable();
                    
                    sqlAdapter = new SqlDataAdapter(sqlCommand);
                    sqlAdapter.Fill(dt);
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        amountTo = double.Parse(dt.Rows[0]["Amount"].ToString());
                    }
                    sqlConnection.Close();
                }

            }
            catch (Exception ex)
            {

               MessageBox.Show(ex.ToString(),"Error",MessageBoxButton.OK,MessageBoxImage.Error);
            }

        }

        #region Preview Key Down Events
        //cmbFromCurrency preview key down event
        private void cmbFromCurrency_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            //If the user press Tab or Enter key then cmbFromCurrency_SelectionChanged event is executed
            if (e.Key == Key.Tab || e.SystemKey == Key.Enter)
            {
                cmbFromCurrency_SelectionChanged(sender, null);
            }
        }

        //cmbToCurrency preview key down event
        private void cmbToCurrency_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            //If the user press Tab or Enter key then cmbToCurrency_SelectionChanged event is executed
            if (e.Key == Key.Tab || e.SystemKey == Key.Enter)
            {
                cmbToCurrency_SelectionChanged(sender, null);
            }
        }
        #endregion
    }
}

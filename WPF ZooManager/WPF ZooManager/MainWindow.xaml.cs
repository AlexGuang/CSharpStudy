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
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace WPF_ZooManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection sqlConnection;
        public MainWindow()
        {
            InitializeComponent();

            
            string connectionString = ConfigurationManager.ConnectionStrings["WPF_ZooManager.Properties.Settings.XiaoguangDBConnectionString"].ConnectionString;
            sqlConnection = new SqlConnection(connectionString);


            ShowZoos();
            ShowAllAnimals();
          
        }
        private void ShowZoos()
        {
            try
            {
                string query = "select * from Zoo";
                // The SqlDataAdapter can be imagined like an Interface to make Tables usable by c#- objects
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);//方法： 1、光标在括号中间，Ctrl+Shift+空格键。 上下键查看即可。 2、写有重载的函数名后，直接打上shift+(，上下键查看即可。

                using (sqlDataAdapter)
                {
                    DataTable zooTable = new DataTable();


                    sqlDataAdapter.Fill(zooTable);

                    //Which Information of the Table in DataTable should be shown in our ListBox?
                    listZoos.DisplayMemberPath = "Location";

                    //Which Value should be delivered, when an Item from our ListBox is selected?
                    listZoos.SelectedValuePath = "Id";

                    //The Reference to the Data the ListBox should populate
                    listZoos.ItemsSource = zooTable.DefaultView;
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }
        }
        private void ShowAllAnimals()
        {
            try
            {
                string query = "select * from Animal";
                // The SqlDataAdapter can be imagined like an Interface to make Tables usable by c#- objects
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);//方法： 1、光标在括号中间，Ctrl+Shift+空格键。 上下键查看即可。 2、写有重载的函数名后，直接打上shift+(，上下键查看即可。

                using (sqlDataAdapter)
                {
                    DataTable animalTable = new DataTable();


                    sqlDataAdapter.Fill(animalTable);

                    //Which Information of the Table in DataTable should be shown in our ListBox?
                listAllAnimal.DisplayMemberPath = "Name";

                    //Which Value should be delivered, when an Item from our ListBox is selected?
                   listAllAnimal.SelectedValuePath = "Id";

                    //The Reference to the Data the ListBox should populate
                  listAllAnimal.ItemsSource = animalTable.DefaultView;
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }
        }
        private void ShowAssociatedAnimals()
        {
            try
            {
                string query = "select * from Animal \"A\" join ZooAnimal \"ZA\" on \"A\".Id = \"ZA\".AnimalId where \"ZA\".ZooId = @zd ";

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                // The SqlDataAdapter can be imagined like an Interface to make Tables usable by c#- objects
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);//方法： 1、光标在括号中间，Ctrl+Shift+空格键。 上下键查看即可。 2、写有重载的函数名后，直接打上shift+(，上下键查看即可。

                using (sqlDataAdapter)
                {

                    sqlCommand.Parameters.AddWithValue("@zd", listZoos.SelectedValue);

                    DataTable animalTable = new DataTable();


                    sqlDataAdapter.Fill(animalTable);

                    //Which Information of the Table in DataTable should be shown in our ListBox?
                   listAssociatedAnimals.DisplayMemberPath = "Name";

                    //Which Value should be delivered, when an Item from our ListBox is selected?
                    listAssociatedAnimals.SelectedValuePath = "Id";

                    //The Reference to the Data the ListBox should populate
                    listAssociatedAnimals.ItemsSource = animalTable.DefaultView;
                }
            }
            catch (Exception e)
            {

                //MessageBox.Show(e.ToString());
            }
        }

        private void listZoos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ShowAssociatedAnimals();
            OnShowSelectedZooInTextBox();
        }

        private void OnDeleteZoo(object sender, RoutedEventArgs e)
        {
            try
            {
                string deleteZooCommand = "delete from Zoo  where Id = @Id";
                SqlCommand sqlCommand = new SqlCommand(deleteZooCommand, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@Id", listZoos.SelectedValue);
                sqlCommand.ExecuteScalar();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                
            }
            finally
            {
                sqlConnection.Close();
                ShowZoos();
            }
        }

        private void OnAddZoo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "insert into Zoo (Location) values (@name)";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);

                sqlConnection.Open();
                cmd.Parameters.AddWithValue("@name", textboxInput.Text);
                cmd.ExecuteScalar();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                ShowZoos();

                sqlConnection.Close(); 
            }

        }

        private void OnAddAnimalToZoo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "insert into ZooAnimal (ZooID,AnimalId) values(@zid,@animalid) ";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                cmd.Parameters.AddWithValue("@zid", listZoos.SelectedValue);
                cmd.Parameters.AddWithValue("@animalid", listAllAnimal.SelectedValue);
                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            finally
            {
                ShowAssociatedAnimals();
                sqlConnection.Close();
            }
        }

        private void OnAddAnimal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "insert into Animal (Name) values (@animal) ";
                SqlCommand command = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                command.Parameters.AddWithValue("@animal", textboxInput.Text);
                command.ExecuteScalar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());

            }
            finally
            {
                ShowAllAnimals();

                sqlConnection.Close();



            }
        }

        private void OnDeleteAnimalFromZoo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "delete from ZooAnimal where ZooID = @zooid and AnimalId = @aniId ";
                SqlCommand c = new SqlCommand(query,sqlConnection);
                sqlConnection.Open();
                c.Parameters.AddWithValue("@zooid",listZoos.SelectedValue);
                c.Parameters.AddWithValue("@aniId",listAssociatedAnimals.SelectedValue);
                c.ExecuteScalar();



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());

            }
            finally
            {
                ShowAssociatedAnimals();
                sqlConnection.Close ();
            }
        }

        private void OnRemoveAnimal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "delete from Animal where Id = @aid ";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@aid", listAllAnimal.SelectedValue);
                sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {

                MessageBox.Show (ex.ToString());
            }
            finally
            {
                ShowAllAnimals ();
                sqlConnection.Close ();
            
            }
        }
        private void OnShowSelectedZooInTextBox()
        {

            string query = "select Location from Zoo where Id = @zid";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            //The sqlDataAdapter can be imageined like an Interface to make Tables usable by c# -objects
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            
            using (adapter)
            {
                sqlCommand.Parameters.AddWithValue("@zid",listZoos.SelectedValue);
                DataTable  dataTable = new DataTable();
                adapter.Fill(dataTable);
                textboxInput.Text = dataTable.Rows[0]["Location"].ToString();
            }
        }
        private void OnShowSelectedAnimalInTextBox()
        {
            string query = "select Name from Animal where Id = @aid";
            SqlCommand cmd = new SqlCommand(query,sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);


            using (adapter)
            {
                cmd.Parameters.AddWithValue("@aid",listAllAnimal.SelectedValue);

                DataTable dataTable = new DataTable();
                adapter.Fill (dataTable);
                textboxInput.Text = dataTable.Rows[0]["Name"].ToString();
            }
        }
        private void OnListAllAnimals_SelectedChanged(object sender,SelectionChangedEventArgs e)
        {
            OnShowSelectedAnimalInTextBox();
        }
        private void OnShowSelectedAssociatedAnimalInTextBox()
        {
            string query = "select Name from Animal a join ZooAnimal za on a.Id = za.AnimalId and za.AnimalId = @zaid";

            SqlCommand command = new SqlCommand(query,sqlConnection);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);

            using (sqlDataAdapter)
            {
                command.Parameters.AddWithValue("@zaid",listAssociatedAnimals.SelectedValue);

                DataTable sqlDataTable = new DataTable();

                sqlDataAdapter.Fill (sqlDataTable);

                textboxInput.Text = sqlDataTable.Rows[0]["Name"].ToString();
            }
        }
        private void OnListAssoatedAnimal_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            OnShowSelectedAssociatedAnimalInTextBox();
        }
    }
}

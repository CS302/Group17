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
using WorkersLibrary;
using System.Data.OleDb;
using System.Collections.ObjectModel;

namespace WorkersEditor
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public OleDbConnection con;
        public List<Worker> Workers { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\workers.accdb");
            Workers = new List<Worker>();
            //Workers.Add(new Manager("Svetlana", 23, 6161, 9));
            //Workers.Add(new Driver("Tony", 37, 496513, "BMW", /128));
            //Workers.Add(new Manager("Ivan", 35, 84633, 7));
            //Workers.Add(new Driver("John", 26, 641315, "Audi", 256));
            LoadFromDB();
            DataContext = this;
        }

        private void LoadFromDB()
        {
            OleDbCommand select = new OleDbCommand("SELECT * FROM Drivers", con);
            con.Open();
            OleDbDataReader reader = select.ExecuteReader();
            while (reader.Read())
            {
                Workers.Add(new Driver(reader["DrName"].ToString(), Convert.ToInt32(reader["Age"]), Convert.ToInt32(reader["SNN"]), reader["CarType"].ToString(), Convert.ToInt32(reader["Hours"])));
            }
            con.Close();
        }

        private void workersList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Worker worker = (sender as ListBox).SelectedItem as Worker;
            if (worker != null)
            {
                detailsPanel.DataContext = worker;
                if (worker is Driver)
                {
                    manInfo.Visibility = System.Windows.Visibility.Collapsed;
                    drInfo.Visibility = System.Windows.Visibility.Visible;
                }
                if (worker is Manager)
                {
                    manInfo.Visibility = System.Windows.Visibility.Visible;
                    drInfo.Visibility = System.Windows.Visibility.Collapsed;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxProjCount.Text == string.Empty)
            {
                try
                {
                    Driver dr = new Driver(textBoxName.Text, Convert.ToInt32(textBoxAge.Text), Convert.ToInt32(textBoxSNN.Text), textBoxCarType
                        .Text, Convert.ToInt32(textBoxHours.Text));

                    OleDbCommand insert = new OleDbCommand("INSERT INTO Drivers (`SNN`, `DrName`, `Age`, `CarType`, `Hours`) VALUES (@snn, @drName, @age, @carType, @hours)", con);
                    insert.Parameters.AddWithValue("@snn", dr.Snn);
                    insert.Parameters.AddWithValue("@drName", dr.Name);
                    insert.Parameters.AddWithValue("@age", dr.Age);
                    insert.Parameters.AddWithValue("@carType", dr.CarType);
                    insert.Parameters.AddWithValue("@hours", dr.Hours);

                    con.Open();
                    insert.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Добавили \n" + dr.Name);
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Worker delWorker = (workersList.SelectedItem as Worker);
            if (delWorker != null)
            {
                if (delWorker is Driver)
                {
                    OleDbCommand delete = new OleDbCommand("DELETE FROM Drivers WHERE SNN =@snn", con);
                    delete.Parameters.AddWithValue("@snn", delWorker.Snn);
                    con.Open();
                    delete.ExecuteNonQuery();
                    con.Close();
                    Workers.Remove(delWorker);
                    MessageBox.Show("Удалили \n" + delWorker.Name);
                }
            }
        }
    }
}

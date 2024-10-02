using Newtonsoft.Json;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Exam_1_Review
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Restaurant> restaurants = new List<Restaurant>();


        public MainWindow()
        {
            InitializeComponent();

            // Read in the file
            string[] fileContents = File.ReadAllLines("top_10_restaurants.txt");

            // Save data to list of objects
            //      Iterate through the lines of the file (skipping the header row)

            foreach (string line in fileContents.Skip(1))
            {

                string[] parts = line.Split(';');
                //Restaurant r = new Restaurant();
                //r.Rank = Convert.ToInt32(parts[0]);
                //r.Logo = parts[1];
                //r.Name = parts[2];
                //r.Category = parts[3];
                //r.Sales = Convert.ToDouble(parts[4]);
                Restaurant r = new Restaurant(parts);
                
                // Populate the listbox
                lstRestaurants.Items.Add(r);
                restaurants.Add(r);
            }


        }

        private void lstRestaurants_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Restaurant selected = (Restaurant)lstRestaurants.SelectedItem;
            Restaurant selected = lstRestaurants.SelectedItem as Restaurant;

            if (selected != null)
            {
                txtRank.Text = selected.Rank.ToString("N0");
                txtName.Text = selected.Name;
                txtCategory.Text = selected.Category;
                txtSales.Text = selected.Sales.ToString("C");
                imgLogo.Source = new BitmapImage(new Uri(selected.Logo));
            }
        }

        private void btnFilter_Click(object sender, RoutedEventArgs e)
        {
            double value;
            if (double.TryParse(txtFilter.Text, out value) == false)
            {
                txtFilter.Clear();
                txtFilter.Text = "";
                MessageBox.Show("Invalid input");
                return;
            }

            lstRestaurants.Items.Clear(); /// removes all the items from the listbox

            foreach (var restaurant in restaurants)
            {

                if (restaurant.Sales >= value)
                {
                    lstRestaurants.Items.Add(restaurant);
                }

            }

        }

        private void btnExport_Click(object sender, RoutedEventArgs e)
        {
            string jsonContents = JsonConvert.SerializeObject(lstRestaurants.Items, Formatting.Indented);

            File.WriteAllText("filtered_restaurants.json",jsonContents);

            MessageBox.Show("Successfully saved file.");
        }
    }
}
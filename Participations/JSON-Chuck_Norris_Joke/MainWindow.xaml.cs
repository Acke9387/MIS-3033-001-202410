using Newtonsoft.Json;
using System.Net.Http;
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

namespace JSON_Chuck_Norris_Joke
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string url = "https://api.chucknorris.io/jokes/categories";
            string json;
            using (var client = new HttpClient())
            {
                json = client.GetStringAsync(url).Result;
            }

            string[] categories = JsonConvert.DeserializeObject<string[]>(json);
            cboCategories.Items.Add("All");
            foreach (var category in categories)
            {
                cboCategories.Items.Add(category);
            }
        }

        private void btnGetJoke_Click(object sender, RoutedEventArgs e)
        {
            string category = cboCategories.SelectedItem.ToString();

            string url = $"https://api.chucknorris.io/jokes/random";
            string json;

            if (category != "All")
            {
                url += $"?category={category}";
            }

            using (var client = new HttpClient())
            {
                json = client.GetStringAsync(url).Result;
            }

            var categories = JsonConvert.DeserializeObject<ChuckNorrisAPI>(json);

            txtJoke.Text = categories.value;
        }
    }
}
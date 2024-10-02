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

namespace JSON_Pokemon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Pokemon poke;
        bool shouldShowFront = true;

        public MainWindow()
        {
            InitializeComponent();

            string url = "https://pokeapi.co/api/v2/pokemon?offset=0&limit=1400";
            PokemonAPI api;
            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(url).Result;

                api = JsonConvert.DeserializeObject<PokemonAPI>(json);
            }

            foreach (var item in api.Results)
            {
                cboPokemon.Items.Add(item);
            }

        }

        private void cboPokemon_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Result selected = (Result)cboPokemon.SelectedItem;
            string url = selected.Url;
            
            
            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(url).Result;

                poke = JsonConvert.DeserializeObject<Pokemon>(json);
            }

            txtHeight.Text = poke.Height.ToString();
            txtWeight.Text = poke.Weight.ToString();
            txtName.Text = poke.Name;
            imgPokemon.Source = new BitmapImage(new Uri(poke.Sprites.Front_Default));
            shouldShowFront = false;

            btnFlip.IsEnabled = true;
        }

        private void btnFlip_Click(object sender, RoutedEventArgs e)
        {
            string url = "";
            if (poke == null)
            {
                return;
            }


            if (shouldShowFront == true)
            {
                url = poke.Sprites.Front_Default;
                shouldShowFront = false;
            }
            else
            {
                url = poke.Sprites.Back_Default;
                shouldShowFront = true;
            }

            imgPokemon.Source = new BitmapImage(new Uri(url));
        }
    }
}
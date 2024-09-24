using Newtonsoft.Json;
using System.IO;
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

namespace JSON_WebRequest_Rick_and_Morty
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            RickAndMortyAPI api;
            using (HttpClient client = new HttpClient())
            {
                string json = client.GetStringAsync("https://rickandmortyapi.com/api/character").Result;
                api = JsonConvert.DeserializeObject<RickAndMortyAPI>(json);
            }
            foreach (var result in api.Results)
            {
                cboCharacters.Items.Add(result);
            }

            string comboBoxItemsAsString = JsonConvert.SerializeObject(cboCharacters.Items);
            string json1 = JsonConvert.SerializeObject(api);

            File.WriteAllText("combobox.json", comboBoxItemsAsString);
            File.WriteAllText("api.json", json1);

        }

        private void cboCharacters_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Result character = (Result)cboCharacters.SelectedItem;

            imgCharacter.Source = new BitmapImage(new Uri(character.image));
        }
    }
}
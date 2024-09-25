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
            string json;
            using (HttpClient client = new HttpClient())
            {
                json = client.GetStringAsync("https://rickandmortyapi.com/api/character").Result;
                api = JsonConvert.DeserializeObject<RickAndMortyAPI>(json);
            }
            foreach (var result in api.Results)
            {
                cboCharacters.Items.Add(result);
            }

            string json_api_object = JsonConvert.SerializeObject(api);
            string json_combobox = JsonConvert.SerializeObject(cboCharacters.Items);

            File.WriteAllText("web_result.json", json);
            File.WriteAllText("api_object.json", json_api_object);
            File.WriteAllText("combobox.json", json_combobox);


        }

        private void cboCharacters_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Result character = (Result)cboCharacters.SelectedItem;

            imgCharacter.Source = new BitmapImage(new Uri(character.image));
        }
    }
}
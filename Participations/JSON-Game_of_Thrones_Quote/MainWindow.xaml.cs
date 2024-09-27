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

namespace JSON_Game_of_Thrones_Quote
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<GOTQuoteAPI> quotes = new List<GOTQuoteAPI>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnGet_Click(object sender, RoutedEventArgs e)
        {
            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync("https://api.gameofthronesquotes.xyz/v1/random").Result;

                GOTQuoteAPI quote = JsonConvert.DeserializeObject<GOTQuoteAPI>(json);
                txtQuote.Text = quote.sentence + $"\n\n\t-{quote.character.name}";
                quotes.Add(quote);
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            string serializedData = JsonConvert.SerializeObject(quotes, Formatting.Indented);
            File.WriteAllText("got_quotes.json", serializedData);

            MessageBox.Show("Successfully created file got_quotes.json");
        }
    }
}
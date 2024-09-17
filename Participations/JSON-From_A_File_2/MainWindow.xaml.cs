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

namespace JSON_From_A_File_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string json = File.ReadAllText("fruits.json");

            Market m = JsonConvert.DeserializeObject<Market>(json);

            foreach (Fruit f in m.fruits)
            {
                cboFruits.Items.Add(f);
            }


        }

        private void cboFruits_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Fruit selected = (Fruit)cboFruits.SelectedItem;
            txtName.Text = selected.name;
            txtPrice.Text = selected.price.ToString("C");
            imgFruit.Source = new BitmapImage(new Uri(selected.image));
        }
    }
}
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

namespace JSON_Example
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var json = File.ReadAllText("sales_data.json");
            List<Sale> salesData = JsonConvert.DeserializeObject<List<Sale>>(json);

            lstData.ItemsSource = salesData;

            //foreach (var sale in salesData)
            //{
            //    lstData.Items.Add(sale);
            //}

        }
    }
}
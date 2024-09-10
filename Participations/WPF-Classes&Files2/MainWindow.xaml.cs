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

namespace WPF_Classes_Files2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var linesOfFile = File.ReadAllLines("SalesJan2009.csv");

            foreach (var line in linesOfFile.Skip(1))
            {
                Sale currentSale;// = new Sale();
                var pieces = line.Split(',');

                //        0            1     2       3         4    5     6       7       8               9           10          11
                //Transaction_date,Product,Price,Payment_Type,Name,City,State,Country,Account_Created,Last_Login,Latitude,Longitude
                //currentSale.Price = Double.Parse(pieces[2]);
                //currentSale.PaymentType= pieces[3];
                currentSale = new Sale(Double.Parse(pieces[2]), pieces[3]);
                currentSale.Name = pieces[4];
                currentSale.Country = pieces[7];
                currentSale.TransactionDate = DateTime.Parse(pieces[0]);

                if (currentSale.PaymentType.ToLower() == "visa")
                {
                    lstVisa.Items.Add(currentSale);
                }
                else if (currentSale.PaymentType.ToLower() == "amex")
                {
                    lstAmex.Items.Add(currentSale);
                }
                else if (currentSale.PaymentType.ToLower() == "mastercard")
                {
                    lstMastercard.Items.Add(currentSale);
                }
                else if (currentSale.PaymentType.ToLower() == "diners")
                {
                    lstDiners.Items.Add(currentSale);
                }
                else
                {
                    MessageBox.Show($"{currentSale.PaymentType} is not a valid payment type for.");
                }
            }

            lblMasterCount.Content = lstMastercard.Items.Count;
        }

        private void lstMastercard_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selected = lstMastercard.SelectedItem as Sale;
            if (selected != null)
            {
                MessageBox.Show($"{selected.Country}");
            }
        }

        private void lstVisa_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selected = lstVisa.SelectedItem as Sale;
            if (selected != null)
            {
                MessageBox.Show($"{selected.Country}");
            }
        }

        private void lstDiners_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selected = lstDiners.SelectedItem as Sale;
            if (selected != null)
            {
                MessageBox.Show($"{selected.Country}");
            }
        }

        private void lstAmex_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selected = lstAmex.SelectedItem as Sale;
            if (selected != null)
            {
                MessageBox.Show($"{selected.Country}");
            }
        }
    }
}
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

namespace WPF_Classes_Files
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //string[] linesOfFile = File.ReadAllLines("Toys.csv");
            var linesOfFile = File.ReadAllLines("Toys.csv").Skip(1);

            foreach (var line in linesOfFile)
            {
                var pieces = line.Split(",");
                //   0          1     2     3
                //Manufacturer,Name,Price,Image
                Toy t = new Toy();
                t.Manufacturer = pieces[0];
                t.Name = pieces[1];
                t.Price = Convert.ToDouble(pieces[2]);
                t.Image = pieces[3];

                lstToys.Items.Add(t);
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Toy t = new Toy();
            t.Name = txtName.Text;
            t.Manufacturer = txtManufacturer.Text;
            t.Price = Convert.ToDouble(txtPrice.Text);
            t.Image = txtImage.Text;
            
            lstToys.Items.Add(t);
            
            txtName.Clear();
            txtManufacturer.Clear();
            txtPrice.Clear();
            txtImage.Clear();
        }

        private void lstToys_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //Toy selected = (Toy)lstToys.SelectedItem ;
            Toy selected = lstToys.SelectedItem as Toy;
            if (selected != null)
            {
                Uri uri = new Uri(selected.Image);
                BitmapImage bitmap = new BitmapImage(uri);
                imgToy.Source = bitmap;
                MessageBox.Show(selected.GetAisle());
                //imgToy.Source = new BitmapImage(new Uri(selected.Image, UriKind.Relative));
            }
        }
    }
}
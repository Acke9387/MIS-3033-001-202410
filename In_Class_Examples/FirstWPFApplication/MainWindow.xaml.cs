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

namespace FirstWPFApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


        }

        private void btnGo_Click(object sender, RoutedEventArgs e)
        {
            string name = txtFullname.Text;
            string address = txtAddress.Text;


            if (string.IsNullOrWhiteSpace(name) == true ||
                string.IsNullOrWhiteSpace(address) == true)
            {
                MessageBox.Show($"Invalid Input!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            Student s = new Student();
            s.FirstName = name.Split(' ')[0];
            s.LastName = name.Split(' ')[1];
            s.Address = address;

            lstStudents.Items.Add(s);
            ClearForm();
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            // Clear the textboxes
            txtFullname.Text = "";
            txtAddress.Clear();
            txtFullname.Focus();
        }

        private void lstStudents_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Student selectedStudent = (Student)lstStudents.SelectedItem;

            MessageBox.Show($"Name: {selectedStudent.FirstName} {selectedStudent.LastName}\nAddress: {selectedStudent.Address}", "Student Information", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
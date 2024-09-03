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
        List<Student> students = new List<Student>();
        public MainWindow()
        {
            InitializeComponent();
            wndMain.Background = Brushes.Red;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text;
            //DateTime? birthdate = dpBirthdate.SelectedDate;
            DateTime bday = Convert.ToDateTime(txtBirthday.Text);

            //DateTime.Parse(txtBirthday.Text);

            Student student = new Student();
            student.Name = name;
            student.Birthdate = bday;

            //students.Add(student);
            lstStudents.Items.Add(student);
        }

        private void btnAdd_MouseEnter(object sender, MouseEventArgs e)
        {
            wndMain.Background = Brushes.Blue;
        }

        private void btnAdd_MouseLeave(object sender, MouseEventArgs e)
        {
            wndMain.Background = Brushes.Red;
        }
    }
}
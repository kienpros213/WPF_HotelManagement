using System.Windows;
using System.Windows.Input;

namespace WPF_HotelManagement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(string username)
        {
            InitializeComponent();
            userNameBox.Text = username;
    }

        public string GetUser()
        {
            return userNameBox.Text;
        }

        private void booking_top_layer_MouseDown(object sender, MouseButtonEventArgs e)
        {
            bookingForm _bookingForm = new bookingForm(userNameBox.Text);
            _bookingForm.Show();
        }

        private void occupied_top_layer_MouseDown(object sender, MouseButtonEventArgs e)
        {
            checkOutForm checkOutForm = new checkOutForm(userNameBox.Text);
            checkOutForm.Show();
        }

        private void login_top_layer_MouseDown(object sender, MouseButtonEventArgs e)
        {
            login _login = new login();
            _login.Show();
            this.Close();
        }

        private void check_in_top_layer_MouseDown(object sender, MouseButtonEventArgs e)
        {
            checkInForm _checkInForm = new checkInForm(userNameBox.Text);
            _checkInForm.Show();
        }

        private void employee_top_layer_MouseDown(object sender, MouseButtonEventArgs e)
        {
            EmployeeList _employeeForm = new EmployeeList();
            _employeeForm.Show();
        }

        private void home_top_layer_MouseDown(object sender, MouseButtonEventArgs e)
        {
            login _login = new login();
            _login.Show();
            this.Close();
        }

        private void customer_top_MouseDown(object sender, MouseButtonEventArgs e)
        {
            customerForm customerForm = new customerForm();
            customerForm.Show();
        }
    }
}

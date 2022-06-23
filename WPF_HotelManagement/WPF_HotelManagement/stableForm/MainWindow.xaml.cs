using System.Windows;
using System.Windows.Input;

namespace WPF_HotelManagement
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

        private void booking_top_layer_MouseDown(object sender, MouseButtonEventArgs e)
        {
            bool isOpen = false;
            foreach (Window f in Application.Current.Windows)
            {
                if (f.Name == "customerForm")
                {
                    isOpen = true;
                    break;
                }
            }

            if (isOpen == false)
            {
                bookingForm _bookingForm = new bookingForm();
                _bookingForm.Show();
            }
        }

        private void occupied_top_layer_MouseDown(object sender, MouseButtonEventArgs e)
        {
            checkOutForm checkOutForm = new checkOutForm();
            checkOutForm.Show();
        }

        private void login_top_layer_MouseDown(object sender, MouseButtonEventArgs e)
        {
            login _login = new login();
            _login.Show();
        }

        private void check_in_top_layer_MouseDown(object sender, MouseButtonEventArgs e)
        {
            checkInForm _checkInForm = new checkInForm();
            _checkInForm.Show();
        }
    }
}

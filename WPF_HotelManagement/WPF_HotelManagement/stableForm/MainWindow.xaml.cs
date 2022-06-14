using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
                //continute _customerForm = new continute();
                //occupiedRoom _customerForm = new occupiedRoom();
                //occupiedRoom _customerForm = new occupiedRoom();
                _bookingForm.Show();
            }
        }

        private void occupied_top_layer_MouseDown(object sender, MouseButtonEventArgs e)
        {
            occupiedRoom occupiedRoom = new occupiedRoom();
            occupiedRoom.Show();
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

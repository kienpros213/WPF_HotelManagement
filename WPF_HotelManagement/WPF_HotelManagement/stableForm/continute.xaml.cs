using System.Windows;
using System.Windows.Input;

namespace WPF_HotelManagement
{
    /// <summary>
    /// Interaction logic for continute.xaml
    /// </summary>
    public partial class continute : Window
    {
        public continute()
        {
            InitializeComponent();
        }

        private void YES_TOP_MouseDown(object sender, MouseButtonEventArgs e)
        {
            bookingForm _bookingForm = new bookingForm(bookingForm.username); 
            _bookingForm.Show();
            this.Close();
        }

        private void NO_TOP_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
    }
}

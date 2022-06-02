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
using System.Windows.Shapes;

namespace WPF_HotelManagement
{
    /// <summary>
    /// Interaction logic for customerForm.xaml
    /// </summary>
    public partial class customerForm : Window
    {
        public customerForm()
        {
            InitializeComponent();
        }

        private void roomButton_KeyDown(object sender, KeyEventArgs e)
        {
            roomForm _roomForm = new roomForm();
            _roomForm.Show();
        }

        private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            roomForm _roomForm = new roomForm();
            _roomForm.Show();
        }
    }
}

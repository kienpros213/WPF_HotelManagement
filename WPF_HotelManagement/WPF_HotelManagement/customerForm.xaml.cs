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
        public static string customerText;
        public customerForm()
        {
            InitializeComponent();
        }
        private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            customerText = customerID.Text;
            if (string.IsNullOrWhiteSpace(customerID.Text))
            {
                MessageBox.Show("lmao, điền vào customerID");
            }
            else
            {
                updateCusData.Update(customerID.Text, foreName.Text, lastName.Text, customerAddress.Text, customerStatus.Text);
                this.Close();
                roomForm _roomForm = new roomForm();
                _roomForm.Show();
            }
        }

        private void Rectangle_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
    }
}

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
            customerForm _customerForm = new customerForm();
            _customerForm.Show();
            this.Close();
        }

        private void NO_TOP_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
    }
}

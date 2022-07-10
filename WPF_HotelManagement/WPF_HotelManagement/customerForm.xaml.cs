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
            getDataGridView.bindGrid(cusGrid, "EXEC customerView");
        }

        private void checked_out_top_MouseDown(object sender, MouseButtonEventArgs e)
        {
            getDataGridView.bindGrid(cusGrid, "EXEC getCheckOutData");
        }

        private void checked_in_top_MouseDown(object sender, MouseButtonEventArgs e)
        {
            getDataGridView.bindGrid(cusGrid, "EXEC getCheckInData");
        }

        private void all_top_MouseDown(object sender, MouseButtonEventArgs e)
        {
            getDataGridView.bindGrid(cusGrid, "EXEC customerView");
        }

        private void searchButtonTop_MouseDown(object sender, MouseButtonEventArgs e)
        {
            getDataGridView.bindGrid(cusGrid, "EXEC searchAllCustomer @cusName = '"+searchBar.Text+"'");
        }
    }
}

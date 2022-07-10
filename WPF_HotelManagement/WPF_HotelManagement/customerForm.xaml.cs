using System.Windows;
using System.Windows.Input;
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

        private void idSearch_MouseDown(object sender, MouseButtonEventArgs e)
        {
            getDataGridView.bindGrid(cusGrid, "EXEC searchById @id = '"+customerID.Text+"'");
        }
    }
}

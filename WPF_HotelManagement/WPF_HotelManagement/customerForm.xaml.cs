using System.Windows;
using System.Windows.Input;
using System.Windows.Controls;
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
            getDataGridView.bindGrid(cusGrid, "EXEC getCheckedOutData");
        }

        private void checked_in_top_MouseDown(object sender, MouseButtonEventArgs e)
        {
            getDataGridView.bindGrid(cusGrid, "EXEC getCheckOutData");
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
        public static string selectedItemText;
        public static string getStatus;

        private void cusGrid_SelectedCellsChanged(object sender, System.Windows.Controls.SelectedCellsChangedEventArgs e)
        {
            object selectedItem = cusGrid.SelectedItem;
            selectedItemText = (cusGrid.SelectedCells[0].Column.GetCellContent(selectedItem) as TextBlock).Text;
            getStatus = (cusGrid.SelectedCells[4].Column.GetCellContent(selectedItem) as TextBlock).Text;

            customerDetail reserveCheck = new customerDetail();
            reserveCheck.Show();
        }
    }
}

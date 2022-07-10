using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WPF_HotelManagement
{
    /// <summary>
    /// Interaction logic for checkOutForm.xaml
    /// </summary>
    public partial class checkOutForm : Window
    {
        public checkOutForm(string username)
        {
            InitializeComponent();
            getDataGridView.bindGrid(cusGrid, "EXEC getCheckOutData");
            userNameBox.Text = username;
        }
        public static string selectedItemText;

        private void cusGrid_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            object selectedItem = cusGrid.SelectedItem;
            selectedItemText = (cusGrid.SelectedCells[0].Column.GetCellContent(selectedItem) as TextBlock).Text;

            checkOut reserveCheck = new checkOut(userNameBox.Text);
            reserveCheck.Show();
        }

        private void searchButtonTop_MouseDown(object sender, MouseButtonEventArgs e)
        {
            getDataGridView.bindGrid(cusGrid, "EXEC searchCheckOut @cusName = '"+searchBar.Text+"'");
        }
    }
}

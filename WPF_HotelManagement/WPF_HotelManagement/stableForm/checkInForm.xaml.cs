using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WPF_HotelManagement
{
    /// <summary>
    /// Interaction logic for checkInForm.xaml
    /// </summary>
    public partial class checkInForm : Window
    {
        public checkInForm(string username)
        {
            InitializeComponent();
            getData();
            userNameBox.Text = username;
        }

        public void getData()
        {
            getDataGridView.bindGrid(cusGrid, "EXEC getCheckInData");
        }

        public static string selectedItemText;

        private void cusGrid_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            object selectedItem = cusGrid.SelectedItem;
            selectedItemText = (cusGrid.SelectedCells[0].Column.GetCellContent(selectedItem) as TextBlock).Text;
            reservationCheck reserveCheck = new reservationCheck(userNameBox.Text);
            reserveCheck.Show();
        }

        private void searchButtonTop_MouseDown(object sender, MouseButtonEventArgs e)
        {
            getDataGridView.bindGrid(cusGrid, "EXEC searchCustomer @cusName = '"+searchBar.Text+"'");
        }
    }
}

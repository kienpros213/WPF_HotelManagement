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
    /// Interaction logic for checkOutForm.xaml
    /// </summary>
    public partial class checkOutForm : Window
    {
        public checkOutForm()
        {
            InitializeComponent();
            getData();
        }

        public void getData()
        {
            getDataGridView.bindGrid(cusGrid, "select distinct tblCustomer.customerID, tblCustomer.customerFName, tblCustomer.customerLName, tblCustomer.customerAddress, tblCustomer.customerStatus, tblReservation.reservationID, tblReservation.reservationDate, tblReservation.dateIn, tblReservation.dateOut, tblReservation.roomID from tblCustomer, tblReservation where tblCustomer.customerID = tblReservation.customerID and tblCustomer.customerStatus = 'checked' ");
        }

        public static string selectedItemText;

        private void cusGrid_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            object selectedItem = cusGrid.SelectedItem;
            selectedItemText = (cusGrid.SelectedCells[0].Column.GetCellContent(selectedItem) as TextBlock).Text;

            checkOut reserveCheck = new checkOut();
            reserveCheck.Show();
        }
    }
}

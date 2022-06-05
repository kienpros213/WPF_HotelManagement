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
    /// Interaction logic for occupiedRoom.xaml
    /// </summary>
    public partial class occupiedRoom : Window
    {
        public occupiedRoom()
        {
            InitializeComponent();
            getDataGridView.bindGrid(roomGrid, "select * from tblReservation left join tblCustomer on tblReservation.customerID = tblCustomer.customerID");
        }

        private void all_room_top_MouseDown(object sender, MouseButtonEventArgs e)
        {
            getDataGridView.bindGrid(roomGrid, "SELECT * FROM tblRoom WHERE roomStatus = 'occupied'");
        }

        private void single_room_top_MouseDown(object sender, MouseButtonEventArgs e)
        {
            getDataGridView.bindGrid(roomGrid, "SELECT * FROM tblRoom WHERE (classID = 1 AND roomStatus = 'occupied')");
        }

        private void double_room_top_MouseDown(object sender, MouseButtonEventArgs e)
        {
            getDataGridView.bindGrid(roomGrid, "SELECT * FROM tblRoom WHERE (classID = 2 AND roomStatus = 'occupied')");
        }

        private void family_room_top_MouseDown(object sender, MouseButtonEventArgs e)
        {
            getDataGridView.bindGrid(roomGrid, "SELECT * FROM tblRoom WHERE (classID = 3 AND roomStatus = 'occupied')");
        }

        private void suite_room_top_MouseDown(object sender, MouseButtonEventArgs e)
        {
            getDataGridView.bindGrid(roomGrid, "SELECT * FROM tblRoom WHERE (classID = 4 AND roomStatus = 'occupied')");
        }

        private void update_button_MouseDown(object sender, MouseButtonEventArgs e)
        {
        }


        public static string selectedItemText;

        private void roomGrid_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            object selectedItem = roomGrid.SelectedItem;
            selectedItemText = (roomGrid.SelectedCells[6].Column.GetCellContent(selectedItem) as TextBlock).Text;
            MessageBox.Show(selectedItemText);

            reservationCheck reserveCheck = new reservationCheck();
            reserveCheck.Show();
        }

        

        private void Window_GotFocus(object sender, RoutedEventArgs e)
        {
            
        }
    }
}

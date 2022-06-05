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
    /// Interaction logic for roomForm.xaml
    /// </summary>
    public partial class roomForm : Window
    {
        public roomForm()
        {
            InitializeComponent();
            getDataGridView.bindGrid(roomGrid, "SELECT * FROM tblRoom WHERE roomStatus = 'unoccupied'");
            
        }

        private void all_room_top_MouseDown(object sender, MouseButtonEventArgs e)
        {
            getDataGridView.bindGrid(roomGrid, "SELECT * FROM tblRoom WHERE roomStatus = 'unoccupied'");
        }

        private void single_room_top_MouseDown(object sender, MouseButtonEventArgs e)
        {
            getDataGridView.bindGrid(roomGrid, "SELECT * FROM tblRoom WHERE (classID = 1 AND roomStatus = 'unoccupied')");
        }

        private void double_room_top_MouseDown(object sender, MouseButtonEventArgs e)
        {
            getDataGridView.bindGrid(roomGrid, "SELECT * FROM tblRoom WHERE (classID = 2 AND roomStatus = 'unoccupied')");
        }

        private void family_room_top_MouseDown(object sender, MouseButtonEventArgs e)
        {
            getDataGridView.bindGrid(roomGrid, "SELECT * FROM tblRoom WHERE (classID = 3 AND roomStatus = 'unoccupied')");
        }

        private void suite_room_top_MouseDown(object sender, MouseButtonEventArgs e)
        {
            getDataGridView.bindGrid(roomGrid, "SELECT * FROM tblRoom WHERE (classID = 4 AND roomStatus = 'unoccupied')");
        }

        private void update_button_MouseDown(object sender, MouseButtonEventArgs e)
        {
            string customerIDReserve = customerForm.customerText;
            updateReserveData.Update(reservation_id.Text, customerIDReserve, room_id.Text, reservation_date.Text, date_in.Text, date_out.Text);
            updateReserveData.takeRoom(room_id.Text);
            continute continuteWindow = new continute();
            continuteWindow.Show();
            this.Close();
        }

        private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
            customerForm _customerForm = new customerForm();
            _customerForm.Show();
        }
    }
}

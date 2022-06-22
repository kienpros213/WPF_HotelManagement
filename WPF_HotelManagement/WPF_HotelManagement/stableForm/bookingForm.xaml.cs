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
    /// Interaction logic for bookingForm.xaml
    /// </summary>
    public partial class bookingForm : Window
    {
        public bookingForm()
        {
            InitializeComponent();
            //getDataGridView.bindGrid(roomGrid, "EXEC searchRoom @dateIn = '" + date_in.Text + "', @dateOut = '" + date_out.Text + "'");
            reservation_date.Text = DateTime.Now.ToString();
        }

        private void single_room_layer_MouseDown(object sender, MouseButtonEventArgs e)
        {
            getDataGridView.bindGrid(roomGrid, "SELECT * FROM tblRoom WHERE (classID = 1 AND roomStatus = 'unoccupied')");
        }

        private void double_room_layer_MouseDown(object sender, MouseButtonEventArgs e)
        {
            getDataGridView.bindGrid(roomGrid, "SELECT * FROM tblRoom WHERE (classID = 2 AND roomStatus = 'unoccupied')");
        }

        private void family_room_layer_MouseDown(object sender, MouseButtonEventArgs e)
        {
            getDataGridView.bindGrid(roomGrid, "SELECT * FROM tblRoom WHERE (classID = 3 AND roomStatus = 'unoccupied')");
        }

        private void suite_room_layer_MouseDown(object sender, MouseButtonEventArgs e)
        {
            getDataGridView.bindGrid(roomGrid, "SELECT * FROM tblRoom WHERE (classID = 4 AND roomStatus = 'unoccupied')");
        }

        private void comfirm_layer_MouseDown(object sender, MouseButtonEventArgs e)
        {
            updateReserveData.Update(foreName.Text, lastName.Text, customerAddress.Text, customerStatus.Text, room_id.Text, reservation_date.Text, date_in.Text, date_out.Text);
            continute continuteWindow = new continute();
            continuteWindow.Show();
            this.Close();
        }
        public void coulumnWidth()
        {
            string count = roomGrid.Columns.Count().ToString();
            MessageBox.Show(count);       
        }

        private void search_layer_MouseDown(object sender, MouseButtonEventArgs e)
        {
            getDataGridView.bindGrid(roomGrid, "EXEC searchRoom @dateIn = '" + date_in.Text + "', @dateOut = '" + date_out.Text + "' ");
        }

        private void choose_room_top_layer_MouseDown(object sender, MouseButtonEventArgs e)
        {
            getDataGridView.bindGrid(roomGrid, "EXEC searchRoom @dateIn = '" + date_in.Text + "', @dateOut = '" + date_out.Text + "' ");
        }

    }
}

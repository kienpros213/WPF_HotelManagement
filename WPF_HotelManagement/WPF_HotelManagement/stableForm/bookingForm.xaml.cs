using System;
using System.Windows;
using System.Windows.Input;

namespace WPF_HotelManagement
{
    /// <summary>
    /// Interaction logic for bookingForm.xaml
    /// </summary>
    public partial class bookingForm : Window
    {
        public bookingForm(string username)
        {
            InitializeComponent();
            reservation_date.Text = DateTime.Now.ToString();
            userNameBox.Text = username;
        }

        public static string username;

        private void single_room_layer_MouseDown(object sender, MouseButtonEventArgs e)
        {
            getData("1");
        }

        private void double_room_layer_MouseDown(object sender, MouseButtonEventArgs e)
        {
            getData("2");
        }

        private void family_room_layer_MouseDown(object sender, MouseButtonEventArgs e)
        {
            getData("3");
        }

        private void suite_room_layer_MouseDown(object sender, MouseButtonEventArgs e)
        {
            getData("4");
        }

        private void comfirm_layer_MouseDown(object sender, MouseButtonEventArgs e)
        {
            updateReserveData.Update(foreName.Text, lastName.Text, customerAddress.Text, customerStatus.Text, room_id.Text, reservation_date.Text, date_in.Text, date_out.Text, userNameBox.Text);
            continute continuteWindow = new continute();
            continuteWindow.Show();
            username = userNameBox.Text;
            this.Close();
        }
        private void search_layer_MouseDown(object sender, MouseButtonEventArgs e)
        {
            getDataGridView.bindGrid(roomGrid, "EXEC searchRoom @dateIn = '" + date_in.Text + "' ");
        }

        private void choose_room_top_layer_MouseDown(object sender, MouseButtonEventArgs e)
        {
            getDataGridView.bindGrid(roomGrid, "EXEC searchRoom @dateIn = '" + date_in.Text + "' ");
        }

        private void getData(string classID)
        {
            getDataGridView.bindGrid(roomGrid, "SELECT * FROM tblRoom WHERE (classID = "+classID+" AND roomStatus = 'unoccupied')");
        }
    }
}

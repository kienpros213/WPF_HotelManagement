using System.Windows;
using System.Windows.Input;
using System;

namespace WPF_HotelManagement
{
    /// <summary>
    /// Interaction logic for reservationCheck.xaml
    /// </summary>
    public partial class checkOut : Window
    {
        public checkOut(string username)
        {
            InitializeComponent();
            getReservationData.getData(_cusID, customerId, reservationId, roomId, reservationDate, dateIn, dateOut, foreName, lastName, customerAddress, customerStatus);
            getReservationData.getServiceData(_cusID, breakfast, cleaning, carRenting, massage);
            getClassAndPrice();
            userNameBox.Text = username;
        }
        string _cusID = checkOutForm.selectedItemText;

        private void check_out_top_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //check-out button
            string _roomID = roomId.Text;
            updateReserveData.returnRoom(_roomID, _cusID);
            updateTransaction.Update(_cusID, 1, total, payMethod1.Text, DateTime.Now.ToString(), userNameBox.Text);
            MessageBox.Show("check-out success");
            this.Close();
        }
        private void getClassAndPrice()
        {
            string _roomID = roomId.Text;
            string cusID = customerId.Text;
            count.total(_roomID, cusID, roomClass, price, daysRange, breakfast, carRenting, cleaning, massage, discount, total);
        }

        private void discount_LostFocus(object sender, RoutedEventArgs e)
        {
            string _roomID = roomId.Text;
            string cusID = customerId.Text;
            count.total(_roomID, cusID, roomClass, price, daysRange, breakfast, carRenting, cleaning, massage, discount, total);
        }

        private void discount_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }
    }
}

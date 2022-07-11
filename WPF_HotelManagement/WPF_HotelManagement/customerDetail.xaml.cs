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
    /// Interaction logic for customerDetail.xaml
    /// </summary>
    public partial class customerDetail : Window
    {
        public customerDetail()
        {
            InitializeComponent();
            getReservationData.getData(_cusID, customerId, reservationId, roomId, reservationDate, dateIn, dateOut, foreName, lastName, customerAddress, customerStatus);
            getReservationData.getServiceData(_cusID, breakfast, cleaning, carRenting, massage);
            getClassAndPrice();
        }
        string _cusID = customerForm.selectedItemText;

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

        private void check_out_top_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            string cusID = customerId.Text;
            checkServiceInput.updateCheck(cusID, breakfast, cleaning, carRenting, massage);
        }

        private void breakfast_LostFocus(object sender, RoutedEventArgs e)
        {
            string _roomID = roomId.Text;
            string cusID = customerId.Text;
            count.total(_roomID, cusID, roomClass, price, daysRange, breakfast, carRenting, cleaning, massage, discount, total);
        }

        private void cleaning_LostFocus(object sender, RoutedEventArgs e)
        {
            string _roomID = roomId.Text;
            string cusID = customerId.Text;
            count.total(_roomID, cusID, roomClass, price, daysRange, breakfast, carRenting, cleaning, massage, discount, total);
        }

        private void carRenting_LostFocus(object sender, RoutedEventArgs e)
        {
            string _roomID = roomId.Text;
            string cusID = customerId.Text;
            count.total(_roomID, cusID, roomClass, price, daysRange, breakfast, carRenting, cleaning, massage, discount, total);
        }

        private void massage_LostFocus(object sender, RoutedEventArgs e)
        {
            string _roomID = roomId.Text;
            string cusID = customerId.Text;
            count.total(_roomID, cusID, roomClass, price, daysRange, breakfast, carRenting, cleaning, massage, discount, total);
        }
    }
}

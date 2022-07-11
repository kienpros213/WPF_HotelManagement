using System;
using System.Windows;
using System.Windows.Input;

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
            countTotal();
            if(_cusStatus == "checked-out")
            {
                reservationId.IsReadOnly = true;
                roomId.IsReadOnly = true;
                reservationDate.IsReadOnly = true;
                dateIn.IsReadOnly = true;
                dateOut.IsReadOnly = true;
                daysRange.IsReadOnly = true;
                customerId.IsReadOnly = true;
                foreName.IsReadOnly = true;
                lastName.IsReadOnly = true;
                customerAddress.IsReadOnly = true;
                customerStatus.IsReadOnly = true;
                breakfast.IsReadOnly = true;
                cleaning.IsReadOnly = true;
                carRenting.IsReadOnly = true;
                massage.IsReadOnly = true;
            }
        }
        string _cusID = customerForm.selectedItemText;
        string _cusStatus = customerForm.getStatus;
        private void check_out_top_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //check-out button
            string _roomID = roomId.Text;
            updateReserveData.returnRoom(_roomID, _cusID);
            updateTransaction.Update(_cusID, 1, total, payMethod1.Text, DateTime.Now.ToString(), userNameBox.Text);
            MessageBox.Show("check-out success");
            this.Close();
        }

        private void discount_LostFocus(object sender, RoutedEventArgs e)
        {
            countTotal();
        }

        private void check_out_top_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            string cusID = customerId.Text;
            checkServiceInput.updateCheck(cusID, breakfast, cleaning, carRenting, massage);
        }

        private void breakfast_LostFocus(object sender, RoutedEventArgs e)
        {
            countTotal();
        }

        private void cleaning_LostFocus(object sender, RoutedEventArgs e)
        {
            countTotal();
        }

        private void carRenting_LostFocus(object sender, RoutedEventArgs e)
        {
            countTotal();
        }

        private void massage_LostFocus(object sender, RoutedEventArgs e)
        {
            countTotal();
        }
        private void countTotal()
        {
            string _roomID = roomId.Text;
            string cusID = customerId.Text;
            count.total(_roomID, cusID, roomClass, price, daysRange, breakfast, carRenting, cleaning, massage, discount, total);
        }
    }
}

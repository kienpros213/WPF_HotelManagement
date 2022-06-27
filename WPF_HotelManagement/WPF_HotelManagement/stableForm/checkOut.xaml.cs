using System.Windows;
using System.Windows.Input;

namespace WPF_HotelManagement
{
    /// <summary>
    /// Interaction logic for reservationCheck.xaml
    /// </summary>
    public partial class checkOut : Window
    {
        public checkOut()
        {
            InitializeComponent();
            getReservationData.getData(_cusID, customerId, reservationId, roomId, reservationDate, dateIn, dateOut, foreName, lastName, customerAddress, customerStatus);
            getReservationData.getServiceData(_cusID, breakfast, cleaning, carRenting, massage);
            getClassAndPrice();
        }
        string _cusID = checkOutForm.selectedItemText;

        private void check_out_top_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //check-out button
            string _roomID = roomId.Text;
            updateReserveData.returnRoom(_roomID, _cusID);
            updateTransaction.Update(_cusID, 1, total, "visa", "02/02/2022");
            MessageBox.Show("check-out success");
            this.Close();
        }
        private void getClassAndPrice()
        {
            string _roomID = roomId.Text;
            string cusID = customerId.Text;
            count.total(_roomID, cusID, roomClass, price, daysRange, breakfast, carRenting, cleaning, massage, total);
        }
    }
}

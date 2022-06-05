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
    /// Interaction logic for reservationCheck.xaml
    /// </summary>
    public partial class reservationCheck : Window
    {
        public reservationCheck()
        {
            InitializeComponent();
            getReserveDate();
        }
        string idPar = occupiedRoom.selectedItemText;

        private void getReserveDate()
        {
            getReservationData.getData(idPar, customerId, reservationId, roomId, reservationDate, dateIn, dateOut, foreName, lastName, customerAddress, customerStatus);
        }

        private void check_out_top_MouseDown(object sender, MouseButtonEventArgs e)
        {
            string _roomID = roomId.Text;
            string cusID = customerId.Text;
            MessageBox.Show("customer id check out: "+cusID+"");
            updateHistory.Update(cusID);
            deleteCustomerReservation.delete(cusID);
            updateReserveData.returnRoom(_roomID);
        }

        private void check_out_Copy1_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}

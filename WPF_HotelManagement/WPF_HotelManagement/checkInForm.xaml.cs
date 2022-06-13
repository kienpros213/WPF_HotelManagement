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
    /// Interaction logic for checkInForm.xaml
    /// </summary>
    public partial class checkInForm : Window
    {
        public checkInForm()
        {
            InitializeComponent();
            getData();
        }

        public void getData()
        {
            getDataGridView.bindGrid(dataGrid, "SELECT dbo.tblReservation.customerID, dbo.tblReservation.reservationID, dbo.tblReservation.reservationDate, dbo.tblReservation.roomID, dbo.tblReservation.dateIn, dbo.tblReservation.dateOut, dbo.tblCustomer.customerFName, dbo.tblCustomer.customerLName, dbo.tblCustomer.customerAddress, dbo.tblCustomer.customerStatus FROM dbo.tblReservation CROSS JOIN dbo.tblCustomer");
        }
    }
}

using System.Windows;
using System.Data.SqlClient;


namespace WPF_HotelManagement
{
    class updateReserveData
    {
        public static void Update(string fName, string lName, string address, string status, string roomID, string reserveDate, string dateIn, string dateOut)
        {
            string sqlstring = "exec updateCustomerReservation @fName = '"+fName+ "', @lName = '" + lName + "', @address = '" + address + "', @status = '" + status + "', @roomID = '" + roomID + "', @reservationDate = '" + reserveDate + "', @dateIn = '" + dateIn + "', @dateOut = '" + dateOut + "'";
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IQ966PV;Initial Catalog=HotelDatabase;Integrated Security=True");
            con.Open();
            SqlCommand command = new SqlCommand(sqlstring, con);
            command.ExecuteNonQuery();
            MessageBox.Show("Reservation Data Updated");
            con.Close();
        }

        public static void takeRoom(string _roomID, string _cusID)
        {
            string sqlstring = "UPDATE tblRoom SET roomStatus = 'occupied' WHERE roomID = '" + _roomID + "' UPDATE tblCustomer SET customerStatus = 'checked' WHERE customerID = '" + _cusID + "' ";
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IQ966PV;Initial Catalog=HotelDatabase;Integrated Security=True");
            con.Open();
            SqlCommand command = new SqlCommand(sqlstring, con);
            command.ExecuteNonQuery();
            con.Close();
        }
        public static void returnRoom (string _roomID, string _cusID)
        {
            string sqlstring = "UPDATE tblRoom SET roomStatus = 'unoccupied' WHERE roomID = '" + _roomID + "' UPDATE tblCustomer SET customerStatus = 'checked-out' WHERE customerID = '" + _cusID + "' ";
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IQ966PV;Initial Catalog=HotelDatabase;Integrated Security=True");
            con.Open();
            SqlCommand command = new SqlCommand(sqlstring, con);
            command.ExecuteNonQuery();
            con.Close();
        }
    }
}

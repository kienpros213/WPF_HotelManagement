using System.Windows;
using System.Data.SqlClient;


namespace WPF_HotelManagement
{
    class updateReserveData
    {
        public static void Update(string _reservationID, string _customerID, string _roomID, string _reservationDate, string _dateIn, string _dateOut)
        {
            string sqlstring = "INSERT INTO tblReservation VALUES('" + _reservationID + "','" + _customerID + "','" + _roomID + "','" + _reservationDate + "','" + _dateIn + "','" + _dateOut + "')";
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IQ966PV;Initial Catalog=HotelDatabase;Integrated Security=True");
            con.Open();
            SqlCommand command = new SqlCommand(sqlstring, con);
            command.ExecuteNonQuery();
            MessageBox.Show("Reservation Data Updated");
            con.Close();
        }

        public static void takeRoom(string _roomID)
        {
            string sqlstring = "UPDATE tblRoom SET roomStatus = 'occupied' WHERE roomID = '" + _roomID + "'";
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IQ966PV;Initial Catalog=HotelDatabase;Integrated Security=True");
            con.Open();
            SqlCommand command = new SqlCommand(sqlstring, con);
            command.ExecuteNonQuery();
            con.Close();
        }
        public static void returnRoom (string _roomID)
        {
            string sqlstring = "UPDATE tblRoom SET roomStatus = 'unoccupied' WHERE roomID = '" + _roomID + "'";
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IQ966PV;Initial Catalog=HotelDatabase;Integrated Security=True");
            con.Open();
            SqlCommand command = new SqlCommand(sqlstring, con);
            command.ExecuteNonQuery();
            con.Close();
        }
    }
}

using System.Windows;
using System.Data.SqlClient;


namespace WPF_HotelManagement
{
    class updateReserveData
    {
        public static void Update(string fName, string lName, string address, string status, string roomID, string reserveDate, string dateIn, string dateOut)
        {
            string sqlstring = "EXEC updateCustomerReservation @fName = '"+fName+ "', @lName = '" + lName + "', @address = '" + address + "', @status = '" + status + "', @roomID = '" + roomID + "', @reservationDate = '" + reserveDate + "', @dateIn = '" + dateIn + "', @dateOut = '" + dateOut + "'";
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IQ966PV;Initial Catalog=HotelDatabase;Integrated Security=True");
            con.Open();
            SqlCommand command = new SqlCommand(sqlstring, con);
            command.ExecuteNonQuery();
            MessageBox.Show("Reservation Data Updated");
            con.Close();
        }

        public static void takeRoom(string _roomID, string _cusID)
        {
            string sqlstring = "EXEC takeRoom @roomID = " + _roomID + ", @cusID = " + _cusID + " ";
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IQ966PV;Initial Catalog=HotelDatabase;Integrated Security=True");
            con.Open();
            SqlCommand command = new SqlCommand(sqlstring, con);
            command.ExecuteNonQuery();
            con.Close();
        }
        public static void returnRoom (string _roomID, string _cusID)
        {
            string sqlstring = "EXEC returnRoom @roomID = " + _roomID + ", @cusID = " + _cusID + " ";
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IQ966PV;Initial Catalog=HotelDatabase;Integrated Security=True");
            con.Open();
            SqlCommand command = new SqlCommand(sqlstring, con);
            command.ExecuteNonQuery();
            con.Close();
        }
        
        public static void updateService(string cusID, string serviceID, string amount)
        {
            string sqlstring = "INSERT INTO tblOrder VALUES ("+cusID+ ", " + serviceID + ", " + amount + ")";
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IQ966PV;Initial Catalog=HotelDatabase;Integrated Security=True");
            con.Open();
            SqlCommand command = new SqlCommand(sqlstring, con);
            command.ExecuteNonQuery();
            con.Close();
        }
    }
}

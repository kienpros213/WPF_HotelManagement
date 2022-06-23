using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WPF_HotelManagement
{
    class payment
    {

        public static void getClassAndPrice(string _roomID, System.Windows.Controls.TextBox _classID, System.Windows.Controls.TextBox _price, string _cusID, System.Windows.Controls.TextBox _dayRange)
        {
            string sqlstring = "EXEC getClassAndPrice @roomID = "+_roomID+", @cusID = "+_cusID+" ";
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IQ966PV;Initial Catalog=HotelDatabase;Integrated Security=True");
            SqlCommand command = new SqlCommand(sqlstring, con);
            con.Open();
            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                _classID.Text = dataReader.GetValue(0).ToString();
                _price.Text = dataReader.GetValue(1).ToString();
            }
            con.Close();
        }

        public static void getDaysRange(string _cusID, System.Windows.Controls.TextBox _dayRange)
        {
            string sqlstring = "EXEC getDaysRange @cusID = "+_cusID+" ";
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IQ966PV;Initial Catalog=HotelDatabase;Integrated Security=True");
            SqlCommand command = new SqlCommand(sqlstring, con);
            con.Open();
            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                _dayRange.Text = dataReader.GetValue(0).ToString();
            }
            con.Close();
        }
    }
}

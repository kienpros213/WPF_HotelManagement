using System.Data;
using System.Data.SqlClient;
namespace WPF_HotelManagement
{
    class getReservationData
    {
        public static void getData(string _cusIDPar, System.Windows.Controls.TextBox _cusID, System.Windows.Controls.TextBox _reservationID, System.Windows.Controls.TextBox _roomID, System.Windows.Controls.TextBox _reserveDate, System.Windows.Controls.TextBox _dateIn, System.Windows.Controls.TextBox _dateOut, System.Windows.Controls.TextBox _cusFName, System.Windows.Controls.TextBox _cusLName, System.Windows.Controls.TextBox _cusAddress, System.Windows.Controls.TextBox _cusStatus)
        {
            string sqlstring = "EXEC viewProc @par = '" + _cusIDPar+"' ";
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-VNMEN35T;Initial Catalog=HotelDatabase;Integrated Security=True");
            SqlCommand command = new SqlCommand(sqlstring, con);
            con.Open();
            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                _cusID.Text = dataReader.GetValue(0).ToString();
                _reservationID.Text = dataReader.GetValue(1).ToString();
                _reserveDate.Text = dataReader.GetValue(2).ToString();
                _roomID.Text = dataReader.GetValue(3).ToString();
                _dateIn.Text = dataReader.GetValue(4).ToString();
                _dateOut.Text = dataReader.GetValue(5).ToString();
                _cusFName.Text = dataReader.GetValue(6).ToString();
                _cusLName.Text = dataReader.GetValue(7).ToString();
                _cusAddress.Text = dataReader.GetValue(8).ToString();
                _cusStatus.Text = dataReader.GetValue(9).ToString();
            }
            con.Close();
        }
        public static void getServiceData(string cusID, System.Windows.Controls.TextBox breakfast, System.Windows.Controls.TextBox cleaning, System.Windows.Controls.TextBox carRenting, System.Windows.Controls.TextBox massage)
        {
            string sqlstring = "EXEC getServices @cusID = "+cusID+"";
            string constring = "Data Source=LAPTOP-VNMEN35T;Initial Catalog=HotelDatabase;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constring))
            {
                SqlCommand command = new SqlCommand(sqlstring, con);
                SqlDataAdapter sda = new SqlDataAdapter(command);
                DataTable dt = new DataTable("view");
                sda.Fill(dt);
                int rowCount = dt.Rows.Count;
                if (rowCount == 1)
                {
                    breakfast.Text = dt.Rows[0]["amount"].ToString();
                }
                if (rowCount == 2)
                {
                    breakfast.Text = dt.Rows[0]["amount"].ToString();
                    cleaning.Text = dt.Rows[1]["amount"].ToString();
                }
                if (rowCount == 3)
                {
                    breakfast.Text = dt.Rows[0]["amount"].ToString();
                    cleaning.Text = dt.Rows[1]["amount"].ToString();
                    carRenting.Text = dt.Rows[2]["amount"].ToString();
                }
                if (rowCount == 4)
                {
                    breakfast.Text = dt.Rows[0]["amount"].ToString();
                    cleaning.Text = dt.Rows[1]["amount"].ToString();
                    carRenting.Text = dt.Rows[2]["amount"].ToString();
                    massage.Text = dt.Rows[3]["amount"].ToString();
                }
            }
        }
    }
}

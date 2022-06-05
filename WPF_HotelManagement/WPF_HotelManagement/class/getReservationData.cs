using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace WPF_HotelManagement
{
    class getReservationData
    {
        public static void getData(string _cusIDPar, System.Windows.Controls.TextBox _cusID, System.Windows.Controls.TextBox _reservationID, System.Windows.Controls.TextBox _roomID, System.Windows.Controls.TextBox _reserveDate, System.Windows.Controls.TextBox _dateIn, System.Windows.Controls.TextBox _dateOut, System.Windows.Controls.TextBox _cusFName, System.Windows.Controls.TextBox _cusLName, System.Windows.Controls.TextBox _cusAddress, System.Windows.Controls.TextBox _cusStatus)
        {
            string sqlstring = "exec viewProc @par = '" + _cusIDPar+"' ";
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IQ966PV;Initial Catalog=HotelDatabase;Integrated Security=True");
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
    }
}

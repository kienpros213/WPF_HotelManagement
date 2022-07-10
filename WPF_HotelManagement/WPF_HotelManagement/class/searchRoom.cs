using System.Windows;
using System.Data.SqlClient;

namespace WPF_HotelManagement
{
    class searchRoom
    {
        public void Search(string dateIn, string dateOut)
        {
            string sqlstring = "EXEC searchRoom @dateIn = '"+dateIn+"', @dateOut = '"+dateOut+"'";
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-VNMEN35T;Initial Catalog=HotelDatabase;Integrated Security=True");
            con.Open();
            SqlCommand command = new SqlCommand(sqlstring, con);
            command.ExecuteNonQuery();
            MessageBox.Show("Reservation Data Updated");
            con.Close();
        }
    }
}

using System.Windows;
using System.Data.SqlClient;

namespace WPF_HotelManagement
{
    class searchRoom
    {
        //sql string thay vào đây
        static string sql = "Data Source=LAPTOP-VNMEN35T;Initial Catalog=HotelDatabase;Integrated Security=True";
        public void Search(string dateIn, string dateOut)
        {
            string sqlstring = "EXEC searchRoom @dateIn = '"+dateIn+"', @dateOut = '"+dateOut+"'";
            SqlConnection con = new SqlConnection(sql);
            con.Open();
            SqlCommand command = new SqlCommand(sqlstring, con);
            command.ExecuteNonQuery();
            MessageBox.Show("Reservation Data Updated");
            con.Close();
        }
    }
}

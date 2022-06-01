using System.Windows;
using System.Data.SqlClient;

namespace WPF_HotelManagement
{
    class updateHistory
    {
        public static void Update(string cusID)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IQ966PV;Initial Catalog=HotelDatabase;Integrated Security=True");
            con.Open();
            SqlCommand command = new SqlCommand("historyProc", con);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@cusID", System.Data.SqlDbType.VarChar).Value = cusID;
            command.ExecuteNonQuery();
            MessageBox.Show("History Data Updated");
            con.Close();
        }
    }
}

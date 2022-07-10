using System.Data;
using System.Windows;
using System.Data.SqlClient;


namespace WPF_HotelManagement
{
    class getDataGridView
    {
        public static void bindGrid(System.Windows.Controls.DataGrid _dataGridViewObj, string tbl)
        {
            string constring = "Data Source=LAPTOP-VNMEN35T;Initial Catalog=HotelDatabase;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constring))
            {
                SqlCommand command = new SqlCommand(tbl, con);
                SqlDataAdapter sda = new SqlDataAdapter(command);
                DataTable dt = new DataTable("view");
                sda.Fill(dt);
                _dataGridViewObj.ItemsSource = dt.DefaultView;
            }
        }
    }
}

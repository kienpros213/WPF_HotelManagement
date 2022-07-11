using System.Data.SqlClient;
using System.Windows;

namespace WPF_HotelManagement
{
    class checkServiceInput
    {
        public static void Check(string cusID, System.Windows.Controls.TextBox breakfast, System.Windows.Controls.TextBox cleaing, System.Windows.Controls.TextBox carRenting, System.Windows.Controls.TextBox massage)
        {
            if(breakfast.Text != "0")
            {
                updateReserveData.Service(cusID, "1", breakfast.Text);
            }
            if (cleaing.Text != "0")
            {
                updateReserveData.Service(cusID, "2", cleaing.Text);
            }
            if (carRenting.Text != "0")
            {
                updateReserveData.Service(cusID, "3", carRenting.Text);
            }
            if (massage.Text != "0")
            {
                updateReserveData.Service(cusID, "4", massage.Text);
            }
        }

        public static void updateCheck(string cusID, System.Windows.Controls.TextBox breakfast, System.Windows.Controls.TextBox cleaning, System.Windows.Controls.TextBox carRenting, System.Windows.Controls.TextBox massage)
        {
            if (breakfast.Text != "0")
            {
                Query(cusID, "1", breakfast.Text);
            }
            if (cleaning.Text != "0")
            {
                Query(cusID, "2", cleaning.Text);
            }
            if (carRenting.Text != "0")
            {
                Query(cusID, "3", carRenting.Text);
            }
            if (massage.Text != "0")
            {
                Query(cusID, "4", massage.Text);
            }

            MessageBox.Show("updated");
        }

        public static void Query(string cusID, string serviceID, string amount)
        {
            string sqlstring = "EXEC updateServices @cusID = "+cusID+", @serviceID = "+serviceID+", @amount ="+amount+"";
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-VNMEN35T;Initial Catalog=HotelDatabase;Integrated Security=True");
            con.Open();
            SqlCommand command = new SqlCommand(sqlstring, con);
            command.ExecuteNonQuery();
            con.Close();
        }
    }
}

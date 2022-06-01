using System.Windows;
using System.Data.SqlClient;

namespace WPF_HotelManagement
{
    class updateCusData
    {
        public static void Update(string _customerID, string _customerFName, string _customerLName, string _customerAddress, string _customerStatus)
        {
            string sqlstring = "INSERT INTO tblCustomer VALUES('" + _customerID + "','" + _customerFName + "','" + _customerLName + "','" + _customerAddress + "','" + _customerStatus + "')";
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IQ966PV;Initial Catalog=HotelDatabase;Integrated Security=True");
            con.Open();
            SqlCommand command = new SqlCommand(sqlstring, con);
            command.ExecuteNonQuery();
            MessageBox.Show("Customer Data Updated");
            con.Close();
        }
    }
}

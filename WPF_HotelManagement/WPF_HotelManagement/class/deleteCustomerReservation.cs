using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows;

namespace WPF_HotelManagement
{
    class deleteCustomerReservation
    {
        public static void delete(string cusID)
        {
            string sqlstring = "delete from tblReservation where customerID = '" + cusID + "' delete from tblCustomer where customerID = '" + cusID + "'  ";
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IQ966PV;Initial Catalog=HotelDatabase;Integrated Security=True");
            con.Open();
            SqlCommand command = new SqlCommand(sqlstring, con);
            command.ExecuteNonQuery();
            MessageBox.Show("Customer Data Updated");
            con.Close();
        }
    }
}

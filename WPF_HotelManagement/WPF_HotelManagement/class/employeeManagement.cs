using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows;

namespace WPF_HotelManagement
{
    class employeeManagement
    {
        public static void Add(string fName, string lName, string job, string address, string username, string password)
        {
            string sqlstring = "EXEC addEmployee @fName = '" + fName + "', @lName = '" + lName + "', @job = '" + job + "', @address = '" + address + "', @username = '" + username + "', @password = '" + password + "'   ";
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IQ966PV;Initial Catalog=HotelDatabase;Integrated Security=True");
            con.Open();
            SqlCommand command = new SqlCommand(sqlstring, con);
            command.ExecuteNonQuery();
            MessageBox.Show("Employee Updated");
            con.Close();
        }

        public static void DelShow(string employeeID, System.Windows.Controls.TextBox foreName, System.Windows.Controls.TextBox lastName, System.Windows.Controls.TextBox job, System.Windows.Controls.TextBox address, System.Windows.Controls.TextBox username, System.Windows.Controls.TextBox password)
        {
            string sqlstring = "SELECT * FROM tblEmployees WHERE EmployeeID = '"+employeeID+"' ";
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IQ966PV;Initial Catalog=HotelDatabase;Integrated Security=True");
            SqlCommand command = new SqlCommand(sqlstring, con);
            con.Open();
            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                foreName.Text = dataReader.GetValue(0).ToString();
                lastName.Text = dataReader.GetValue(1).ToString();
                job.Text = dataReader.GetValue(2).ToString();
                address.Text = dataReader.GetValue(3).ToString();
                username.Text = dataReader.GetValue(4).ToString();
                password.Text = dataReader.GetValue(5).ToString();
            }
            con.Close();
        }

        public static void Delete(string employeeID)
        {
            string sqlstring = "DELETE FROM tblEmployees WHERE employeeID = "+employeeID+"";
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IQ966PV;Initial Catalog=HotelDatabase;Integrated Security=True");
            con.Open();
            SqlCommand command = new SqlCommand(sqlstring, con);
            command.ExecuteNonQuery();
            MessageBox.Show("Employee Updated");
            con.Close();
        }

    }
}

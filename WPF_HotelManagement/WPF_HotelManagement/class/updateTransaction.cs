﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WPF_HotelManagement
{
    class updateTransaction
    {
        public static void Update(string customerID, int employeeID, System.Windows.Controls.TextBox amount, string paymentType, string dateOut)
        {
            string sqlstring = "EXEC checkOutTransaction @cusID = "+int.Parse(customerID)+", @employeeID = "+employeeID+", @amount = "+amount+", @transactionDate = '"+dateOut+"', @paymentType = '"+paymentType+"'";
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IQ966PV;Initial Catalog=HotelDatabase;Integrated Security=True");
            con.Open();
            SqlCommand command = new SqlCommand(sqlstring, con);
            command.ExecuteNonQuery();
            con.Close();
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WPF_HotelManagement
{
    class paymentMethod
    {

        public static void getClass(string _roomID, System.Windows.Controls.TextBox _classID, System.Windows.Controls.TextBox _price, string _cusID, System.Windows.Controls.TextBox _dayRange)
        {
            string sqlstring = "select classID, price from tblRoom where roomID = '"+_roomID+ "' select datediff(DAY, dateOut, dateIn) as daysrange from tblReservation where customerID = '"+_cusID+"'";
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IQ966PV;Initial Catalog=HotelDatabase;Integrated Security=True");
            SqlCommand command = new SqlCommand(sqlstring, con);
            con.Open();
            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                _classID.Text = dataReader.GetValue(0).ToString();
                _price.Text = dataReader.GetValue(1).ToString();
            }
            con.Close();
        }

        public static void getDaysRange(string _cusID, System.Windows.Controls.TextBox _dayRange)
        {
            string sqlstring = "select datediff(DAY, dateIn, dateOut) as daysrange from tblReservation where customerID = '" + _cusID + "'";
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IQ966PV;Initial Catalog=HotelDatabase;Integrated Security=True");
            SqlCommand command = new SqlCommand(sqlstring, con);
            con.Open();
            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                _dayRange.Text = dataReader.GetValue(0).ToString();
            }
            con.Close();
        }
    }
}
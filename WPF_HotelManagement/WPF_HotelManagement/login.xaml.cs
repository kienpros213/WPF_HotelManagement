﻿
using System.Windows.Input;
using System.Data;
using System.Windows;
using System.Data.SqlClient;


namespace WPF_HotelManagement
{
    /// <summary>
    /// Interaction logic for login.xaml
    /// </summary>
    public partial class login : Window
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_layer_top_MouseDown(object sender, MouseButtonEventArgs e)
        {
            string sqlstring = "SELECT * FROM tblEmployees WHERE userName = '"+userNameBox+"' AND userPassword = '"+passwordBox+"'";
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IQ966PV;Initial Catalog=HotelDatabase;Integrated Security=True");
            SqlDataAdapter sa = new SqlDataAdapter(sqlstring, con);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            if(dt.Rows.Count == 1)
            {
                MessageBox.Show("welcum");
            }
            else
            {
                MessageBox.Show("fuck off");
            }
        }
    }
}
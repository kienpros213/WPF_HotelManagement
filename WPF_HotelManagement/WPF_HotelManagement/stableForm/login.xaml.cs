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
            string sqlstring = "SELECT * FROM tblEmployees WHERE userName = '"+userNameBox.Text+"' AND userPassword = '"+passwordBox.Text+"'";
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IQ966PV;Initial Catalog=HotelDatabase;Integrated Security=True");
            SqlDataAdapter sa = new SqlDataAdapter(sqlstring, con);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            if(dt.Rows.Count == 1)
            {
                MessageBox.Show("welcome "+userNameBox.Text+"");
                MainWindow main = new MainWindow(userNameBox.Text);
                main.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("sai thông tin đăng nhập, mời nhập lại");
            }
        }
    }
}

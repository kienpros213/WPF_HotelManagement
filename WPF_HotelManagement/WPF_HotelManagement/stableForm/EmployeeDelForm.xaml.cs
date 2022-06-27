using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF_HotelManagement
{
    /// <summary>
    /// Interaction logic for EmployeeDelForm.xaml
    /// </summary>
    public partial class EmployeeDelForm : Window
    {
        public EmployeeDelForm()
        {
            InitializeComponent();
            employeeManagement.DelShow(_employeeID, foreName, lastName, jobDepartment, address, username, password);
        }
       
        string _employeeID = EmployeeList.selectedItemText;

        private void choose_room_top_layer_MouseDown(object sender, MouseButtonEventArgs e)
        {
            employeeManagement.Delete(_employeeID);
            this.Close();
        }

        private void update_employee_top_layer_MouseDown(object sender, MouseButtonEventArgs e)
        {
            employeeManagement.Update(_employeeID, foreName.Text, lastName.Text, jobDepartment.Text, address.Text, username.Text, password.Text);
            MessageBox.Show("updated new data");
        }
    }
}

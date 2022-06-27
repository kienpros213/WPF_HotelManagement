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
    /// Interaction logic for EmployeeForm.xaml
    /// </summary>
    public partial class EmployeeForm : Window
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void choose_room_top_layer_MouseDown(object sender, MouseButtonEventArgs e)
        {
            employeeManagement.Add(foreName.Text, lastName.Text, jobDepartment.Text, address.Text, username.Text, password.Text);
        }
    }
}

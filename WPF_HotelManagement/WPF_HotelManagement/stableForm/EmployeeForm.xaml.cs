using System.Windows;
using System.Windows.Input;

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

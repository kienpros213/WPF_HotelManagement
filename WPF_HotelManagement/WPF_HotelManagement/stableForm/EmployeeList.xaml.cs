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
    /// Interaction logic for EmployeeList.xaml
    /// </summary>
    public partial class EmployeeList : Window
    {
        public EmployeeList()
        {
            InitializeComponent();
            getDataGridView.bindGrid(employeeList, "SELECT * FROM tblEmployees");
        }

        public static string selectedItemText;

        private void employeeList_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            object selectedItem = employeeList.SelectedItem;
            selectedItemText = (employeeList.SelectedCells[0].Column.GetCellContent(selectedItem) as TextBlock).Text;

            EmployeeDelForm _employeeForm = new EmployeeDelForm();
            _employeeForm.Show();
        }

        private void choose_room_top_layer_MouseDown(object sender, MouseButtonEventArgs e)
        {
            EmployeeForm _employeeForm = new EmployeeForm();
            _employeeForm.Show();
        }
    }
}

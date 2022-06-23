using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_HotelManagement
{
    class checkServiceInput
    {
        public static void Check(string cusID, string serviceID, System.Windows.Controls.TextBox serviceName)
        {
            if(serviceName.Text == "0")
            {
                updateReserveData.updateService(cusID, serviceID, serviceName.Text);
            }
        }
    }
}

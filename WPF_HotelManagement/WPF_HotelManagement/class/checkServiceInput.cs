﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPF_HotelManagement
{
    class checkServiceInput
    {
        public static void Check(string cusID, System.Windows.Controls.TextBox breakfast, System.Windows.Controls.TextBox cleaing, System.Windows.Controls.TextBox carRenting, System.Windows.Controls.TextBox massage)
        {
            if(breakfast.Text != "0")
            {
                updateReserveData.updateService(cusID, "1", breakfast.Text);
            }
            if (cleaing.Text != "0")
            {
                updateReserveData.updateService(cusID, "2", cleaing.Text);
            }
            if (carRenting.Text != "0")
            {
                updateReserveData.updateService(cusID, "3", carRenting.Text);
            }
            if (massage.Text != "0")
            {
                updateReserveData.updateService(cusID, "4", massage.Text);
            }
        }
    }
}

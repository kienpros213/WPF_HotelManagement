﻿using System;
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
    /// Interaction logic for reservationCheck.xaml
    /// </summary>
    public partial class reservationCheck : Window
    {
        public reservationCheck()
        {
            InitializeComponent();
            getReserveData();
            getClassAndPrice();
        }
        string idPar = checkInForm.selectedItemText;

        private void getReserveData()
        {
            getReservationData.getData(idPar, customerId, reservationId, roomId, reservationDate, dateIn, dateOut, foreName, lastName, customerAddress, customerStatus);
        }

        private void check_out_top_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //check-in button
            string _roomID = roomId.Text;
            string _cusID = customerId.Text;
            updateReserveData.takeRoom(_roomID, _cusID);
            MessageBox.Show("check-in success");
            this.Close();
        }
        private void getClassAndPrice()
        {
            //fill textBox
            string _roomID = roomId.Text;
            string cusID = customerId.Text;
            paymentMethod.getClass(_roomID, roomClass, price, cusID, daysRange);
            paymentMethod.getDaysRange(cusID, daysRange);
            int priceValue = int.Parse(price.Text);
            int daysRangeValue = int.Parse(daysRange.Text);
            int result = priceValue * daysRangeValue + int.Parse(breakfast.Text) * 100 + int.Parse(carRenting.Text) * 200 + int.Parse(massage.Text) * 150 + int.Parse(cleaning.Text) * 100;
            total.Text = result.ToString();
        }

        private void breakfast_LostFocus(object sender, RoutedEventArgs e)
        {
            string _roomID = roomId.Text;
            string cusID = customerId.Text;
            paymentMethod.getClass(_roomID, roomClass, price, cusID, daysRange);
            paymentMethod.getDaysRange(cusID, daysRange);
            int priceValue = int.Parse(price.Text);
            int daysRangeValue = int.Parse(daysRange.Text);
            int result = priceValue * daysRangeValue + int.Parse(breakfast.Text) * 100 + int.Parse(carRenting.Text) * 200 + int.Parse(massage.Text) * 150 + int.Parse(cleaning.Text) * 100;
            total.Text = result.ToString();
        }

        private void cleaning_LostFocus(object sender, RoutedEventArgs e)
        {
            string _roomID = roomId.Text;
            string cusID = customerId.Text;
            paymentMethod.getClass(_roomID, roomClass, price, cusID, daysRange);
            paymentMethod.getDaysRange(cusID, daysRange);
            int priceValue = int.Parse(price.Text);
            int daysRangeValue = int.Parse(daysRange.Text);
            int result = priceValue * daysRangeValue + int.Parse(breakfast.Text) * 100 + int.Parse(carRenting.Text) * 200 + int.Parse(massage.Text) * 150 + int.Parse(cleaning.Text) * 100;
            total.Text = result.ToString();
        }

        private void carRenting_LostFocus(object sender, RoutedEventArgs e)
        {
            string _roomID = roomId.Text;
            string cusID = customerId.Text;
            paymentMethod.getClass(_roomID, roomClass, price, cusID, daysRange);
            paymentMethod.getDaysRange(cusID, daysRange);
            int priceValue = int.Parse(price.Text);
            int daysRangeValue = int.Parse(daysRange.Text);
            int result = priceValue * daysRangeValue + int.Parse(breakfast.Text) * 100 + int.Parse(carRenting.Text) * 200 + int.Parse(massage.Text) * 150 + int.Parse(cleaning.Text) * 100;
            total.Text = result.ToString();
        }

        private void massage_LostFocus(object sender, RoutedEventArgs e)
        {
            string _roomID = roomId.Text;
            string cusID = customerId.Text;
            paymentMethod.getClass(_roomID, roomClass, price, cusID, daysRange);
            paymentMethod.getDaysRange(cusID, daysRange);
            int priceValue = int.Parse(price.Text);
            int daysRangeValue = int.Parse(daysRange.Text);
            int result = priceValue * daysRangeValue + int.Parse(breakfast.Text) * 100 + int.Parse(carRenting.Text) * 200 + int.Parse(massage.Text) * 150 + int.Parse(cleaning.Text) * 100;
            total.Text = result.ToString();
        }
    }
}

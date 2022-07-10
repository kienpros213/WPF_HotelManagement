    namespace WPF_HotelManagement
{
    class count
    {
        public static void total(string _roomID, string cusID, System.Windows.Controls.TextBox roomClass, System.Windows.Controls.TextBox price, System.Windows.Controls.TextBox daysRange, System.Windows.Controls.TextBox breakfast, System.Windows.Controls.TextBox carRenting, System.Windows.Controls.TextBox cleaning, System.Windows.Controls.TextBox massage, System.Windows.Controls.TextBox discount, System.Windows.Controls.TextBox total)
        {
            payment.getClassAndPrice(_roomID, roomClass, price, cusID, daysRange);
            payment.getDaysRange(cusID, daysRange);
            int priceValue = int.Parse(price.Text);
            int daysRangeValue = int.Parse(daysRange.Text);
            int result = priceValue * daysRangeValue + int.Parse(breakfast.Text) * 100 + int.Parse(carRenting.Text) * 200 + int.Parse(massage.Text) * 150 + int.Parse(cleaning.Text) * 100;
            float discounted = result - (result * (float.Parse(discount.Text)/100));
            total.Text = discounted.ToString();
        }
    }
}

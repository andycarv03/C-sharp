using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBL
{
    public class Sale
    {
        public Customer Customer { get; set; }
        public int Discount { get; set; }

        public Sale(Customer customer)
        {
            this.Customer = customer;
        }
        public string YearEndSale()
        {
            this.Discount = 15;
            string message = string.Empty;

            #region Single Alert Preference
            //if (Customer.AlertPreference == "SMS")
            //{
            //    message = Alerts.SendSMS(Customer.CustomerName, Customer.PhoneNumber, Discount);
            //}
            //if (Customer.AlertPreference == "Email")
            //{
            //    message = Alerts.SendEmail(Customer.CustomerName, Customer.EmailId, Discount);
            //}
            //if (Customer.AlertPreference == "WhatsApp")
            //{
            //    message = Alerts.SendWhatsApp(Customer.CustomerName, Customer.PhoneNumber, Discount);
            //}
            #endregion

            #region Multiple Alert Preferences

            //foreach (var item in Customer.AlertPreferences)

            //{
            //    if (item == "SMS")
            //    {
            //        message += Alerts.SendSMS(Customer.CustomerName, Customer.PhoneNumber, Discount);
            //    }
            //    if (item == "Email")
            //    {
            //        message += Alerts.SendEmail(Customer.CustomerName, Customer.EmailId, Discount);
            //    }
            //    if (item == "WhatsApp")
            //    {
            //        message += Alerts.SendWhatsApp(Customer.CustomerName, Customer.PhoneNumber, Discount);
            //    }
            //}

            message = Customer.AlertPreferences(Customer.CustomerName, Customer.PhoneNumber, Discount);

            #endregion

            return message;
        }

        public string ClearanceSale()
        {
            return null;
        }

        public string FestiveOffer()
        {
            return null;
        }

        //Now since the method to calculate the discount amount is very rarely used, you need not define it inside a class.
        //Instead, you can declare, define and also assign the method to the delegate instance directly.
        
        /* defined in main as delegate */
        /* 
        public static double BirthdayDiscount(double amount)
        {
            double discountAmount = amount * 0.2;
            return discountAmount;
        }
        */
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBL
{
    public delegate string AlertDelegate(string customerName, string mediaType, int discount);
    public static class Alerts
    {
        public static string SendSMS(string customerName, string phoneNumber, int discount)
        {
            string message = "SMS Sent to " + phoneNumber + "\nDear " + customerName +
                ", Avail " + discount + 
                "% discount on all purchased items.\n";
            return message;
        }

        public static string SendEmail(string customerName, string emailId, int discount)
        {
            string message = "Email Sent to " + emailId + "\nDear " + customerName +
                ", Avail " + discount +
                "% discount on all purchased items.\n";
            return message;
        }

        public static string SendWhatsApp(string customerName, string phoneNumber, int discount)
        {
            string message = "WhatsApp message sent to " + phoneNumber + "\nDear " + customerName +
                ", Avail " + discount +
                "% discount on all purchased items.\n";
            return message;
        }
    }
}

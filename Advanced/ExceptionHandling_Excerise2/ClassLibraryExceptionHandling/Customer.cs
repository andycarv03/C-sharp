using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Customer
    {
        private static int counter;
        private string emailId;
        private string phoneNumber;
        public string Address { get; set; }
        public int CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string EmailId 
        {
            get { return emailId; }
            set
            {
                int count = 0;
                foreach (char item in value)
                {
                    if (item == '@')
                        count++;
                }
                if (value.Length >=7 && count == 1 && !value.StartsWith('@') && value.EndsWith("com"))
                {
                    emailId = value;
                }
                else
                {
                    emailId = "NA";
                    throw new InvalidEmailIdException("Email is incorrect and cannot be accepted!");
                }
            }
        }

        public char Gender { get; set; }
        public string Password { get; set; }
        public string PhoneNumber
        {
            get 
            {
                return phoneNumber;
            }
            set 
            {
                if(value.Length == 10 && !value.StartsWith("0"))
                {
                    phoneNumber = value;
                }
                else
                {
                    throw new InvalidPhoneNumberException("Invalid phone number entered! ");
                }
            }
        }
        static Customer()
        {
            counter = 1000;
        }
        public Customer(string Address, string CustomerName, DateTime DateOfBirth, string Email, char Gender, string Password, string PhoneNumber)
        {
            this.Address = Address;
            this.CustomerName = CustomerName;
            this.DateOfBirth = DateOfBirth;
            EmailId = Email;
            this.Gender = Gender;
            this.Password = Password;
            this.PhoneNumber = PhoneNumber;
            counter++;
            CustomerId = counter;
        }
    }
}

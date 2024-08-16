using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingExercise
{
    public class Customer
    {
        public string ClassOfTravel { get; set; }
        public int CustId { get; set; }
        public string CustName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public Customer(string TravelClass, int custId, string custName, DateTime DateOfBirth)
        {
            ClassOfTravel = TravelClass;
            CustId = custId;
            CustName = custName;
            this.DateOfBirth = DateOfBirth;         
        }
        public int CalculateAge()
        {
            DateTime dateTimeDet = DateTime.Now;
            int age = dateTimeDet.Year - DateOfBirth.Year;

            return age;
        }
    }
}

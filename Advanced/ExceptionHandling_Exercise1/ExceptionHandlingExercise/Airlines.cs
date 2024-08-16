using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingExercise
{
    public class Airlines
    {
        //auto-implemented properties.
        public int AirlineId { get; set; }
        public string? AirlineName { get; set; }
        public double BaseFare { get; set; }

        public double CalculateFare(Customer obj)
        {
            int age;
            double totalAmount;
            age = obj.CalculateAge();
            if(age > 0 && age < 100) 
            {
                if (obj.ClassOfTravel == "Business")
                {
                    BaseFare = 10000.0;
                }
                else if (obj.ClassOfTravel == "Premium")
                {
                    BaseFare = 5000.0;
                }
                else if (obj.ClassOfTravel == "Economy")
                {
                    BaseFare = 1200.0;
                }
                else
                {
                    throw new InvalidTravelClassException("Invalid Travel Class");
                }
            }
            else
            {
                throw new InvalidAgeException("Age is Invalid.");
            }
            totalAmount = BaseFare + CalculateServiceCharges(BaseFare) + CalculateTax(BaseFare);
            return totalAmount;
        }

        public double CalculateServiceCharges(double baseFare)
        {

            return baseFare * (5 / 100);
        }

        public double CalculateTax(double baseFare) 
        {
            return baseFare * (15 / 100);
        }

    }
}

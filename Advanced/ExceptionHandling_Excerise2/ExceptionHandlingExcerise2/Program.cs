using ClassLibrary;
using System.Net;
using System.Reflection;

namespace ExceptionHandlingExcerise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string address;
            string name;
            DateTime dateTime;
            string email;
            char gender;
            string password;
            string phoneNumber;
            */
            int number;
            //Console.WriteLine("Hello, World!");
            //Customer customerOne = new Customer("Tokyo", "Lin Yuan", new DateTime(1998,9,1), "linyuan@gmail.com", 'F', "password@12345", "9876543210");

            Console.WriteLine("Enter Number of customers : ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number of customers : "+ number);

            /*
            for (int i = 0; i < number; i++) 
            {
                Console.WriteLine($"Enter Name {i}: ");
                name = Console.ReadLine();
                Console.WriteLine($"Enter Address {i} : ");
                address = Console.ReadLine();
                Console.WriteLine("Enter Email : ");
                email = Console.ReadLine();
                Console.WriteLine("Enter Password : ");
                password = Console.ReadLine();
                Console.WriteLine("Enter Phone number : ");
                phoneNumber = Console.ReadLine();                
            }
            */
        }
    }
}

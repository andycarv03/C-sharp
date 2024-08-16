using QuickKartBL;
using System;

//According to the requirement, if the data is already validated in the Presentation Layer, you as a developer of Business Logic Layer, need not implement validation logic.
namespace QuickKartTestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter CategoryId = ");
            byte categoryId = Convert.ToByte(Console.ReadLine());

            Console.Write("Enter CategoryName = ");
            string categoryName = Console.ReadLine();

            if (categoryId <= 0 || categoryName.Equals(string.Empty))
            {
                Console.WriteLine("Invalid data entered! Please re-execute program and try again!");              
            }
            else
            {
                Category sportsCategory = new Category(categoryId, categoryName);
                Console.WriteLine("CategoryId = {0}", sportsCategory.CategoryId);
                Console.WriteLine("CategoryName = {0}", sportsCategory.CategoryName);
            }
        }
    }
}
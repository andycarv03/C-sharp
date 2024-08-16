using QuickKartBL;
using System;

namespace QuickKartTestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Category sportsCategory = new Category(1, "Sports");
            sportsCategory[0] = 2;
            sportsCategory[1] = "Baseball";

            Console.WriteLine("Sport Category : {0}", sportsCategory[0]);
            Console.WriteLine("Sport Name : {0}", sportsCategory[1]);
        }
    }
}
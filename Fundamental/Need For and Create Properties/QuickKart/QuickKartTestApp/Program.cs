using System;
using QuickKartBL;
internal class Program
{
    static void Main(string[] args)
    {
        Category sportsCategory = new Category(0, null);
        Console.WriteLine("CategoryId = {0}", sportsCategory.CategoryId);
        Console.WriteLine("CategoryName = {0}\n", sportsCategory.CategoryName);

        sportsCategory.CategoryId = 100;
        sportsCategory.CategoryName = "Tennis";

        Console.WriteLine("CategoryId = {0}", sportsCategory.CategoryId);
        Console.WriteLine("CategoryName = {0}", sportsCategory.CategoryName);
    }
}

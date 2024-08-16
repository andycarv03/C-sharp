using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using QuickKartBL;


namespace QuickKartTestApp
{
    //Extension method 1
    //Extension methods should always be declared inside a non-generic static class.
    //Extension methods are identified, when the keyword ‘this’ is used just before the first parameter data type of any method.

    public static class IntegerExtension
    {
        public static bool CheckEvenNumber(this int value)
        {
            if(value % 2 == 0)
                return true;
            else
                return false;
        }
    }

    //Extension Method 2
    //You can have the string extension method declared inside the same IntegerExtension class.
    //Add the ConvertToPascalCase() inside the IntegerExtension class and comment the static class StringExtension.
    public static class StringExtension 
    {
        public static string ConvertToPascalCase(this string name)
        {
            string[] splittedProduct = name.Split(' ');
            var sb = new StringBuilder();
            char[] splittedProductChars;
            foreach (String s in splittedProduct)
            {
                splittedProductChars = s.ToCharArray();
                if (splittedProductChars.Length > 0)
                {
                    splittedProductChars[0] = ((new String(splittedProductChars[0], 1)).ToUpper().ToCharArray())[0];
                }
                sb.Append(new String(splittedProductChars));
                sb.Append(" ");
            }
            return sb.ToString().TrimEnd();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int number = 123457;
            bool checkEven = number.CheckEvenNumber();
            Console.WriteLine("Is number even : {0}", checkEven);

            string customerName = "julianna moore";
            string newString = customerName.ConvertToPascalCase();
            Console.WriteLine("new string {0}", newString);

        }
    }
}

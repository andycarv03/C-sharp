using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuickKartBL;
using System.IO;                    //for file handling

namespace QuickKartTestApp
{
    class Program
    {        
        static void Main(string[] args)
        {
            //object intializer
            Product product = new Product
            {
                ProductName = "Tennis Racket",
                Price = 1099.99,
                QuantityAvailable = 50,
                CategoryId = 1
            };

            #region File Write
            string path = @"C:\Users\andyc\OneDrive\Documents\C#\Products.txt";
            //check if file exists
            bool result = File.Exists(path);                                        //static method of class File
            FileStream fileStream = null;
            if (result) 
            {
                fileStream = new FileStream(path, FileMode.Open , FileAccess.Write);            //access -> read/write, read, write
                Console.WriteLine("Existing file is opened....");
            }
            else
            {
                fileStream = new FileStream(path, FileMode.CreateNew, FileAccess.Write);
                Console.WriteLine("New file stream is created....");
            }
            StreamWriter writer = new StreamWriter(fileStream);
            writer.WriteLine("{0}, {1}, {2}", product.ProductId, product.ProductName, product.Price);

            Console.WriteLine("\nProduct details are saved in the file successfully!");
            writer.Close();
            #endregion

            #region File Read
            FileInfo fileInfo = new FileInfo(path);         //get file size in bytes
            StreamReader reader = null;
            if(File.Exists(path) && fileInfo.Length > 0)
            {
                fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
                reader = new StreamReader(fileStream);
                string products = reader.ReadLine();
                Console.WriteLine("\nProduct details after reading: " + products);
            }
            else
            {
                Console.WriteLine("Sorry!! File does not exist or No contents to read");
            }
            reader.Close();
            File.Create(path);
            #endregion
        }
    }
}

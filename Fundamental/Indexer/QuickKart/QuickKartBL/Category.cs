using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBL
{
    public class Category
    {
        //Auto-implemented properties
        public byte CategoryId { get; set; }                    //array[0]
        public string CategoryName { get; set; }                //array[1]

        public Category(byte categoryId, string categoryName)
        {
            this.CategoryId = categoryId;
            this.CategoryName = categoryName;
        }

        /*
         * Create another property with the following:
         * public access specifier
         * object as return type
         * this as property name
         * square brackets to accept an int for an index number
         */
        //indexers enable objects to be indexed similar to an array.
        public object this[int indexNumber]                                        //boxing
        {
            get 
            {
                if (indexNumber == 0)
                {
                    return this.CategoryId;
                }
                else if (indexNumber == 1) 
                {
                    return this.CategoryName;
                }
                else
                {
                    return 0;
                }

            }
            set 
            {
                if (indexNumber == 0) 
                {
                    this.CategoryId = Convert.ToByte(value);                    //fix compilation errors by unboxing
                }
                else if (indexNumber == 1)
                {
                    this.CategoryName = Convert.ToString(value);                //fix compilation errors by unboxing
                }
            }
        }
    }
}

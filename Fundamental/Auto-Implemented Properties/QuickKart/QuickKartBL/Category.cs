using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBL
{
    public class Category
    {
        /*
         * The compiler declares private instance variables(or fields) for their corresponding auto-implemented properties, 
         * which is neither visible nor accessible to the developer.
         * Usually, private instance variables created by compiler have the following names:

                get_CategoryId
                set_CategoryId
         * Auto-implemented properties helps developer write concise code.
         */
        public byte CategoryId { get; set; }
        public string CategoryName { get; set; }
        public Category(byte categoryId, string categoryName)
        {
            this.CategoryId = categoryId;
            this.CategoryName = categoryName;
        }
    }
}

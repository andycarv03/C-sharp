using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBL
{
    public class Category
    {
        //Instance variables without access modifiers are by default private to the class.
        private byte categoryId;
        private string categoryName;

        //Properties with validation in the business logic layer. Protect the variables from being set to null/0
        public byte CategoryId
        {
            get
            {
                return categoryId;
            }
            set
            {
                if (value != 0)
                {
                    categoryId = value;
                }
            }
        }

        public string CategoryName
        {
            get
            {
                return categoryName;
            }
            set
            {
                if (value != null)
                {
                    categoryName = value;
                }
                else
                {
                    categoryName = "Unassigned";
                }
            }
        }
        public Category(byte categoryId, string categoryName)
        {
            this.categoryId = categoryId;
            this.categoryName = categoryName;
        }
    }

}
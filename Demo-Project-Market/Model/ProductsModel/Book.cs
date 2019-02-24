using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Project_Market.Model.ProductsModel
{
    public class Book : Product
    {
        static string name = "Book";
        const decimal price = 2M;

        public Book() : base(name, price)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Project_Market.Model.ProductsModel
{
    public class Apple : Product
    {
        static string name = "Apple";
        const decimal price = 1.2M;

        public Apple() : base(name,price)
        {

        }
    }
}

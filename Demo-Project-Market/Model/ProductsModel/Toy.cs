using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Project_Market.Model.ProductsModel
{
    public class Toy : Product
    {
        static string name = "Toy";
        const decimal price = 5M;

        public Toy() : base(name, price)
        {
        }
    }
}

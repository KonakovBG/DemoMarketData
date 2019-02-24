using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Project_Market.Model
{
    public class Product
    {
        private string name;
        private decimal price;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if(name == null)
                {
                    throw new InvalidOperationException("The Product name cannnot be null");
                }
                this.name = value;
            }

        }
        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (price < 0)
                {
                    throw new InvalidOperationException("The Price cannot be negative number");
                }
                this.price = value;
            }

        }

        public Product(string Name,decimal Price)
        {
            this.name = Name;
            this.price = Price;

        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Project_Market.Model.CartModel
{
    public class Cart
    {
        public List<Product> products;

        public Cart()
        {
            products = new List<Product>();
        }

        public void Add(Product product)
        {
            products.Add(product);
            
        }

        public void Remove(Product product)
        {
            IfExists(product);
            products.Remove(product);
        }

        public bool IfExists(Product product)
        {
            bool flag = false;

            if (products.Contains(product))
            {
                flag = true;
            }
            else
            {
                throw new ArgumentException("The product does not exist");
            }

            return flag;
        }

        public void Print()
        {
            if(products.Count == 0)
            {
                Console.WriteLine("Your cart is empty!");
                Console.WriteLine("---------------------------------");
            }
            foreach (var item in products)
            {
                Console.WriteLine(item.Name + " - "+ item.Price);
            }
            Console.WriteLine("---------------------------------");
        }

        
    }
}

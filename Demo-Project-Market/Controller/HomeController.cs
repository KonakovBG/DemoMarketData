using Demo_Project_Market.Model;
using Demo_Project_Market.Model.CartModel;
using Demo_Project_Market.Model.ProductsModel;
using Demo_Project_Market.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Project_Market.Controller
{
    public class HomeController
    {
        public Display display;

        public Product apple;
        public Product book;
        public Product toy;

        public Cart cart;

        public HomeController()
        {
            display = new Display();
            apple = new Apple();
            book = new Book();
            toy = new Toy();
            cart = new Cart();            

        }

        public void StartUp()
        {
            Console.WriteLine("Please choose an action and a product:" +
                " Apple/Book/Toy/Show Cart/END");
            string[] commands = Console.ReadLine().Split(' ').ToArray();
            do
            {
                if (commands[0] == "Add")
                {
                    if(commands[1] == "Apple")
                    {
                        cart.Add(apple);
                    }
                    if (commands[1] == "Book")
                    {
                        cart.Add(book);
                    }
                    if (commands[1] == "Toy")
                    {
                        cart.Add(toy);
                    }
                }
                if (commands[0] == "Remove")
                {
                    if (commands[1] == "Apple")
                    {
                        cart.Remove(apple);
                    }
                    if (commands[1] == "Book")
                    {
                        cart.Remove(book);
                    }
                    if (commands[1] == "Toy")
                    {
                        cart.Remove(toy);
                    }
                }
                if(commands[0] == "Show Cart")
                {
                    cart.Print();
                }
                commands = Console.ReadLine().Split(' ').ToArray();
            }
            while (commands[0] == "END");

            Console.WriteLine("--------------------------------  ");
            Console.WriteLine("Thank you for choosing us!");
            Console.WriteLine("--------------------------------  ");
        }

       

    }
}

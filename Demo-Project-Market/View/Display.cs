using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Project_Market.View
{
    public class Display
    {
        public string  First_Name { get; set; }
        public string Last_Name { get; set; }
        public  int Number { get; set; }
        

        public Display()
        {
            Console.WriteLine("Insert: first name /last name/ number!");
            getValues();           
        }

        public void getValues()
        {
            First_Name = Console.ReadLine();
            Last_Name = Console.ReadLine();
            Number = int.Parse(Console.ReadLine());                       
        }

        public void Print()
        {
            Console.WriteLine(First_Name + " - " + Number);
            Console.WriteLine("---------------------------------");
        }

        
        
        
    }
}

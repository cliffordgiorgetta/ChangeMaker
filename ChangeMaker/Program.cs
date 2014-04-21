using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            ChangeMaker(3.18);
            Console.WriteLine();
            ChangeMaker(0.99);
            Console.WriteLine();
            ChangeMaker(12.93);
            Console.WriteLine();




            Console.ReadKey();

        }
        // creating function called ChangeMaker
        static void ChangeMaker(double amount)
        {
           
            Console.WriteLine("Amount: "+ amount);
            
            var Quarters = 0;
            var Dimes = 0;
            var Nickels = 0;
            var Pennies = 0;

            while (amount > .25)
            {
                Quarters++;
                amount -= .25;
            }
            while (amount > .10)
            {
                Dimes++;
                amount -= .10;
            }
            while (amount > .05)
            {
                Nickels++;
               amount -= .05;
            }
            while (amount > .01)
            {
                Pennies++;
                amount -= .01;
            }

            Console.WriteLine("Amount of Quarters: " + Quarters);
            Console.WriteLine("Amount of Dimes: " + Dimes);
            Console.WriteLine("Amount of Nickels: " + Nickels);
            Console.WriteLine("Amount of Pennies: " + Pennies);
            Console.WriteLine("Total Amount of Coins: " + amount);
        }

    }
}

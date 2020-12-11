using System;
using Bakery.Models;

namespace Bakery
{
    public class Program
    {
        public double orderTotal = 0;

        public static void Main()
        {
            Console.WriteLine("~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~");
            Console.WriteLine("Hello! Welcome to Pierre's Bakery!");
            Console.WriteLine("~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~");
            Console.WriteLine("Would you like to place an order for bread or pastries? ('bread' or 'pastries')");
            string orderChoice = Console.ReadLine();
            if (orderChoice == "bread")
            {
                Console.WriteLine("How many loaves of bread would you like to order?");
                int orderNum = int.Parse(Console.ReadLine());
                Console.WriteLine("You have ordered " + orderNum + " loaves of bread. Would you like to complete your bread order? ('Yes' or 'No')");
                string answer = Console.ReadLine();
                if (answer == "Yes")
                {
                    End();
                }

            }
        }
        public static void End()
        {
            Console.WriteLine("That will be " + orderTotal + " please!")
            Console.WriteLine("Pleasure doing business with you, have a wonderful day!");
        }
    }
}
using System;
using Bakery.Models;

namespace Bakery
{
    public class Program
    {
        public static double orderTotal = 0;

        public static void OrderBread()
        {
            Bread bread = new Bread();
            Console.WriteLine("How many loaves of bread would you like to order? They are $5 each, or 2 for $4.");
            int orderNum = int.Parse(Console.ReadLine());
            Console.WriteLine("You have ordered " + orderNum + " loaves of bread. Would you like to complete your bread order? ('Yes' or 'No')");
            string answer = Console.ReadLine();
            if (answer == "Yes")
            {
                if (orderNum % 2 == 0)
                {
                    bread.SetPrice(2);
                    int breadPrice = bread.GetPrice();
                    int totalBread = breadPrice * orderNum;
                    double convertTotal = System.Convert.ToDouble(totalBread);
                    orderTotal += convertTotal;
                    Console.WriteLine("Your subtotal is " + orderTotal + ".");
                }
                else
                {
                    int breadPrice = bread.GetPrice();
                    int totalBread = breadPrice * orderNum;
                    Console.WriteLine("Your subtotal is " + totalBread + ".");
                }
                
                Console.WriteLine("Would you like to add pastries to your order? They are $2 each, or 2 for $3.('Yes' or 'No')");
                string answer2 = Console.ReadLine();
                if (answer2 == "Yes")
                {
                    // pastries function
                }
                
                End();
            }
            else if (answer == "No")
            {
                Console.WriteLine("How many more loaves would you like to add to your order?");
                orderNum = int.Parse(Console.ReadLine());
            }
        }

        public static void Main()
        {
            Console.WriteLine("~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~");
            Console.WriteLine("Hello! Welcome to Pierre's Bakery!");
            Console.WriteLine("~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~");
            Console.WriteLine("Would you like to place an order for bread or pastries? ('bread' or 'pastries')");
            string orderChoice = Console.ReadLine();

            if (orderChoice == "bread")
            {
                OrderBread();
            }
            // else if (orderChoice == "pastries")
            // {
            //     orderPastries();
            // }
        }
        public static void End()
        {
            Console.WriteLine("That will be $" + orderTotal + " ,please!");
            Console.WriteLine("Pleasure doing business with you, have a wonderful day!");
        }
    }
}
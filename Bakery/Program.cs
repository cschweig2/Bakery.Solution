using System;
using Bakery.Models;

namespace Bakery
{
    public class Program
    {
        public static double orderTotal = 0;
        
        public static void TotalPriceBread(int orderNum)
        {
            Bread bread = new Bread();
            if (orderNum % 2 == 0)
            {
                bread.SetPrice(3);
                int breadPrice = bread.GetPrice();
                int totalBread = breadPrice * orderNum;
                double convertTotal = System.Convert.ToDouble(totalBread);
                orderTotal += convertTotal;
                Console.WriteLine("Your subtotal is $" + orderTotal + ".");
            }
            else
            {
                int breadPrice = bread.GetPrice();
                int totalBread = breadPrice * orderNum;
                double convertTotal = System.Convert.ToDouble(totalBread);
                orderTotal += convertTotal;
                Console.WriteLine("Your subtotal is $" + orderTotal + ".");
            }
        }

        public static void TotalPricePastry(int orderNum)
        {
            Pastry pastry = new Pastry();
            if (orderNum % 2 == 0)
                {
                    pastry.SetPrice(1.50);
                    double pastryPrice = pastry.GetPrice();
                    double totalPastry = pastryPrice * System.Convert.ToDouble(orderNum);
                    orderTotal += totalPastry;
                    Console.WriteLine("Your subtotal is $" + orderTotal + ".");
                }
                else
                {
                    double pastryPrice = pastry.GetPrice();
                    double totalPastry = pastryPrice * System.Convert.ToDouble(orderNum);
                    orderTotal += totalPastry;
                    Console.WriteLine("Your subtotal is $" + orderTotal + ".");
                }
        }

        public static void OrderBread()
        {
            Console.WriteLine("How many loaves of bread would you like to order? They are $5 each, or 2 for $6.");
            int orderNum = int.Parse(Console.ReadLine());
            Console.WriteLine("You have ordered " + orderNum + " loaves of bread. Would you like to complete your order of bread? ('Yes' or 'No')");
            string answer = Console.ReadLine();
            if (answer == "Yes" || answer == "No")
            {
                // get total to complete order
                TotalPriceBread(orderNum);
                // ask if would like pastries
                Console.WriteLine("Would you like to add pastries to your order? They are $2 each, or 2 for $3.('Yes' or 'No')");
                string answer2 = Console.ReadLine();
                if (answer2 == "Yes")
                {
                    OrderPastries();
                }
                else if (answer2 == "No")
                {
                    End();
                }
            }
        }

        public static void OrderPastries()
        {
            Console.WriteLine("How many pastries would you like to order? They are $2 each, or 2 for $3.");
            int orderNum = int.Parse(Console.ReadLine());
            Console.WriteLine("You have ordered " + orderNum + " pastries. Would you like to complete your order of pastries? ('Yes' or 'No')");
            string answer = Console.ReadLine();
            if (answer == "Yes" || answer == "No")
            {
                TotalPricePastry(orderNum);
            }
            Console.WriteLine("Will that complete your order? ('Yes' or 'No')");
            string answer2 = Console.ReadLine();
            if (answer2 == "Yes")
            {
                End();
            }
            else if (answer2 == "No")
            {
                Console.WriteLine("What else can I get for you today? ('Bread' or 'Pastries')");
                string answer3 = Console.ReadLine();
                if (answer == "Bread")
                {
                    OrderBread();
                }
                else if (answer == "Pastries")
                {
                    OrderPastries();
                }
            }
        }

        public static void End()
        {
            Console.WriteLine("That will be $" + orderTotal + ", please!");
            Console.WriteLine("Pleasure doing business with you, have a wonderful day!");
        }

        public static void Main()
        {
            Console.WriteLine("~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~");
            Console.WriteLine("Hello! Welcome to Pierre's Bakery!");
            Console.WriteLine("~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~");
            Console.WriteLine("Would you like to place an order for bread or pastries? ('Bread' or 'Pastries')");
            string orderChoice = Console.ReadLine();

            if (orderChoice == "Bread")
            {
                OrderBread();
            }
            else if (orderChoice == "Pastries")
            {
                OrderPastries();
            }
        }
    }
}
using System;
using Bakery.Models;

namespace Bakery
{
    public class Program
    {
        public static double orderTotal = 0;
        public static int pastryOrderCount = 0;
        public static int breadOrderCount = 0;
        public static int orderNumPastries = 0;
        public static int orderNumBread = 0;
        
        // public static void TotalPriceCoffee(int orderNum)
        // {
        //     Drink coffee = new Drink();
        //     coffee.SetPrice(2);
        //     int coffeePrice = coffee.GetPrice();
        // }

        public static void TotalPriceBread(int orderNum)
        {
            Bread bread = new Bread();
            if (orderNum % 2 == 0)
            {
                bread.SetPrice(4);
                int breadPrice = bread.GetPrice();
                int totalBread = breadPrice * orderNum;
                double convertTotal = System.Convert.ToDouble(totalBread);
                orderTotal += convertTotal;
                Console.WriteLine("Your subtotal is $" + orderTotal + ".");
            }
            else
            {
                bread.SetPrice(5);
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
                    pastry.SetPrice(2);
                    double pastryPrice = pastry.GetPrice();
                    double totalPastry = pastryPrice * System.Convert.ToDouble(orderNum);
                    orderTotal += totalPastry;
                    Console.WriteLine("Your subtotal is $" + orderTotal + ".");
                }
        }

        public static void OrderBread(int count)
        {
            if (breadOrderCount < 1)
            {
                Console.WriteLine("How many loaves of bread would you like to order? They are $5 each, or 2 for $8.");
                orderNumBread = int.Parse(Console.ReadLine());
                Console.WriteLine("You have ordered " + orderNumBread + " loaves of bread. Would you like to add pastries to your order? They are $2 each, or 2 for $3.('Yes' or 'No')");
                string answer = Console.ReadLine();
                if (answer == "Yes")
                {
                    breadOrderCount++;
                    TotalPriceBread(orderNumBread);
                    OrderPastries(pastryOrderCount);
                }
                else if (answer == "No")
                {
                    TotalPriceBread(orderNumBread);
                    End();
                }
            }
            else
            {
                Console.WriteLine("How many more loaves of bread would you like to order? As a reminder, they are $5 each, or 2 for $6.");
                int orderNum2 = int.Parse(Console.ReadLine());
                Console.WriteLine("You have ordered " + orderNum2 + " more loaves of bread. Should we complete your order? ('Yes' or 'No')");
                string answer2 = Console.ReadLine();
                if (answer2 == "Yes")
                {
                    orderNumBread = orderNum2;
                    TotalPriceBread(orderNumBread);
                }
                else if (answer2 == "No")
                {
                    Console.WriteLine("Is there anything else I can get for you? ('Bread' or 'Pastries')");
                    string answer3 = Console.ReadLine();
                    if (answer3 == "Bread")
                    {
                        OrderBread(breadOrderCount);
                    }
                    else if (answer3 == "Pastries")
                    {
                        OrderPastries(pastryOrderCount);
                    }
                }
            }
        }

        public static void OrderPastries(int count)
        {
            if (pastryOrderCount < 1)
            {
                Console.WriteLine("How many pastries would you like to order? They are $2 each, or 2 for $3.");
                orderNumPastries = int.Parse(Console.ReadLine());
                Console.WriteLine("You have ordered " + orderNumPastries + " pastries. Would you like to add bread to your order of pastries? ('Yes' or 'No')");
                string answer = Console.ReadLine();
                if (answer == "Yes")
                {
                    pastryOrderCount++;
                    TotalPricePastry(orderNumPastries);
                    OrderBread(breadOrderCount);
                }
                else if (answer == "No")
                {
                    TotalPricePastry(orderNumPastries);
                    End();
                }
            }
            else
            {
                Console.WriteLine("How many more pastries would you like to order? As a reminder, they are $2 each, or 2 for $3");
                int orderNum2 = int.Parse(Console.ReadLine());
                Console.WriteLine("You have ordered " + orderNum2 + " more pastries. Should we complete your order? ('Yes' or 'No')");
                string answer2 = Console.ReadLine();
                if (answer2 == "Yes")
                {
                    orderNumPastries = orderNum2;
                    TotalPricePastry(orderNumPastries);
                }
                else if (answer2 == "No")
                {
                    Console.WriteLine("Is there anything else I can get for you? ('Bread' or 'Pastries')");
                    string answer3 = Console.ReadLine();
                    if (answer3 == "Bread")
                    {
                        OrderBread(breadOrderCount);
                    }
                    else if (answer3 == "Pastries")
                    {
                        OrderPastries(pastryOrderCount);
                    }
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
            Console.WriteLine("MENU");
            Console.WriteLine("| Coffee: $2 | Bread: $5 for 1 loaf or 2 loaves for $8 | Pastries: $2 for 1 or 2 for $3 |");
            Console.WriteLine("What would you like to order? ('Bread', 'Pastries', or 'Coffee')");
            string orderChoice = Console.ReadLine();

            if (orderChoice == "Bread")
            {
                OrderBread(orderNumBread);
            }
            else if (orderChoice == "Pastries")
            {
                OrderPastries(orderNumPastries);
            }
        }
    }
}
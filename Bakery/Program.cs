using System;
using Bakery.Models;

namespace Bakery
{
    public class Program
    {
        public static double orderTotal = 0;
        public static int pastryOrderCount = 0;
        public static int breadOrderCount = 0;
        public static int mainOrderCount = 0;
        public static int orderNumPastries = 0;
        public static int orderNumBread = 0;
        public static int orderNumCoffee = 0;

        public static void OrderBread(int count)
        {
            Bread bread = new Bread();
            mainOrderCount++;
            if (breadOrderCount < 1)
            {
                Console.WriteLine("How many loaves of bread would you like to order? They are $5 each, or 2 for $8.");
                orderNumBread = int.Parse(Console.ReadLine());
                Console.WriteLine("You have ordered " + orderNumBread + " loaves of bread. Would you like to add pastries to your order? They are $2 each, or 2 for $3.('Yes' | 'No' | 'Complete order')");
                string answer = Console.ReadLine();
                if (answer == "Yes")
                {
                    breadOrderCount++;
                    double totalBread = bread.TotalPriceBread(orderNumBread);
                    orderTotal += totalBread;
                    OrderPastries(pastryOrderCount);
                }
                else if (answer == "No")
                {
                    double totalBread = bread.TotalPriceBread(orderNumBread);
                    orderTotal += totalBread;
                    Main();
                }
                else if (answer == "Complete order")
                {
                    double totalBread = bread.TotalPriceBread(orderNumBread);
                    orderTotal += totalBread;
                    End();
                }
            }
            else
            {
                Console.WriteLine("How many more loaves of bread would you like to order? As a reminder, they are $5 each, or 2 for $6.");
                int orderNum2 = int.Parse(Console.ReadLine());
                Console.WriteLine("You have ordered " + orderNum2 + " more loaves of bread. Should we complete your order? ('Yes' | 'No')");
                string answer2 = Console.ReadLine();
                if (answer2 == "Yes")
                {
                    orderNumBread = orderNum2;
                    double totalBread = bread.TotalPriceBread(orderNumBread);
                    orderTotal += totalBread;
                    End();
                }
                else if (answer2 == "No")
                {
                    double totalBread = bread.TotalPriceBread(orderNumBread);
                    orderTotal += totalBread;
                    Main();
                }
            }
        }

        public static void OrderPastries(int count)
        {
            Pastry pastry = new Pastry();
            mainOrderCount++;
            if (pastryOrderCount < 1)
            {
                Console.WriteLine("How many pastries would you like to order? They are $2 each, or 2 for $3.");
                orderNumPastries = int.Parse(Console.ReadLine());
                Console.WriteLine("You have ordered " + orderNumPastries + " pastries. Should we complete your order? ('Yes' | 'No')");
                string answer = Console.ReadLine();
                if (answer == "Yes")
                {
                    double totalPastry = pastry.TotalPricePastry(orderNumPastries);
                    orderTotal += totalPastry;
                    End();
                }
                else if (answer == "No")
                {
                    pastryOrderCount++;
                    double totalPastry = pastry.TotalPricePastry(orderNumPastries);
                    orderTotal += totalPastry;
                    Main();
                }
            }
            else
            {
                Console.WriteLine("How many more pastries would you like to order? As a reminder, they are $2 each, or 2 for $3");
                int orderNum2 = int.Parse(Console.ReadLine());
                Console.WriteLine("You have ordered " + orderNum2 + " more pastries. Should we complete your order? ('Yes' | 'No')");
                string answer2 = Console.ReadLine();
                if (answer2 == "Yes")
                {
                    orderNumPastries = orderNum2;
                    double totalPastry = pastry.TotalPricePastry(orderNumPastries);
                    orderTotal += totalPastry;
                    End();
                }
                else if (answer2 == "No")
                {
                    double totalPastry = pastry.TotalPricePastry(orderNumPastries);
                    orderTotal += totalPastry;
                    Main();
                } 
            }
        }

        public static void OrderCoffee(int count)
        {
            mainOrderCount++;
            Console.WriteLine("What size coffee would you like to order?('Small' | 'Medium' | 'Large')");
            string coffeeSize = Console.ReadLine();
            try
            {
                if (coffeeSize == "Small")
                {
                    Drink coffee = new Drink(coffeeSize, 1);
                    double totalCoffeeSmall = coffee.TotalPriceCoffee(1);
                    orderTotal += totalCoffeeSmall;
                }
                else if (coffeeSize == "Medium")
                {
                    Drink coffee = new Drink(coffeeSize, 2);
                    double totalCoffeeMedium = coffee.TotalPriceCoffee(1);
                    orderTotal += totalCoffeeMedium;
                }
                else if (coffeeSize == "Large")
                {
                    Drink coffee = new Drink(coffeeSize, 3);
                    double totalCoffeeLarge = coffee.TotalPriceCoffee(1);
                    orderTotal += totalCoffeeLarge;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Message = {0}", ex.Message);
            }
            Console.WriteLine("Is there anything else I can get for you? ('Bread' | 'Pastries' | 'Complete order' | 'Main menu')");
            string answer = Console.ReadLine();
            try
            {
                if (answer == "Bread")
                {
                    OrderBread(breadOrderCount);
                }
                else if (answer == "Pastries")
                {
                    OrderPastries(pastryOrderCount);
                }
                else if (answer == "Complete order")
                {
                    End();
                }
                else if (answer == "Main menu")
                {
                    Main();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Message = {0}", ex.Message);
            }
        }

        public static void End()
        {
            Console.WriteLine("That will be $" + orderTotal + ", please!");
            Console.WriteLine("Pleasure doing business with you, have a wonderful day!");
        }

        public static void Main()
        {
            if (mainOrderCount < 1)
            {
                Console.WriteLine("~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~");
                Console.WriteLine("Hello! Welcome to Pierre's Bakery!");
                Console.WriteLine("~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~");
                Console.WriteLine("MENU");
                Console.WriteLine("~~~");
                Console.WriteLine("| Coffee: $1 for small, $2 for medium, $3 for large | Bread: $5 for 1 loaf or 2 loaves for $8 | Pastries: $2 for 1 or 2 for $3 |");
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
                else if (orderChoice == "Coffee")
                {
                    OrderCoffee(orderNumCoffee);
                }
            }
            else
            {
                Console.WriteLine("MENU");
                Console.WriteLine("~~~");
                Console.WriteLine("| Coffee: $1 for small, $2 for medium, $3 for large | Bread: $5 for 1 loaf or 2 loaves for $8 | Pastries: $2 for 1 or 2 for $3 |");
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
                else if (orderChoice == "Coffee")
                {
                    OrderCoffee(orderNumCoffee);
                }
            }
        }
    }
}
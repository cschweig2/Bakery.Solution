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
            else if ((orderNum - 1) % 2 == 0)
            {
                bread.SetPrice(4);
                int breadPrice = bread.GetPrice();
                int totalBread = breadPrice * (orderNum - 1);
                double convertTotal = System.Convert.ToDouble(totalBread);
                orderTotal += convertTotal + 5;
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
            else if ((orderNum - 1) % 2 == 0)
            {
                pastry.SetPrice(1.50);
                double pastryPrice = pastry.GetPrice();
                double totalPastry = pastryPrice * (System.Convert.ToDouble(orderNum) - 1);
                orderTotal += totalPastry + 2;
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

        public static void TotalPriceCoffee(string size)
        {
            if (size == "Small")
            {
                Drink coffeeSmall = new Drink("small", 1);
                double price = coffeeSmall.GetPrice();
                orderTotal += price;
                Console.WriteLine("Your subtotal is $" + orderTotal + ".");
            }
            else if (size == "Medium")
            {
                Drink coffeeMed = new Drink("medium", 2);
                double price = coffeeMed.GetPrice();
                orderTotal += price;
                Console.WriteLine("Your subtotal is $" + orderTotal + ".");
            }
            else if (size == "Large")
            {
                Drink coffeeLge = new Drink("Large", 3);
                double price = coffeeLge.GetPrice();
                orderTotal += price;
                Console.WriteLine("Your subtotal is $" + orderTotal + ".");
            }
        }

        public static void OrderBread(int count)
        {
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
                    TotalPriceBread(orderNumBread);
                    OrderPastries(pastryOrderCount);
                }
                else if (answer == "No")
                {
                    TotalPriceBread(orderNumBread);
                    Main();
                }
                else if (answer == "Complete order")
                {
                    TotalPriceBread(orderNumBread);
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
                    TotalPriceBread(orderNumBread);
                    End();
                }
                else if (answer2 == "No")
                {
                    TotalPriceBread(orderNumBread);
                    Main();
                }
            }
        }

        public static void OrderPastries(int count)
        {
            mainOrderCount++;
            if (pastryOrderCount < 1)
            {
                Console.WriteLine("How many pastries would you like to order? They are $2 each, or 2 for $3.");
                orderNumPastries = int.Parse(Console.ReadLine());
                Console.WriteLine("You have ordered " + orderNumPastries + " pastries. Should we complete your order? ('Yes' | 'No')");
                string answer = Console.ReadLine();
                if (answer == "Yes")
                {
                    TotalPricePastry(orderNumPastries);
                    End();
                }
                else if (answer == "No")
                {
                    pastryOrderCount++;
                    TotalPricePastry(orderNumPastries);
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
                    TotalPricePastry(orderNumPastries);
                    End();
                }
                else if (answer2 == "No")
                {
                    TotalPricePastry(orderNumPastries);
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
                TotalPriceCoffee(coffeeSize);
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
                    TotalPriceCoffee(coffeeSize);
                    OrderBread(breadOrderCount);
                }
                else if (answer == "Pastries")
                {
                    TotalPriceCoffee(coffeeSize);
                    OrderPastries(pastryOrderCount);
                }
                else if (answer == "Complete order")
                {
                    TotalPriceCoffee(coffeeSize);
                    End();
                }
                else if (answer == "Main menu")
                {
                    TotalPriceCoffee(coffeeSize);
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
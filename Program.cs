using System;


namespace ECommerce
{
    internal class Program
    {

        static void Card()
        {
            Console.Write("Enter your Usernname: ");
            String cardName = Console.ReadLine();
            Console.Write("Enter your Password: ");
            String cardPassword = Console.ReadLine();
            Console.Write("Enter your Card Number: ");
            long cardNumber = Convert.ToInt64(Console.ReadLine());
        }

        static void Main(string[] args)
        {

            List<string> cart = new List<string>();

            char answer;

            Console.WriteLine("Select an Option:");
            Console.WriteLine("1. Card");
            Console.WriteLine("2. Cart");
            int optionChoice = Convert.ToInt16(Console.ReadLine());

            if (optionChoice == 1)
            {
                Card();

            }
            else
            {
                Console.WriteLine("Hello");
            }


            Console.WriteLine("Would you like to access your cart? Y/N");
            answer = Convert.ToChar(Console.ReadLine());

            if (answer == 'Y' || answer == 'y')
            {
                if (cart.Count == 0)
                {
                    Console.WriteLine("Your cart is empty.");

                    Console.WriteLine("Would you like to add an item to your cart? Y/N");
                    char choiceCart = Convert.ToChar(Console.ReadLine());

                    if (choiceCart == 'Y' || choiceCart == 'y')
                    {
                        Console.WriteLine("What item would you like to add to your cart?");
                        string item = Console.ReadLine();
                        cart.Add(item);
                        Console.WriteLine($"{item} has been added to your cart.");
                    }
                    else
                    {
                        Console.WriteLine("Exiting cart...");
                    }
                }
                else
                {
                    Console.WriteLine("Your cart:");
                    foreach (string item in cart)
                    {
                        Console.WriteLine(item);
                    }
                }

            }

            else
            {
                Console.WriteLine("Exiting cart....");
            }

        }
    }
}

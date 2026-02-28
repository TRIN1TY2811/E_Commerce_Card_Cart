// See https://aka.ms/new-console-template for more information

using System;


 void Card()
{
    Console.Write("Enter your Usernname: ");



}
    
    

        List<string> cart = new List<string>();

        char answer;

Console.WriteLine("Select an Option:");
Console.WriteLine("1. Card");
Console.WriteLine("2. Cart");
int optionChoice = Convert.ToInt16(Console.ReadLine());

if (optionChoice == 1)
{ 
   

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
    
    


   



/*Woud you like to edit your cart? Loop
 * Cart is empty - if else
 * cart if full - delete 
 * 
 * 
 * String Name[] = new String[0];
 * Name[0] = "Apple";
 * 
 */


 




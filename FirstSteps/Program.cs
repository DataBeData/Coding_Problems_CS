using System;
using System.Linq.Expressions;

class Program
{
    static void Main()

    {
      
    }
    
    private static void EasyInterface()
    {
        Console.Write("Please enter a word: ");
        string? userInput = Console.ReadLine();
        Console.WriteLine($"You entered: {userInput}");
    }

    private static void OddOrEven()
    {
        while (true)
        {

            Console.Write("Give a number: ");
            string? userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int number))
            {
                Console.WriteLine($"You entered: {number}");
                break;
            }
            else
            {
                Console.WriteLine("That's not a valid number!");
            }
         }
    }

    
}


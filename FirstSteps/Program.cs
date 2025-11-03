using System;

class Program
{
    static void Main()

    {
        var sq = new Square();
        sq.GetInput();
        sq.MakingSquare();
        
        Console.WriteLine(Calculator.Add(3, 4));      // prints 7
        Console.WriteLine(Calculator.Divide(10, 2));  // prints 5
    }

 }



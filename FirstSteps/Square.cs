using System;

class Square
{

    int number = 5;
    int result;


    public void MakingSquare()
    {
        result = number * number;
        Console.WriteLine($"the square of {number} is exactly {result}");
    }

   
}
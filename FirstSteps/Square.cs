using System;

class Square
{

    int number;
    int result;

    public int GetInput()
    {
        Console.WriteLine("Give a number, any number: ");
        number = Convert.ToInt32(Console.ReadLine());
        return number;
    }

    public void MakingSquare()
    {
        result = number * number;
        Console.WriteLine($"the square of {number} is exactly {result}");
    }
}
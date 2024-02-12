// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a whole number: ");
        int number = int.Parse(Console.ReadLine());

        if (number > 0)
        {
            Console.WriteLine("The number is positive and " + (number % 2 == 0 ? "even" : "odd"));
        }
        else if (number < 0)
        {
            Console.WriteLine("The number is negative and " + (number % 2 == 0 ? "even" : "odd"));
        }
        else
        {
            Console.WriteLine("The number is zero (and it is even)");
        }
    }
}

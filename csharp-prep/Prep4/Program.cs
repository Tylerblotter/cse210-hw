using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine($"The sum is: {number} ");
        
    }
}
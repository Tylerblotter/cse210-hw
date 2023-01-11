using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        // Console.WriteLine($"Your random number is: {number}");
        bool guessed = false;
        int turns = 0;
        while(guessed == false)
        {
        Console.Write("Please enter your guess: ");
        int answer = int.Parse(Console.ReadLine());
        turns += 1;

        Console.WriteLine($"They guessed {answer}");

        if (answer > number)
        {
            Console.WriteLine("Lower");
            
        }
        else if (answer < number)
        {
            Console.WriteLine("Higher");
        }
        else 
        {
            Console.WriteLine("Correct, Perfect, Great Job!");
            guessed = true;
        }
        }
        Console.WriteLine($"It took you {turns} turns to guess the number");
    }
}
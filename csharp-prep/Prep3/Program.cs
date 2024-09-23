using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 200);
        Console.Write("What is your guess? ");
        string guess = Console.ReadLine();
        int userGuess = int.Parse(guess);
        while (userGuess != number)
        {
            Console.Write("What is your guess? ");
            userGuess = int.Parse(Console.ReadLine());
            if (userGuess < number)
            {
                Console.WriteLine("Higher");
            }
            else if (userGuess > number)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("That's right!");
            }
        }
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What was your final grade? ");
        string grade = Console.ReadLine();
        int value = int.Parse(grade);
        if (value >= 70)
        {
            Console.WriteLine("Congrats!! You've passed");
        }  
        else
            Console.WriteLine("I am sorry, but there's always tomorrow right?");
            if (value >= 90)
            {
                Console.WriteLine("Your final grade is A");
            }
            else if (value >= 80)
            {
                Console.WriteLine("Your final grade is B");
            }
            else if (value >= 70)
            {
                Console.WriteLine("Your final grade is C");
            }
            else if (value >= 60)
            {
                Console.WriteLine("Your final grade is D");
            }
            else
            {
                Console.WriteLine("Your final grade is F");
            }
    }
}
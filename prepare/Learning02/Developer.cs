using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        Console.Write("Welcome, what do you want to do today? ");
        Console.WriteLine("1. Add 2. Display 3. Save 4. Load 5. Exit");
        string choice = Console.ReadLine();
        int userChoice = int.Parse(choice);
        while (userChoice == 1 || userChoice == 2 || userChoice == 3 || userChoice == 4 || userChoice == 5)
        {
            if (userChoice == 1)
            {
                Entry newEntry = new Entry();

                Console.Write("Enter the date (DD/MM/YYYY): ");
                newEntry._date = Console.ReadLine();

                newEntry._promptText = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"Prompt: {newEntry._promptText}");

                Console.Write("Write your entry: ");
                    newEntry._entryText = Console.ReadLine();

                    // Adicionando a nova entrada ao jornal
                    myJournal.AddEntry(newEntry);
                    Console.WriteLine("Entry added successfully!");
            }
            
            else if (userChoice == 2)
            {
                myJournal.DisplayEntries();
            }   

            else if (userChoice == 3)
            {
                Console.Write("Enter the filename to save: ");
                string filename = Console.ReadLine();
                myJournal.SaveToFile(filename);
            }

            else if (userChoice == 4)
            {
                Console.Write("Enter the filename to load: ");
                string filename = Console.ReadLine();
                myJournal.LoadFromFile(filename);
            }

            else if (userChoice == 5)
            {
                Console.WriteLine("Thanks for showing up!!");
                break;
            }

            else 
            {
                Console.WriteLine("Invalid choice. Try again");
            }
        }
    }
}
//To exceed requirement, I included: 1. A Weather property to store the current weather in the Entry class.
// 2. The Journal class has methods SaveToCsv and LoadFromCsv to ensure that special characters like commas and quotation marks are handled correctly

using System;
using System.IO;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Console.WriteLine("Welcome to the Journal Program!");

        while (true)
        {   
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("\nJournal App Menu:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do: ");
            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Please enter a valid number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    string prompt = journal.GetRandomPrompt();
                    Console.WriteLine($"Today's prompt: {prompt}");
                    Console.Write("Your response: ");
                    string entryText = Console.ReadLine();
                    journal.AddEntry(prompt, entryText);
                    break;
                case 2:
                    journal.DisplayAllEntries();
                    break;
                case 3:
                    Console.Write("Enter CSV file name to save: ");
                    string csvFileName = Console.ReadLine();
                    journal.SaveToCsv(csvFileName);
                    break;
                case 4:
                    Console.Write("Enter CSV file name to load: ");
                    string loadCsvFileName = Console.ReadLine();
                    journal.LoadFromCsv(loadCsvFileName);
                    break;
                case 5:
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }
    
}
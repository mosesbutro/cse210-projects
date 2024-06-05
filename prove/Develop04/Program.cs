// To exceed requirement, I included code to make the program randomly select a different quetion without repeating a question untill all questions have been asked.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness App!");

        while (true)
        {
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");

            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    
                    // Implement the logic for starting and running the breathing activity
                    var breathingActivity = new BreathingActivity(duration:10);
                    breathingActivity.Run();
                    break;
                case "2":
                    // Call the reflection activity method
                    var reflectingActivity = new ReflectingActivity(duration:10); // Example duration (in seconds)
                    reflectingActivity.Run();
                    break;
                case "3":
                    // Implement the logic for starting and running the listing activity
                    var listingActivity = new ListingActivity(duration:10); // Example duration (in seconds)
                    listingActivity.Run();
                    break;
                case "4":
                    Console.WriteLine("Thank you for using the Mindfulness App. Have a peaceful day!");
                    return; // Exit the program
                default:
                    Console.WriteLine("Invalid choice. Please select 1, 2, 3, or 4.");
                    break;
            }
        }
    }
}
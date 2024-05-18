//To exceed requirement. I included a Scripture Library:
//Instead of working with a single scripture, the program now has a library of scriptures.
//Each time you run the program, it randomly selects a scripture from the library to present to the user.
//The program now leverages randomness to choose a scripture.

using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
       // Create a library of scriptures
        var scriptures = new List<Scripture>
        {
            new Scripture(new Reference("John", 3, 16, 16), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
            new Scripture(new Reference("Psalm", 23, 1, 2), "The Lord is my shepherd; I shall not want. He maketh me to lie down in green pasture: he leadeth me beside the still waters."),
            new Scripture(new Reference("Matthew", 6, 33, 33), "But seek ye first the kingdom of God, and his righteousness; and all these things shall be added unto you."),
            new Scripture(new Reference("James", 1,27, 27), "Pure religion and undefiled before God and the Father is this, To visit the fartherless and widows in their affliction, and to keep himself unspotted from the world.")
        };

        // Randomly select a scripture
        var random = new Random();
        var selectedScripture = scriptures[random.Next(scriptures.Count)];

        while (!selectedScripture.IsCompletelyHidden())
        {
            selectedScripture.Display();
            Console.WriteLine("Press Enter to continue or type 'quit' to finish:");
            var input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                Console.WriteLine("Thank you for playing! You can continue later.");

                break;
            }
            selectedScripture.HideRandomWords(3); // Hide 3 random words
        }

        if (selectedScripture.IsCompletelyHidden())
        {
            Console.WriteLine("All words are hidden. Memorization complete!");
        }    
    }
    
}
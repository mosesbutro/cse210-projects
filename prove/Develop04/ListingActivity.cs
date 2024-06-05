using System;

class ListingActivity : Activity
{  
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    private int _count; // Used to keep track of the number of items listed

    public ListingActivity(int duration) : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area", duration) { }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        string randomPrompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine($"---{randomPrompt}---");
    }

    public List<string> GetListFromUser()
    {
        List<string> items = new List<string>();

        // Prompt user to keep listing items
        string input;
        do
        {
            input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input) && input.ToLower() != "done")
            {   
                items.Add(input);
                _count++; 
            }
        } while (input.ToLower() != "done");

        return items;
    }

    public void Run()
    {
        DisplayStartingMessage();
        
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {   
            Console.WriteLine("List as many responses you can to the following prompt:");
            GetRandomPrompt();
            Console.Write("You may begin in: ");
            ShowCountDown(5);
            List<string> userItems = GetListFromUser();
            int _count = userItems.Count;
            Console.WriteLine($"\nYou listed {_count} items.");
        }
        DisplayEndingMessage();
        ShowSpinnerSeconds(3);
    }
}

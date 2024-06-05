using System;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };


    public ReflectingActivity(int duration) : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life", duration) {}

    public string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        return _questions[random.Next(_questions.Count)];
    }

    public void DisplayPrompt(string prompt)
    {
        Console.WriteLine($"---{prompt}---");
        //ShowCountDown(5); // Countdown for thinking time
    }

    public void DisplayQuestions()
    {
        foreach (string question in _questions)
        {
            Console.Write($">{question} ");
            ShowSpinnerSeconds(10); // Spinner animation
        }
    }

    public void Run()
    {
        DisplayStartingMessage();
        DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < _duration)

        //DateTime endTime = DateTime.Now.AddSeconds(_duration);

        //while (DateTime.Now < endTime)
        {   
            Console.WriteLine("\nConsider the follwing prompt:");
            string randomPrompt = GetRandomPrompt(); //Generate random prompt
            DisplayPrompt(randomPrompt);

            //Ask for user input
            Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
            var input = Console.ReadLine();

            // Generate random questions to encourage reflection
            Console.WriteLine("\nNow ponder on each of the following questions as they relate to this experience.");
            Console.Write("You may begin in: ");
            ShowCountDown(5);
            Console.WriteLine();
            DisplayQuestions();
        }
            DisplayEndingMessage();
    }

    

}
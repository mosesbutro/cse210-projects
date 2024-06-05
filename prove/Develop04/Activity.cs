using System;
using System.Threading;

public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
        
    }

     public void DisplayStartingMessage()
    {
        Console.WriteLine($"\nWelcome to the {_name} activity.\n{_description}.");
        Console.Write("\nHow long, in second, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Thread.Sleep(2000); // Pause for 2 seconds
        Console.WriteLine("Get ready....");
        ShowSpinnerSeconds(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"\nWell done!\nYou have completed another ({_duration} seconds) of the {_name} Activity.");
        Thread.Sleep(2000); // Pause for 2 seconds
    }

    public void ShowSpinnerSeconds(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("/");
            Thread.Sleep(500); // Pause for half a second
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Console.Write("-");
            Thread.Sleep(500); // Pause for half a second
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            
        }
        Console.WriteLine();
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000); // Pause for 1 second
            Console.Write("\b \b");
        }
    }
}
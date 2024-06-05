using System;

public class BreathingActivity : Activity
{
    public BreathingActivity(int duration) : base("Breathing", "\nThis activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", duration) {}

     public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        
        while (DateTime.Now < endTime)
        {
            Console.Write("\nBreathe in...");
            ShowCountDown(2);

            if (DateTime.Now >= endTime)
                break;

            
            Console.Write("\nNow breathe out...");
            ShowCountDown(3);
            Console.WriteLine();
        }

        DisplayEndingMessage();
        ShowSpinnerSeconds(3);
    }
}
using System;
using System.IO;
using System.Collections.Generic;

// Entry class represents a journal entry
public class Entry
{
    public string Date { get; set; }
    public string PromptText { get; set; }
    public string EntryText { get; set; }

    // Additional information: Weather
    public string Weather { get; set; }

    // Displays the entry details
    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Weather: {Weather}");
        Console.WriteLine($"Prompt: {PromptText}");
        Console.WriteLine($"Response: {EntryText}\n");
    }
}



using System;
using System.IO;
using System.Collections.Generic;

// Manages the collection of journal entries
public class Journal
{
    private List<Entry> _entries;
    private PromptGenerator _promptGenerator;

    public Journal()
    {
        _entries = new List<Entry>();
        _promptGenerator = new PromptGenerator();
    }

    // Allows access to a random prompt from the PromptGenerator
    public string GetRandomPrompt()
    {
        return _promptGenerator.GetRandomPrompt();
    }

    // Adds a new entry to the journal
    public void AddEntry(string promptText, string entryText)
    {
        Entry newEntry = new Entry
        {
            Date = DateTime.Now.ToString("yyyy-MM-dd"),
            PromptText = promptText,
            EntryText = entryText
        };
        _entries.Add(newEntry);
    }

    // Displays all entries in the journal
    public void DisplayAllEntries()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries found.");
            return;
        }

        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }

    // Saves the journal to a file
    public void SaveToCsv(string fileName = "dailyEntry.csv")
    {
        using (StreamWriter file = new StreamWriter(fileName))
        {   
            file.WriteLine("Date,Weather,Prompt,Response");
            foreach (var entry in _entries)
            {
                string csvLine = $"\"{entry.Date}\",\"{entry.Weather}\",\"{entry.PromptText}\",\"{entry.EntryText}\"";
                file.WriteLine(csvLine);
            }
            
        }
        Console.WriteLine($"Journal saved to {fileName}");
    }

    // Loads the journal from a file
    public void LoadFromCsv(string fileName = "dailyEntry.csv")
    {
        _entries.Clear(); // Clear current entries
        using (StreamReader file = new StreamReader(fileName))
        {   
            file.ReadLine(); // Skip the header line

            string line;
            while ((line = file.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                Entry entry = new Entry
                {
                    Date = parts[0].Trim('"'),
                    Weather = parts[1].Trim('"'),
                    PromptText = parts[2].Trim('"'),
                    EntryText = parts[3].Trim('"')
                };
                _entries.Add(entry);
            }
        }
        Console.WriteLine($"Journal loaded from {fileName}");
    }
}
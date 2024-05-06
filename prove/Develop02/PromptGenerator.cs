using System;
using System.IO;
using System.Collections.Generic;

// Generates random prompts for journal entries
public class PromptGenerator
{
    private List<string> _prompts;
    private string _lastPrompt;
    public PromptGenerator()
    {
        _prompts = new List<string>
        {
            "Who was the most interesting person you interacted with today?",
            "What was the best part of your day?",
            "How did you see the hand of the Lord in your life today?",
            "What was the strongest emotion you felt today?",
            "If you could do one thing over today, what would it be?",
            "How did your faith influence your decisions or actions today?",
            "What was the most memorable moment you shared with your family today?",
            "Describe a challenge or setback you faced today, what did you learn from the experience?"
        };
        _lastPrompt = string.Empty;
    }

    // Returns a random prompt from the list, avoiding consecutive duplicates
    public string GetRandomPrompt()
    {
        Random random = new Random();
        string prompt;
        do
        {
            int index = random.Next(_prompts.Count);
            prompt = _prompts[index];
        } while (prompt == _lastPrompt);

        _lastPrompt = prompt;
        return prompt;
    }
}




using System;
using System.Collections.Generic;

public class PromptGenerator
{
    // Create a new list of prompts
    public List<string> _prompts = new List<string>(); // left empty since classes are reallly just templates and thers no need to poulate the template

    
    // Create a Random instance
    private static Random random = new Random();

    // Constructor
    public PromptGenerator()
    {
        // Initialize randomPrompt in the constructor
        string randomPrompt = GetRandomPrompt();
        Console.WriteLine(randomPrompt);  // You can print or use randomPrompt as needed
    }

    // Method to get a random item from a list
    public string GetRandomPrompt()
    {
        if (_prompts == null || _prompts.Count == 0)
        {
            throw new ArgumentException("The list is null or empty.");
        }
        
        // Generate a random index
        int randomIndex = random.Next(0, _prompts.Count);

        // Return the item at the random index
        return _prompts[randomIndex];
    }
}


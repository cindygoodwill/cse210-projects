using System.Collections.Generic;

public class PromptGenerator  // DONE
{
    public List<string> _prompts;

    public PromptGenerator()
    {
        _prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What are you grateful for today?",
            "What was a challenge you faced recently, and how did you overcome it?",
            "Describe your ideal day. What would it be like?",
            "What do you want to tell your future self today?",
            "What did you learn today, and how will you apply that knowledge?",
            "What are you looking forward to tomorrow?",
            "What did you eat and drink today? How did it make you feel?",
            "How did you feel when you woke up today?",
            "What did you do today to take care of yourself?"
        };
    }

    public string ChoosePrompt()
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, 14);
        return _prompts[number];

    }
}
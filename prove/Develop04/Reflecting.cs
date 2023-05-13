using System.Collections.Generic;
public class Reflecting : Activity // DONE
{
    private string _activityName, _activityDescription;
    private List<string> _listPrompt, _listQuestions;

    public Reflecting()
    {
        _activityDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _activityName = "Reflecting Activity";
        _listPrompt = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
            "Think of a time when you made a mistake and learned an important lesson from it.",
            "Think of a time when you had to overcome a fear or challenge.",
            "Think of a time when you made a positive impact on someone's life.",
            "Think of a time when you demonstrated leadership skills.",
            "Think of a time when you were faced with a difficult decision and made the right choice.",
            "Think of a time when you had to step outside of your comfort zone and try something new.",
            "Think of a time when you received recognition for something you worked hard on."
        };
        
        _listQuestions = new List<string>
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
    }

    public string RGetActivityName()
    {
        return _activityName;
    }

    public void RSetActivityName(string name)
    {
        _activityName = name;
    }

    public string RGetActivityDescription()
    {
        return _activityDescription;
    }

    public void RSetActivityDescription(string description)
    {
        _activityDescription = description;
    }

    public List<string> RGetListPrompt()
    {
        return _listPrompt;
    }

    public void RSetListPrompt(List<string> prompt)
    {
        _listPrompt = prompt;
    }

    public List<string> RGetListQuestions()
    {
        return _listQuestions;
    }

    public void RSetListQuestions(List<string> questions)
    {
        _listQuestions = questions;
    }

    public void ReflectingActivity()
    {
        
        base.BeginActivity(_activityName, _activityDescription);

        //Reflecting activity
        Console.WriteLine();

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, 10);
        Console.WriteLine($"---{_listPrompt[number]}---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind press enter to continue. ");
        Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Now ponder each of the following questions as they relate to this experience.");
        Console.WriteLine("You may begin in: ");
        CountDown(5);
        Console.WriteLine();

        for (int i = 0; i < base.GetActivityTime() / 6; i++)
        {
            Random randomGenerator2 = new Random();
            int number2 = randomGenerator2.Next(0, 8);
            Console.WriteLine(_listQuestions[number2]);
            Spinner(3);
        }
        
        Console.WriteLine();
        EndActivity(base.GetActivityTime(), _activityName);
    }
}
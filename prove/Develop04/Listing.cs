using System.Collections.Generic;
public class Listing : Activity //DONE
{
    private string _activityName, _activityDescription;
    private List<string> _listPrompt;

    public Listing()
    {
        _activityDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _activityName = "Listing Activity";
        _listPrompt = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?",
            "Who are the individuals that have impacted your life in a positive way?",
            "What are some qualities that you possess that make you proud of yourself?",
            "In what instances have you felt a strong sense of spiritual guidance recently?",
            "What are your core values and how do they align with your daily actions?",
            "What are some of the greatest lessons that you have learned from your mistakes, and how have you grown as a result of them?",
            "What are some new skills or habits that you have developed recently, and how have they impacted your life?",
            "What are some things that you want to accomplish in the future, and what steps can you take to achieve them?",
            "What are some things that bring you joy and fulfillment, and how can you incorporate them more regularly into your routine?"
                    
        };
        
    }

    public string LGetActivityName()
    {
        return _activityName;
    }

    public void LSetActivityName(string name)
    {
        _activityName = name;
    }

    public string LGetActivityDescription()
    {
        return _activityDescription;
    }

    public void LSetActivityDescription(string description)
    {
        _activityDescription = description;
    }

    public List<string> LGetList()
    {
        return _listPrompt;
    }

    public void LSetList(List<string> list)
    {
        _listPrompt = list;
    }

    public void ListingActivity() //DONE
    {
        base.BeginActivity(_activityName, _activityDescription);

        //Reflecting activity
        Console.WriteLine();

        Console.WriteLine("List as many responses you can to the following prompt:");

        
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, 12);
        Console.WriteLine($"---{_listPrompt[number]}---");
        Console.WriteLine("You may begin in:");
        CountDown(10);
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(base.GetActivityTime());

        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            currentTime = DateTime.Now;
        }
        
        Console.WriteLine();
        EndActivity(base.GetActivityTime(), _activityName);
    }
}
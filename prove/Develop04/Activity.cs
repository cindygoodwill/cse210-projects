public class Activity // DONE
{
    private int _activityTime;
    private string _activityName, _activityDescription;

    public Activity()
    {

    }

    public int GetActivityTime() //DONE
    {
        return _activityTime;
    }

    public void SetActivityTime(int time) //DONE
    {
        _activityTime = time;
    }

    public string GetActivityName() //DONE
    {
        return _activityName;
    }

    public void SetActivityName(string name) //DONE
    {
        _activityName = name;
    }

    public string GetActivityDescription() //DONE
    {
        return _activityDescription;
    }

    public void SetActivityDescription(string description) //DONE
    {
        _activityDescription = description;
    }

    public void BeginActivity(string title, string description) //DONE
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {title}.");
        Console.WriteLine();
        Console.WriteLine(description);
        Console.WriteLine();
        EnterTime();
        
        Console.Clear();
        Console.WriteLine("Get ready...");
        Spinner(2);
        Console.WriteLine();
    }

    public void EnterTime() // DONE
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        string seconds = Console.ReadLine();
        int number = int.Parse(seconds);
        _activityTime = number;  
    }
    
    public void EndActivity(int time, string name)  //DONE
    {
        Console.WriteLine("Well done!!");
        Console.WriteLine();
        Console.WriteLine($"You have completed another {time} seconds of the {name}.");
        Spinner(3);
    }

    public void Spinner(int second) //DONE
    {
        for (int i = 0; i < second * 2; i++)
        {
            Console.Write("+");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b\b \b");

        }
    }

    public void CountDown(int second) //DONE
    {
        for (int i = 0; i < second; i++)
        {
            
            string count = (second - i).ToString();
            Console.Write(count);
            Console.Write(new string(' ', count.Length));
            Console.Write("\r");
            Thread.Sleep(1000);
        }
        
        Console.WriteLine("\b0");

    }
}
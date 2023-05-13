public class Breathing : Activity //DONE
{
    private string _activityName, _activityDescription;

    public Breathing() //DONE
    {
        _activityDescription = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        _activityName = "Breathing Activity";
    }

    public string BGetActivityName() //DONE
    {
        return _activityName;
    }

    public void BSetActivityName(string name)//DONE
    {
        _activityName = name;
    }

    public string BGetActivityDescription()//DONE
    {
        return _activityDescription;
    }

    public void BSetActivityDescription(string description)//DONE
    {
        _activityDescription = description;
    }

    public void BreathingActivity()//DONE
    {
        base.BeginActivity(_activityName, _activityDescription);

        //Breathing activity
        Console.WriteLine();

        for (int i = 0; i < base.GetActivityTime() / 15; i++)
        {
            Console.WriteLine("Breathe in...");
            base.CountDown(5);
            Console.WriteLine("Breathe out...");
            base.CountDown(8);
            Console.WriteLine();
        }
        
        EndActivity(base.GetActivityTime(), _activityName);
    }
}
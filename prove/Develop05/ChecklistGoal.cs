public class ChecklistGoal : Goal
{
    // Attributes
    private int _pointsBonus;
    private int _timesToBonus;
    private int _tracker;
    
    // Constructor
    public ChecklistGoal(string name, string description, int points, string type, int bonusPoints, int timeToBonus, int tracker = -1, bool complete = false) : base(name, description, points, type, complete)
    {
        _pointsBonus = bonusPoints;
        _timesToBonus = timeToBonus;
        if (tracker == -1)
        {
            _tracker = timeToBonus;
        }
        else
        {
            _tracker = tracker;
        }
            
    }

    // Getters and Setters
    public int GetBonusPoints()
    {
        return _pointsBonus;
    }

    public void SetBonusPoints(int points)
    {
        _pointsBonus = points;
    }

    public int GetTimesToBonus()
    {
        return _timesToBonus;
    }

    public void SetTimesToBonus(int times)
    {
        _timesToBonus = times;
    }

    public int GetTracker()
    {
        return _tracker;
    }

    public void SetTracker(int tracker)
    {
        _tracker = tracker;
    }

    // Methods
    public override void SetupGoal()
    {
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        SetName(name);
        
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        SetDescription(description);
        
        Console.Write("What is the amount of points associated with this goal? ");
        string points = Console.ReadLine();
        int numberPoints = int.Parse(points);
        SetPoints(numberPoints);

        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        string time = Console.ReadLine();
        int numberTime = int.Parse(time);
        _timesToBonus = numberTime;

        Console.Write("What is the bonus for accomplishing it that many times? ");
        string bonus = Console.ReadLine();
        int numberBonus = int.Parse(bonus);
        _pointsBonus = numberBonus;

        SetGoalType("checklist");
    }

    public override string GetEntryAsString()
    {
        string name = GetName();
        string description = GetDescription();
        int points = GetPoints();
        string type = GetGoalType();
        bool complete = GetIsComplete();

        return string.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}", name, description, points, type, complete, _pointsBonus, _timesToBonus, _tracker);
    }

    public void TickGoal()
    {
        _tracker = _tracker + 1;
    }

    
}
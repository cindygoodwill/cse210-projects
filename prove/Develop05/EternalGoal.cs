public class EternalGoal : Goal
{
    // Constructor
    public EternalGoal(string name, string description, int points, string type, bool complete = false) : base(name, description, points, type, complete)
    {

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

        SetGoalType("eternal");
    }

    public override string GetEntryAsString()
    {
        string name = GetName();
        string description = GetDescription();
        int points = GetPoints();
        string type = GetGoalType();
        bool complete = GetIsComplete();

        return string.Format("{0}|{1}|{2}|{3}|{4}", name, description, points, type, complete);
    }
}
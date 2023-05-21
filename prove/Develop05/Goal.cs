public abstract class Goal
{
    private string _goalName, _description, _goalType;
    private int _points;
    private bool _isComplete;

    // Constructor
    public Goal(string name, string description, int points, string type, bool complete = false)
    {
        _goalName = name;
        _description = description;
        _points = points;
        _goalType = type;
        _isComplete = complete;
    }

    // Getters and Setters
    public string GetName()
    {
        return _goalName;
    }

    public void SetName(string name)
    {
        _goalName = name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public int GetPoints()
    {
        return _points;
    }

    public void SetPoints(int points)
    {
        _points = points;
    }

    public string GetGoalType()
    {
        return _goalType;
    }

    public void SetGoalType(string type)
    {
        _goalType = type;
    }

    public bool GetIsComplete()
    {
        return _isComplete;
    }

    public void SetIsComplete(bool complete)
    {
        _isComplete = complete;
    }

    // Methods
    public abstract void SetupGoal();
    public abstract string GetEntryAsString();
}
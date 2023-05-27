public abstract class Chore
{
    // Attributes
    private string _choreName, _consequence, _type;
    private int _repeat, _age, _dueDayTime;

    // Constructors
    public Chore()
    {
    }


    // Getters and Setters
    public void SetChoreName(string name)
    {
        _choreName = name;
    }
    public string GetChoreName()
    {
        return _choreName;
    }
    public void SetChoreConsequence(string cons)
    {
        _consequence = cons;
    }
    public string GetChoreConsequence()
    {
        return _consequence;
    }
    public void SetChoreType(string type)
    {
        _type = type;
    }
    public string GetChoreType()
    {
        return _type;
    }
    public void SetDueDayTime(int due)
    {
        _dueDayTime = due;
    }
    public int GetDueDayTime()
    {
        return _dueDayTime;
    }
    public void SetRepeat(int repeat)
    {
        _repeat = repeat;
    }
    public int GetRepeat()
    {
        return _repeat;
    }
    public void SetAge(int age)
    {
        _age = age;
    }
    public int GetAge()
    {
        return _age;
    }
    

    // Methods
    public string GetChoreAsString()
    {
        string chore = $"{_choreName}|{_consequence}|{_type}|{_repeat}|{_age}|{_dueDayTime}";
        return chore;
    }
    public abstract void PickChore();
    public abstract void RecordEvent();
}
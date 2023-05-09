public class Assignment
{
    private string _studentName;
    private string _topic;

    public Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }

    public string GetName()
    {
        return _studentName;
    }

    public string GetSummary()
    {
        return $"Name: {_studentName} | Topic: {_topic}";
    }
}
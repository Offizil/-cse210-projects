// Assignment.cs

public class Assignment
{
    protected String _studentName;
    protected string _topic;

    public Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }



    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

}

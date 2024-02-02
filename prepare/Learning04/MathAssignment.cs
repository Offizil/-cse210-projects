// MathAssignment

public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string textSection, string probs, string name, string topic) : base(name, topic)
    {
        _problems = probs;
        _textbookSection = textSection;
    }

    public string GetHomeworkList()
    {
        return $"{_textbookSection} - {_problems}";
    }
    
}
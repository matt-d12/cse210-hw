using System;

public class MathAssignment : Assignment
{
    //Establish attributes
    private string _textbookSection;
    private string _problems;

    //Constructor method
    public MathAssignment(string studentName, string topic, string textbookSection,
        string problems) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    //Method for creating and getting homework list (not actual list, list of strings)
    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}
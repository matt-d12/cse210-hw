using System;

public class Comment
{
    //Establish attributes
    private string _commenterName;
    private string _text;

    //Constructor
    public Comment(string commenterName, string text)
    {
        _commenterName = commenterName;
        _text = text;
    }

}
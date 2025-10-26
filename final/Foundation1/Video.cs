using System;

public class Video
{
    //Establish attributes
    private string _title;
    private string _author;
    private int _length;
    private List<Comment>;

    //Initialize new comment list
    _comments = new List<Comment>();

    //Constructor
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

}
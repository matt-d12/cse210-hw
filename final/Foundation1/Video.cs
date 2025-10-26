using System;

public class Video
{
    //Establish attributes
    private string _title;
    private string _author;
    private int _length;
    //Initialize new comment list
    private List<Comment> _comments = new List<Comment>();

    //Constructor
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    //Method to add new comments to list
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    //Method for getting comment count
    public int GetCommentCount()
    {
        return _comments.Count;
    }

    //Method to display all video info
    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Comment Count: {GetCommentCount()}");
    }

}
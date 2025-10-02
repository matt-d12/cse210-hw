using System;
using System.Runtime.CompilerServices;

public class Reference
{
    //Establish attributes
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    //Constructor method for single verse scripture
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
    }

    //Constructor method for multi-verse scripture
    public Reference(string book, int chapter, int verseStart, int verseEnd)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verseStart;
        _endVerse = verseEnd;
    }

    //Method for displaying full scripture reference as string
    public string DisplayReference()
    {
        return $"{_book} {_chapter}:{_startVerse}";
    }

}
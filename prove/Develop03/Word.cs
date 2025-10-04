using System;

public class Word
{
    //Establish attributes
    private string _text;
    private bool _isHidden;

    //Constructor to initialize
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    //Method for hiding a word
    public void Hide()
    {
        _isHidden = true;
    }

    //Method for marking a word as being hidden
    public bool IsHidden()
    {
        return _isHidden;
    }

    //Method for displaying or hiding a word
    public string DisplayText()
    {
        //If word is marked as hidden then replace with underscores
        if (_isHidden)
        {
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }
}
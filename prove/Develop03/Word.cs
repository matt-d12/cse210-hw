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

    //Method for telling if a word is hidden
    public void Hide()
    {
        _isHidden = true;
    }

    //Method for telling if a word is not hidden
    //(to use later to not hide same random word(s) over and over)
    public void Show()
    {
        _isHidden = false;
    }

    //Method for displaying a word and if it is hidden, then replace with underscores
    public string DisplayText()
    {
        //... unsure yet
        //loop for replacing letters with _ for words marked hidden
        return "test";
    }
}
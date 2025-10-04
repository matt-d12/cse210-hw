using System;
using System.ComponentModel.DataAnnotations;

public class Scripture
{
    //Establish attributes
    private Reference _reference;
    private List<Word> _words;
    private Random _random;

    //Constructor for putting reference and scripture together as one string
    public Scripture(Reference reference, string scriptureText)
    {
        _reference = reference;
        _words = new List<Word>();
        _random = new Random();

        //Split scripture text on spaces
        string[] parts = scriptureText.Split(" ");
        //Loop to add to list so we can index words and hide later
        foreach (string part in parts)
        {
            _words.Add(new Word(part));
        }
    }

    //Method to display full scripture
    public string DisplayScripture()
    {
        string scriptureText = "";
        foreach (Word word in _words)
        {
            scriptureText += word.DisplayText() + " ";
        }

        return $"{_reference.DisplayReference()} {scriptureText.Trim()}";
    }

    //Method for hiding random words
    public void HideRandomWords()
    {
        //Make list of words that are NOT hidden
        List<Word> visibleWords = new List<Word>();
        //Loop through words and if not hidden, add to list
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                visibleWords.Add(word);
            }
        }

        //Decide how many visible words to hide (doing up to 3)
        int wordsToHide = 3;
        if (visibleWords.Count < 3)
        {
            wordsToHide = visibleWords.Count;
        }

        //Loop through and hide that many words then remove from list
        for (int i = 0; i < wordsToHide; i++)
        {
            //Pick random visible word
            int randomWord = _random.Next(visibleWords.Count);
            //Change word to hidden
            visibleWords[randomWord].Hide();
            //Remove from visible list
            visibleWords.RemoveAt(randomWord); 
        }
    }

    //Method for knowing if all words are hidden as we'll quit if so
    public bool AllHidden()
    {
        //Loop through each word and check if any word is NOT hidden
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        //Return true once all are hidden
        return true;
    }


}
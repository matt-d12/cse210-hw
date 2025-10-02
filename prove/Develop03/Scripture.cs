using System;
using System.ComponentModel.DataAnnotations;

public class Scripture
{
    //Establish attributes
    private Reference _reference;
    private List<Word> _words;
    private Random _random;

    //Method to display full scripture
    public string DisplayScripture()
    {
        return $"{_reference}: {_words}";
    }

    //Constructor for putting reference and scripture together as one string
    public Scripture(Reference reference, string scriptureText)
    {
        _reference = reference;
        _words = new List<Word>();
        _random = new Random();

        //Maybe split full scripture based on spaces to then add to word list?
    }




}
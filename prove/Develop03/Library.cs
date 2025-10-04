using System;
using System.Collections.Generic;

public class Library
{
    //Establish attributes
    private List<Scripture> _scriptures;
    private Random _random;

    //Constructor method for new list and get random scripture from it
    public Library()
    {
        _scriptures = new List<Scripture>();
        _random = new Random();
        LoadScriptures();
    }

    //Method to add scriptures to the library
    private void LoadScriptures()
    {
        _scriptures.Add(new Scripture(new Reference("John", 3, 16),
        "For God so loved the world that he gave his only begotten Son, " +
        "that whosoever believeth in him should not perish, but have everlasting life."
        ));

        _scriptures.Add(new Scripture(new Reference("Proverbs", 3, 5, 6),
        "Trust in the Lord with all thine heart; and lean not unto thine own understanding." +
        "In all thy ways acknowledge him, and he shall direct thy paths."
        ));

        _scriptures.Add(new Scripture(new Reference("2nd Nephi", 2, 25),
        "Adam fell that men might be; and men are, that they might have joy."
        ));

        _scriptures.Add(new Scripture(new Reference("Romans", 1, 16),
        "For I am not ashamed of the gospel of Christ: for it is the power of God " +
        "unto salvation to every one that believeth; to the Jew first, and also the Greek."
        ));

        _scriptures.Add(new Scripture(new Reference("Alma", 37, 6, 7),
        "Now ye may suppose that this is foolishness in me; but behold I say unto you, " +
        "that by small and simple things are great things brought to pass; and small " +
        "means in many instances doth confound the wise. " +
        "And the Lord God doth work by means to bring about his great and eternal " +
        "purposes; and by very small means the Lord doth confound the wise and bringeth " +
        "about the salvation of many souls."
        ));
    }

    //Method to return a random scripture from above
    public Scripture GetRandomScripture()
    {
        int index = _random.Next(_scriptures.Count);
        return _scriptures[index];
    }
}
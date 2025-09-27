using System;
using System.IO;
using System.Collections.Generic;

public class Journal
{
    //Establish attributes - get current date
    string currentDate = DateTime.Now.ToShortDateString();
    //Initialize list of prompts
    public List<string> _prompts;
    //Initialize list of journal entries
    public List<Entry> _entries;

    public Journal()
    {
        //Initialize journal with entries & prompts
        _entries = new List<Entry>();
        _prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

    }

    //Method for getting random prompt from list
    public string GetRandomPrompt()
    {
        //Get random number based on count of list (_prompts) entries
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];     //Return that random prompts index number
    }


    //Method for option 1 to make a new entry
    public void AddNewEntry()
    {
        //Get random prompt and prompt user for response
        string randomPrompt = GetRandomPrompt();
        Console.WriteLine($"Prompt: {randomPrompt}");
        Console.Write("> ");
        string userResponse = Console.ReadLine();

        //Make new entry and add to entries list
        Entry newEntry = new Entry(randomPrompt, currentDate, userResponse);
        _entries.Add(newEntry);
    }

    //Method for option 2 to display all entries
    public void DisplayEntries()
    {
        {
            //Loop through each entry using method from Entry.cs
            foreach (Entry entry in _entries)
            {
                entry.DisplayEntry();
                Console.WriteLine();
            }
        }
    }

    //Method for option 3 to load journal.txt file
    public void LoadFromFile()
    {
        string loadFile = "journal.txt";
        string[] lines = System.IO.File.ReadAllLines(loadFile);

        //Loop through each line and split into parts
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            string prompt = parts[0];
            string date = parts[1];
            string response = parts[2];
            //Create entries from these parts and add
            Entry loadedEntry = new Entry(prompt, date, response);
            _entries.Add(loadedEntry);
        }

    }


    //Method for option 4 to save to text file
    public void SaveToFile()
    {
        string fileName = "journal.txt";
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            //Use the string format method from Entry class when saving
            foreach (Entry e in _entries)
            {
                outputFile.WriteLine(e.StringEntry());
            }
        }
    }
}
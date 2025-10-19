using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

//Not sub class - class to manage the goal creation and interractions
public class GoalManager
{
    //Establish attributes
    private List<Goal> _goals;
    private int _score;

    //Constructor method
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    //Method for user prompts when creating a goal
    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        //Ask user for which goal to create and store as the choice
        Console.Write("Which type of goal would you like to create? ");
        string choice = Console.ReadLine();

        //Ask user for name and store
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        //Ask user for description and store
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        //Ask user for points and store as an int
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        //If to check which they selected and create new entry for the list
        if (choice == "1")
        {
            SimpleGoal goal = new SimpleGoal(name, description, points, false);
            _goals.Add(goal);
        }
        else if (choice == "2")
        {
            EternalGoal goal = new EternalGoal(name, description, points);
            _goals.Add(goal);
        }
        else if (choice == "3")
        {
            //Extra questions as need the total count and bonus points
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int totalCount = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonusPoints = int.Parse(Console.ReadLine());

            ChecklistGoal goal = new ChecklistGoal(name, description, points, bonusPoints, totalCount);
            _goals.Add(goal);
        }
    }

    //Method for listing out all goals
    public void ListGoals()
    {
        Console.WriteLine("The goals are:");
        int index = 1;
        //Loop to display all goals from list
        foreach (Goal goal in _goals)
        {
            string checkbox;
            //Check if goal should be marked complete or not
            if (goal.IsComplete())
            {
                checkbox = "[X]";
            }
            else
            {
                checkbox = "[ ]";
            }
            Console.WriteLine($"{index}. {checkbox} {goal.GetInfo()}");
            index++;
        }
    }

    //Method to get score
    public int GetScore()
    {
        return _score;
    }

    //Method for recording an event (marking complete or marking a checklist completion)
    public void RecordEvent()
    {
        //List out goals and get user input on which to choose
        ListGoals();
        Console.Write("Which goal did you accomplish? ");
        int choiceGoal = int.Parse(Console.ReadLine()) - 1;

        Goal goal = _goals[choiceGoal];

        //Check if goal has already been completed
        if (goal.IsComplete())
        {
            Console.WriteLine("This goal is already completed");
            return;
        }

        //Record event and add points to score
        goal.RecordEvent();
        int pointsEarned = goal.GetPoints();
        _score += pointsEarned;
        int totalEarned = pointsEarned;

        //Add bonus points if it was checklist goal being completed
        if (goal is ChecklistGoal checklist && checklist.IsComplete())
        {
            int bonus = checklist.GetBonusPoints();
            _score += bonus;
            totalEarned += bonus;
        }

        //Display added points to user
        Console.WriteLine($"Congratulations! You have earned {totalEarned} points!");
    }

    //Method for saving file
    public void SaveGoals()
    {
        //Ask user for filename to save to 
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            //Save point total
            outputFile.WriteLine(_score);
            //Loop through each goal and save 
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine();
    }
    
    //Method for loading file
    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();

        if (File.Exists(fileName))
        {
            string[] lines = File.ReadAllLines(fileName);
            
            //Set line 1 to the score in each and clear out current goals list
            _score = int.Parse(lines[0]);
            _goals.Clear();
            
            //Loop through entries and split on | 
            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] parts = line.Split("|");
                string goalType = parts[0];

                //Check if simple goal and split accordingly
                if (goalType == "SimpleGoal")
                {
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);
                    bool isComplete = bool.Parse(parts[4]);

                    SimpleGoal goal = new SimpleGoal(name, description, points, isComplete);
                    _goals.Add(goal);
                }
                //Check if eternal goal and split accordingly
                else if (goalType == "EternalGoal")
                {
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);

                    EternalGoal goal = new EternalGoal(name, description, points);
                    _goals.Add(goal);
                }
                //Check if checklist goal and split accordingly
                else if (goalType == "ChecklistGoal")
                {
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);
                    int bonusPoints = int.Parse(parts[4]);
                    int totalCount = int.Parse(parts[5]);
                    int completedCount = int.Parse(parts[6]);

                    ChecklistGoal goal = new ChecklistGoal(name, description, points, bonusPoints, totalCount, completedCount);
                    _goals.Add(goal);
                }
            }
            Console.WriteLine("Goals loaded");
        }
        else
        {
            Console.WriteLine("File not found");
        }
    }
}
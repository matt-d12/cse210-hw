using System;
using System.Security.AccessControl;

//Not sub class - class to manage the goal creation and interractions
public class GoalManager
{
    //Establish attributes
    private List<Goal> _goals;
    private int _score;
    private string _fileName;

    //Constructor method
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
        _fileName = "goals.txt";
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
        Console.WriteLine("What is a short description of it? ");
        string description = Console.ReadLine();

        //Ask user for points and store as an int
        Console.WriteLine("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        //If to check which they selected and create new entry for the list
        if (choice == "1")
        {
            SimpleGoal goal = new SimpleGoal(name, description, points);
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

        //Display added points to user
        Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
        Console.WriteLine($"You have {_score} points.");
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

    







}
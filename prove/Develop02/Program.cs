using System;
using System.IO;
using System.Collections.Generic;

//Be sure to add comment for exceeding requirements

class Program
{
    static void Main(string[] args)
    {
        //Establish attributes
        bool running = true;
        //Instance Journal and Prompts
        Journal journal = new Journal();

        //Loop to start program and keep going until user uses option 5
        while (running == true)
        {
            //Menu display and get user input for menu option
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                //Option 1 for writing new entry
                journal.AddNewEntry();
            }
            else if (userInput == "2")
            {
                //Option 2 for displaying journal
                journal.DisplayEntries();
            }
            else if (userInput == "3")
            {
                //Option 3 for loading journal
                journal.LoadFromFile();
            }
            else if (userInput == "4")
            {
                //Option 4 for saving journal
                journal.SaveToFile();
            }
            else if (userInput == "5")
            {
                //Option 5 for quitting program
                running = false;
            }
            else    //Else to handle invalid inputs
            {
                Console.WriteLine();
                Console.WriteLine("Invalid input. Please enter a number of 1-5");
                Console.WriteLine();
            }
        }
    }
}
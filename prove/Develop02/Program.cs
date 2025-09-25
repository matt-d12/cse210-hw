using System;

//Be sure to add comment for exceeding requirements

class Program
{
    static void Main(string[] args)
    {
        //Establish attributes
        string userInput = "0";


        //Loop to start program and keep going until user uses option 5

        //Menu display
        static void UserMenu()
        {
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
        }

        //Prompt user for input and execute menu controls
        static void UserPrompt()
        {
            Console.Write("What would you like to do? ");
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                //Option 1 for writing new entry
            }
            else if (userInput == "2")
            {
                //Option 2 for displaying journal
            }
            else if (userInput == "3")
            {
                //Option 3 for loading journal
            }
            else if (userInput == "4")
            {
                //Option 4 for saving journal
            }
            else if (userInput == "5")
            {
                //Option 5 for quitting program
            }
        }
    }
}
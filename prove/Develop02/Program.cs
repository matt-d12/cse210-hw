using System;

//Be sure to add comment for exceeding requirements

class Program
{
    static void Main(string[] args)
    {
        //Establish attributes
        bool running = true;
        //Instance Journal and Prompts
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        //Loop to start program and keep going until user uses option 5
        while (running == true)
        {
            //Menu display and get user input for menu option
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
                string randomPrompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"Prompt: {randomPrompt}");
                Console.Write("> ");
                string _response = Console.ReadLine();
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
                running = false;
            }
        }
    }
}
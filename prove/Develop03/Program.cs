using System;

//ADD CREATIVITY STUFF HERE

class Program
{
    static void Main(string[] args)
    {
        //Get list of scriptures from library and choose random one
        Library library = new Library();
        Scripture scripture = library.GetRandomScripture();

        //Loop to display scripture until all words hidden or user types quit
        while (true)
        {
            //Clear console for cleaner look and re-display scripture
            Console.Clear();
            Console.WriteLine(scripture.DisplayScripture());

            //Get user input
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine();

            //If user hits enter then run method to hide 3 (more) random words
            if (input == "")
            {
                scripture.HideRandomWords(3);
            }
            else if (input == "quit")
            {
                break;
            }
        }
    }
}
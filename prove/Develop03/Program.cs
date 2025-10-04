using System;

//ADD CREATIVITY STUFF HERE

class Program
{
    static void Main(string[] args)
    {
        //Get list of scriptures from library and choose random one
        Library library = new Library();
        Scripture scripture = library.GetRandomScripture();

        //Display scripture
        Console.WriteLine(scripture.DisplayScripture());
    }
}
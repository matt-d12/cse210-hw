using System;

class Program
{
    static void Main(string[] args)
    {
        //Create initial list & declare variable(s)
        List<int> numbers = new List<int>();
        int number = -1;
        int sum = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        while (number != 0)
        {
            //Get numbers from user and convert
            Console.Write("Enter number: ");
            string textNumber = Console.ReadLine();
            number = int.Parse(textNumber);
            
            //Add number to list and to sum
            numbers.Add(number);
            sum = sum + number;
        } 

        Console.WriteLine($"The sum is: {sum}");

        /* //Loop to check list is working as intended
        for (int i= 0; i < numbers.Count; i++)
        {
            Console.WriteLine(numbers[i]);
        }
        */
    }
}
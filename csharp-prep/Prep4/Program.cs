using System;

class Program
{
    static void Main(string[] args)
    {
        //Create initial list & declare variables
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
            
            //Add number to list and to sum unless 0 to avoid count issues for average
            if (number != 0)
            {
                numbers.Add(number);
                sum = sum + number;
            }
        } 

        //Calculate average
        float average = (float)sum / numbers.Count;

        //Find largest & smallest number that are positives
        int largest = numbers.Max();
        int smallest = numbers.Where(n => n > 0).Min();

        //Display results
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest positive number is: {smallest}");

        //Order list from smallest to largest
        numbers.Sort();

        //Loop through sorted list and output
        for (int i= 0; i < numbers.Count; i++)
        {
            Console.WriteLine(numbers[i]);
        }
        
    }
}
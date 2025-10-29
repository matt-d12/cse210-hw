using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Create new list to store activity entries
        List<Activity> activities = new List<Activity>
        {
            new Running("28 Oct 2025", 10, 1.5),
            new Cycling("27 Oct 2025", 15, 2.0),
            new Swimming("26 Oct 2025", 20, 5)
        };

        //Loop through list and display summary
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        //Create new job instance
        Job job1 = new Job();
        Job job2 = new Job();
        job1._jobTitle = "Software Engineer";
        job2._jobTitle = "IT Tech";

        //Output
        Console.WriteLine(job1._jobTitle);
        Console.WriteLine(job2._jobTitle);
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        //Create new job instance
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        //Second job instance
        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        //Output
        job1.Display();
        job2.Display();

        //Resume instance
        Resume listResume = new Resume();
        //Add jobs to Resume
        listResume._jobs.Add(job1);
        listResume._jobs.Add(job2);

        //Resume Output
        Console.WriteLine($"{listResume._jobs[0]._jobTitle}");
        Console.WriteLine($"{listResume._jobs[1]._jobTitle}");
    }
}
using System;
public class Resume
{
    //Establish attributes
    public string _name;

    //Initialize list
    public List<Job> _jobs = new List<Job>();

    //Display resume
    public void ResumeDisplay()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Jobs:");

        //Loop through each job user has had
        foreach (Job job in _jobs)
        {
            job.Display();   //Ref to Job.cs Display method
        }
    }
}
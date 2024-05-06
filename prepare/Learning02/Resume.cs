using System;

public class Resume
{
    private string _name;
    private List<Job> _jobs;

    public Resume(string name)
    {
        _name = name;
        _jobs = new List<Job>();
    }

    public void AddJob(Job job)
    {
        _jobs.Add(job);
    }

    public void Display()
    {   
        Console.WriteLine($"\nName: {_name}");
        Console.WriteLine("Jobs:");

        
        foreach (var job in _jobs)
        {
            job.Display();
        }
    }
}
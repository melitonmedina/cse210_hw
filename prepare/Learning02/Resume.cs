using System;

// Beginnig of the resume class
public class Resume()
{
    public string _name = "Jhon R.";
    public List<Job> _jobs = new List<Job>();

    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name}");
        foreach (Job job in _jobs)
        {
            job.DisplayJob();
        }

        // a for loop to accomplish the above task

        //for (int i = 0; i < _jobs.Count; i++)
        //{
            //_jobs[i].DisplayJob();

        //}
    }



}

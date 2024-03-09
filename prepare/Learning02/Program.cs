using System;

class Program
{
    static void Main(string[] args)
    {
        //job 1
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTile = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2024;

        //Console.WriteLine(job1._company);

        //job2
        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTile = "Software Manager";
        job2._startYear = 2020;
        job2._endYear = 2022;
        
        //Console.WriteLine(job2._company);

        // calling the Job display method (member function)
        //job1.DisplayJob();
        //job2.DisplayJob();

        // Resume class
        Resume myResume = new Resume();
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayResume();



    }
}
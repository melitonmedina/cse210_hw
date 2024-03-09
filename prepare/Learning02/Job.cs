using System;
// This the public class Job
public class Job
{
   public string _company = "";
   public string _jobTile = "";
   public int _startYear;
   public int _endYear;


   //public Job()
   //{

   //}
   // Behaviors use methods
   public void DisplayJob()
   {
    Console.WriteLine($"{_jobTile} ({_company}) {_startYear}-{_endYear}");
   }


}
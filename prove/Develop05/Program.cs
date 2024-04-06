// There is an implementation for leveling up based on total points
// The record event function does not error out when no goals have been saved
// Code prevents the duplication of current goals by opting for "Load goals" consecutively
using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
        Console.WriteLine("Thanks for visiting the Goal Management App!");
    }
}
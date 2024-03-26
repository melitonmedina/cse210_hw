using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assign1 = new Assignment("Mel", "Calc");
        Console.WriteLine(assign1.GetSummary());

        MathAssignment assign2 = new MathAssignment ("John Good", "Equations", "Section 12.3", "Problems 234 - 239");
        Console.WriteLine(assign2.GetSummary());
        Console.WriteLine(assign2.GetHomeworkList());

        WritingAssignment assign3 = new WritingAssignment("Nelson P.", "The Holy Temples", "Their Importance in Our Lives" );
        Console.WriteLine(assign3.GetSummary());
        Console.WriteLine(assign3.GetWritingInfo());

    }
}
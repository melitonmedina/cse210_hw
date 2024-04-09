using System;

class Program
{
    static void Main(string[] args)
    {
        Video v1 = new Video("New series: The Remembering Episode 1", "John Carter", "3600");
        v1._comments.Add(new Comment("Frank", "Very inspirational"));
        v1._comments.Add(new Comment("Mary", "Brought a good deal of insight"));
        v1._comments.Add(new Comment("Paul", "I did not want it to be over"));


        Video v2 = new Video("How to Get an A in Programming", "James P.", "1800");
        v2._comments.Add(new Comment("Martha", "This is good information"));
        v2._comments.Add(new Comment("Brian", "Wish I knew this sooner"));
        v2._comments.Add(new Comment("Lois", "I'm very excited for my next programming class"));


        Video v3 = new Video("The New Normal", "Christina Riviera", "600");
        v3._comments.Add(new Comment("Joseph", "I don't see how this could be true"));
        v3._comments.Add(new Comment("Magaret", "There is only a few thing I could agree with"));
        v3._comments.Add(new Comment("Mr. Thomas", "Very insteresting point of view"));
        Console.WriteLine();

        // video 1

        v1.DisplayVideoInfo();
        foreach (Comment cmt in v1._comments)
        {
            cmt.DisplayComment();
        }
        Console.WriteLine();


       // video 2 

        v2.DisplayVideoInfo();
        foreach (Comment cmt in v2._comments)
        {
            cmt.DisplayComment();
        }
        Console.WriteLine();



       // video 3 

        v3.DisplayVideoInfo();
        foreach (Comment cmt in v3._comments)
        {
            cmt.DisplayComment();
        }
        Console.WriteLine();

    }
}
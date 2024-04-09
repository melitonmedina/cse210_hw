public class Video
{
    private string _title = "";
    private string _author = "";
    private string _length = "";

    public List<Comment> _comments = new List<Comment>();

    public Video (string title, string author, string length)
    {
        _title = title;
        _author = author;
        _length = length;
    }


    public int GetNumberComments()
    {
        return _comments.Count;
    }


    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Video title: {_title}\nAuthor: {_author}\nLength: {_length} seconds\nNumber of Comments: {GetNumberComments()}");
    }

}
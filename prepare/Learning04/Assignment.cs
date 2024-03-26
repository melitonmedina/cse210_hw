public class Assignment
{
    private string _studentName;
    private string _topic;

    
    public Assignment() // by creating this empty constructor, there is not need to match the inputs of the constructor below to the the derived class - this is helpful when first writing the code for their classes
    {

    }
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;

    }
    public string GetSummary()
    {
        return ($"{_studentName} - {_topic}");
    }

    public string GetStudentName()
    {
        return _studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }
}
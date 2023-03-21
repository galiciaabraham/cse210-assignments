using System;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public Video(string title, string author, int length, List<Comment> comments)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = comments;
    }

    public int CommentsCount()
    {
    int result = _comments.Count();
    return result;
    }

    public string GetVideo()
    {
        return $"{_title} - {_author}, {_length}, ";
    }

    public void DisplayComments()
    {
        foreach(Comment item in _comments)
        {
            Console.Write(item.GetComment());
            Console.WriteLine(item.GetBody());
        }
    }
}
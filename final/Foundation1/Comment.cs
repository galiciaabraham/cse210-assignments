using System;

public class Comment
{
    private string _date;
    private string _name;
    private string _body;

    public Comment(string date, string name,string body)
    {
        _date = date;
        _name = name;
        _body = body;
    }

    public string GetBody()
    {
        return _body;
    }

    public string GetComment()
    {
        return $"{_date} - {_name} - ";
    }
}

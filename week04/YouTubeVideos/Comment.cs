using System;

public class Comment
{
    public string _personName;
    public string _text;

    public Comment(string name, string text)
    {
        _personName = name; //constructor to set some values
        _text = text;
    }
    public void DisplayComments()
    {
        Console.WriteLine($"{_personName}: {_text}");
    }
}
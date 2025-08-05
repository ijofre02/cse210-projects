using System;
using System.Collections.Generic;

public class Video
{
    private string _title;
    private string _author;
    private int _length; //It should be on secons
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title; //constructor to set some values
        _author = author;
        _length = length;
    }

    // public string GetTitle()  Unnecesary
    // {
    //     return _title;
    // }

    // public void SetTitle(string title)
    // {
    //     _title = title;
    // }
    public int CountComment()
    {
        return _comments.Count;
    }
    public void TrackComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Number of  comments: {CountComment()}");

        foreach (Comment coment in _comments)
        {
            coment.DisplayComments();
        }

        Console.WriteLine();
    }
   

}
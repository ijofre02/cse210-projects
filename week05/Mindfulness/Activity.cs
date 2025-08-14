using System;
using System.Collections.Generic;
public class Activity
{
    private string _nameActivity;
    private string _description;
    private int _duration;

    public Activity()
    {
        _nameActivity = "";
        _description = "";
        _duration = 0;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_nameActivity} Activity");
        Console.WriteLine($"{_description}");
        Console.WriteLine($"How long, in secons, would you like for your session?");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
    }

    public void ShowSpinner(int seconds)
    {
        List<string> spinner = new List<string>()
        {
            "|", "/", "-", "\\", "|", "/", "-", "\\",
        };

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (endTime > DateTime.Now)
        {
            string s = spinner[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;

            if (i >= spinner.Count)
            {
                i = 0;
            }
        }
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Weldone!!");
        ShowSpinner(3);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_nameActivity}");
        ShowSpinner(5);
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    // we need some geters and seters to use in the BreathingActivity
    public string GetName()
    {
        return _nameActivity;
    }
    public void SetName(string name)
    {
        _nameActivity = name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
    public int GetDuration()
    {
        return _duration;
    }

}
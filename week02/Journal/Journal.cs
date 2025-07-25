using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{                             //create now the list
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);  // new in for the list
    }

    public void DisplayAll() //Show the input using Display() metod
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine("");
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}"); // I don't know how to put on a  new line instead of "|"
            }
        }
        Console.WriteLine("Journal saved successfully.");
        Console.WriteLine("");
    }

    public void LoadFromFile(string file)
    {
        if (File.Exists(file))
        {
            _entries.Clear(); // delete actuals entries (It's realy important to don't repeat the entries!)

            string[] lines = File.ReadAllLines(file);
            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    Entry newEntry = new Entry();
                    newEntry._date = parts[0];
                    newEntry._promptText = parts[1];
                    newEntry._entryText = parts[2];

                    _entries.Add(newEntry);
                }
            }
            Console.WriteLine("Journal loaded successfully.");
            Console.WriteLine("");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }

}
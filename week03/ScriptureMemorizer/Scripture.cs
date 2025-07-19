using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    //Contructor
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        // ttps://www.youtube.com/watch?v=3MNbKlAI47o&t=146s
        string[] splitText = text.Split(" ");
        foreach (string word in splitText)
        {
            _words.Add(new Word(word));
        }
    }

    //Metod()
    public void HideRandomWords(int numberToHide)
    {
        Random randomNumber = new Random();
        int hiddenCount = 0;

        while (hiddenCount < numberToHide) 
        {
            int index = randomNumber.Next(_words.Count);
            if (_words[index].IsHidden() == false) //if (_words[index].IsHidden() == false)
            {
                _words[index].Hide();
                hiddenCount = hiddenCount + 1; // or hiddenCount++ is the same
            }
    }
    }

    //Geters and Seters
    public string GetDisplayText()
    {
        string referenceText = _reference.GetDisplayText();
        string wordsText = "";

        foreach (Word word in _words)
        {
            wordsText += word.GetDisplayText() + " ";
        }
        return referenceText + " " + wordsText.Trim();
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                return false;
            }
        }
        return true;
    }
}
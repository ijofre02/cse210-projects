using System;
class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text) //Costructor
    {
        _text = text;
        _isHidden = false; // at beggining
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return new string('_', _text.Length);
        }          // is the same use:
        else      // return _isHidden ? "_____" : _text;
        {
            return _text;
        }

    }
}
using System;
using System.Linq;

class Word
{
    private string _text; 
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public string GetDisplayText()
    {
        return _isHidden ? $"_{new string('_', _text.Length - 1)}" : _text;
    }
}

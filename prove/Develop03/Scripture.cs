using System;
using System.Linq;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int numberToHide)
    {
        var random = new Random();
        var hiddenIndices = new HashSet<int>();

        while (hiddenIndices.Count < numberToHide)
        {
            int index = random.Next(_words.Count);
            hiddenIndices.Add(index);
        }

        foreach (var index in hiddenIndices)
        {
            _words[index].Hide();
        }
    }

    public bool IsCompletelyHidden()
    {
        //return _words.All(word => word.GetDisplayText() == new string('_', word.GetDisplayText().Length));
        return _words.All(word => word.GetDisplayText().All(c => c == '_'));

    }

    public void Display()
    {
        Console.Clear();
        Console.WriteLine(_reference.GetDisplayText());
        foreach (var word in _words)
        {
            Console.Write(word.GetDisplayText() + " ");
        }
        Console.WriteLine();
    }
}
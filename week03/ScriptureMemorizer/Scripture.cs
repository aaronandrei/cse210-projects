using System.Collections.Generic;
using System.Linq;
using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        _random = new Random();

        foreach (string wordText in text.Split(' ', StringSplitOptions.RemoveEmptyEntries))
        {
            _words.Add(new Word(wordText));
        }
    }

    public void HideRandomWords(int count)
    {
        List<Word> availableWords = _words.Where(w => !w.IsHidden() && w.IsLetterOrDigit()).ToList();

        if (availableWords.Count == 0)
        {
            return;
        }

        int wordsToHide = Math.Min(count, availableWords.Count);

        for (int i = 0; i < wordsToHide; i++)
        {
            int indexToHide = _random.Next(0, availableWords.Count);
            availableWords[indexToHide].Hide();
            availableWords.RemoveAt(indexToHide);
        }
    }

    public string GetDisplayText()
    {
        string scriptureText = string.Join(" ", _words.Select(w => w.GetDisplayText()));
        return $"{_reference.GetDisplayText()} {scriptureText}";
    }

    public bool AllWordsHidden()
    {
        return _words.All(w => !w.IsLetterOrDigit() || w.IsHidden());
    }
}
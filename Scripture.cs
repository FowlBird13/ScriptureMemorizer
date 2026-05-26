using System;
using System.IO;

public class Scripture
{
    private List<Word> _GBwords;
    private Reference _GBreference;

    public Scripture()
    {
    }
    public Scripture(Reference reference, List<Word> words)
    {
        SetReference(reference);
        SetWords(words);
    }
    public void SetReference(Reference reference)
    {
        _GBreference = reference;
    }
    public Reference GetReference()
    {
        return _GBreference;
    }
    public void SetWords(List<Word> words)
    {
        _GBwords = words;
    }
    public List<Word> GetWords()
    {
        return _GBwords;
    }
    
    public string ToDisplayFormat()
    {
        string reference = _GBreference.ToDisplayFormat();
        string formattedScirpture = $"{reference}\n";
        foreach(Word rawWord in _GBwords)
        {
            string word = rawWord.ToFormattedString();
            formattedScirpture += word;
        }
        return formattedScirpture;
    }

}
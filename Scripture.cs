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
    public void SetWords(List<Word> words)
    {
        _GBwords = words;
    }
    public Reference GetReference()
    {
        return _GBreference;
    }
    public List<Word> GetWords()
    {
        return _GBwords;
    }

    public string ToDisplayFormat()
    {
        //create a scripture passage that begins with the reference
        string reference = _GBreference.ToDisplayFormat();
        string formattedScirpture = $"{reference}\n";

        foreach(Word rawWord in _GBwords)
        {
            //turn every word class into a string
            string word = rawWord.ToFormattedString();
            //add the string to the passage
            formattedScirpture += word+ " ";
        }
        return formattedScirpture;
    }

}
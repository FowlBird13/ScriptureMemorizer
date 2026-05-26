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

    public void LoadFile(string fileName)
    {
        string[] scriptureList = System.IO.File.ReadAllLines(fileName);
        string rawReference;
        string rawWords;
        foreach(string rawScripture in scriptureList)
        {
            rawReference = rawScripture.Split("|")[0];
            rawWords = rawScripture.Split("|")[1];
        }
    }
    public Reference RawToReference(string rawReference)
    {
        Reference newRef = new Reference(); 
        newRef.SetBook(rawReference.Split(",")[0]);
        newRef.SetChapter(int.Parse(rawReference.Split(",")[1]);
        newRef.SetVerse(int.Parse(rawReference.Split(",")[2]);
        return newRef;
    }
    public List<Word> RawToWords(string rawWords)
    {
        
    }
}
using System;
using System.Collections.Generic;

public class Program
{
    static void Main()
    {
        List<Scripture> currentScriptureList = FileToScriptures("scripture.txt");
        bool playing = true;
        while (playing) {
            
        }
    }

    public static List<Scripture> FileToScriptures(string fileName)
    {
        string[] scriptureList = System.IO.File.ReadAllLines(fileName);
        string rawReference;
        string rawWords;
        List<Scripture> sciptures = new List<Scripture>();
        foreach (string rawScripture in scriptureList)
        {
            rawReference = rawScripture.Split("|")[0];
            rawWords = rawScripture.Split("|")[1];
            Reference reference = RawToReference(rawReference);
            List<Word> words = RawToWords(rawWords);
            sciptures.Add(new Scripture(reference, words));
        }
        return sciptures;
    }

    public static Reference RawToReference(string rawReference)
    {
        Reference newRef = new Reference();
        newRef.SetBook(rawReference.Split(",")[0]);
        newRef.SetChapter(int.Parse(rawReference.Split(",")[1]));
        newRef.SetVerse(int.Parse(rawReference.Split(",")[2]));
        return newRef;
    }

    public static List<Word> RawToWords(string rawWords)
    {
        List<Word> newWords = new List<Word>();

        string[] wordsList = rawWords.Split(" ");
        foreach (string word in wordsList)
        {
            newWords.Add(new Word(word));
        }
        return newWords;
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    static void Main()
    {   
        List<Scripture> currentScriptureList = FileToScriptures("scripture.txt");
        
        bool playing = true;
        while (playing) {
            
            {Console.Clear();
            Console.WriteLine ($"bmpOutput");
            Console.WriteLine ("Are you still playing? Press enter to continue or type quit to quit.");
            string _jbcontinuing = Console.ReadLine.ToLower();
            if (_jbcontinuing == "quit")
             playing = false;
             else playing = true;
            
            
            
        }
    }}
    
/// <summary>
/// Converts a txt file into a list of scriptures
/// </summary>
/// <param name="fileName"></param>
/// <returns></returns>
    public static List<Scripture> FileToScriptures(string fileName)
    {
        string[] scriptureList = System.IO.File.ReadAllLines(fileName);
        string rawReference;
        string rawWords;
        List<Scripture> sciptures = new List<Scripture>();
        foreach (string rawScripture in scriptureList)
        {
            //split the reference and the passage
            rawReference = rawScripture.Split("|")[0];
            rawWords = rawScripture.Split("|")[1];
            //turn the reference string into a reference class and save it 
            Reference reference = RawToReference(rawReference);
            //turn the word string into a word class and save it 
            List<Word> words = RawToWords(rawWords);
            //create a new scripture and add it to the scripture list
            sciptures.Add(new Scripture(reference, words));
        }
        return sciptures;
    }

    public static Reference RawToReference(string rawReference)
    {
        Reference newRef;
        //split the reference attributes and save them in an array
        string[] refAttributes = rawReference.Split(",");
        //createa new reference with the attributes
        newRef = new Reference(refAttributes[0], int.Parse(refAttributes[1]), int.Parse(refAttributes[2]));
        
        //if there's an end verse, set the end verse
        if (refAttributes.Length == 4)
        {
            newRef.SetEndVerse(int.Parse(refAttributes[4]));
        }
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

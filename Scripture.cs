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

    /// <summary>
    /// Increases the number of randomly hidden words within the passage by an integer amount. Returns void.
    /// </summary>
    /// <param name="bmpIncrease"></param>
    public void HideRandomWords(int bmpIncrease)
    {
        List<Word> bmpUnhidden = bmpRemoveHiddenWords(_GBwords);
        
        int i = 0;
        bool bmpListHasItemsFlag = true;
        while (i < bmpIncrease && bmpListHasItemsFlag)
        {
            Random bmpRandNum = new Random(bmpUnhidden.Count);
            int bmpIndex = bmpRandNum.Next();
            bmpUnhidden[bmpIndex].Hide();
            bmpUnhidden = bmpRemoveHiddenWords(bmpUnhidden);
            if (bmpUnhidden.Count == 0)
            {
                bmpListHasItemsFlag = false;
            } else
            {
                i++;
            }
        }
    }

    /// <summary>
    /// Remove all of the hidden Word instances from a list of Word instances. Return the updated list.
    /// </summary>
    /// <param name="bmpRawList"></param>
    /// <returns></returns>
    private List<Word> bmpRemoveHiddenWords(List<Word> bmpRawList)
    {
        List<Word> bmpUnhidden = new List<Word>();
        foreach (Word bmpWord in bmpRawList)
        {
            if (!bmpWord.ToFormattedString().Contains("_"))
            {
                bmpUnhidden.Add(bmpWord);
            }
        }
        return bmpUnhidden;
    }

}
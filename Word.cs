using System;

public class Word
{
    private string _bmpWord;
    private bool _bmpHidden;

    public Word(string bmpNewWord)
    {
        _bmpWord = bmpNewWord;
        _bmpHidden = false;
    }

    public void Hide()
    {
        _bmpHidden = true;
    }

    public void Show()
    {
        _bmpHidden = false;
    }

    public string ToFormattedString()
    {
        string bmpOutput = "";
        if (_bmpHidden)
        {
            foreach(char letter in _bmpWord)
            {
                bmpOutput += "_";
            }
        } else
        {
            bmpOutput = _bmpWord;
        }
        return bmpOutput;
    }

}
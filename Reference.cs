using System;

public class Reference
{
    private string _GBbook;
    private int _GBchapter;
    private int _GBverse;
    private int _GBEndVerse;

    public Reference()
    {
        SetBook("None selected");
        SetChapter(0);
        SetVerse(0);
    }
    public Reference(string book, int chapter, int verse)
    {
        SetBook(book);
        SetChapter(chapter);
        SetVerse(verse);    
    }
    public void SetBook(string book)
    {
        _GBbook = book;
    }
    public void SetChapter(int chapter)
    {
        _GBchapter = chapter;
    }
    public void SetVerse(int verse)
    {
        _GBverse = verse;
    }
    public string GetBook()
    {
        return _GBbook;
    }
    public int GetChapter()
    {
        return _GBchapter;
    }
    public int GetVerse()
    {
        return _GBverse;
    }
    public string ToDisplayFormat()
    {
        return $"{_GBbook} {_GBchapter}:{_GBverse}";
    }
    

}
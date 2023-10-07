
using System;
public class Reference
{
    private string -book;
    private int  -chapter;
    private int -verse;
    private int -endverse;

    public Reference(string book, string chapter, string verse)

    {
        book = book;
        chapter = chapter;
        verse = verse;
    }
    public Reference(string book, string chapter, string verse, string endverse)
    {
        book = book;
        chapter = chapter;
        verse = verse;
        endverse = endverse
    }

    public string GetDisplayText()
    {
        string referenceText = $"{book} {chapter} {verse}";
        return referenceText;
    }
}
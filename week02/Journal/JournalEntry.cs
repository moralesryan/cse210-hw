using System;
using System.Diagnostics.Contracts;
using System.Net.Mime;
public class JournalEntry
{
    public string _journalContent;
    public string _dateCreated;

    public string _prompt;

    public JournalEntry(string prompt, string content)
    {
        _prompt = prompt;
        _journalContent = content;
        _dateCreated = DateTime.Now.ToShortDateString();
    }
    public void Display()
    {
        Console.WriteLine($"Date: {_dateCreated}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Entry: {_journalContent}");
    }

    public string EntryToFile()
    {
        return $"{_dateCreated} | {_prompt} | {_journalContent}";
    }

}
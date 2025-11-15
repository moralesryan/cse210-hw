using System;
using System.Net.Mime;
using System.Security.Cryptography.X509Certificates;

class Scripture
{
    private string _reference;
    private List<Word> _content = new List<Word>();
    
    public Scripture(string reference, string content)
    {
        _reference = reference;

        string[] split = content.Split(" ");
     
       foreach (string w in split)
        {
            _content.Add(new Word(w));
        } 
    }

    public void HideRandomWord()
    {
        Random hiderandom = new Random();
        int index = hiderandom.Next(_content.Count);

        _content[index].ToggleVisibility();
    }

    public string Display()
    {
        string result = _reference;
        
        foreach (Word w in _content)
        {
            result += w.GetDisplay() + " ";
        }

        return result.Trim();
    }
}
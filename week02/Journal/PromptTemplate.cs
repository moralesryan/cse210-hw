using System;
using System.Collections.Generic;

public class PromptTemplate
{
    private List<string> _prompts = new List<string>()
    {
        "What are you grateful for today?",
        "How did you see God's hand in your day",
        "What made you feel loved today?",
        "Something that made you feel that is worth living: ",
        "A moment when you genuily smile",
        "What'd you do differently if you could start your day over?"
    };
    public string GetRandomPrompt()
    {
        Random randomPrompt = new Random();
        int index = randomPrompt.Next(_prompts.Count);
        return _prompts[index];
    }
}
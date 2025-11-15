using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{

    public List<JournalEntry> _entries = new List<JournalEntry>();
    public int _dailyStreakCounter = 0;
    public string _fileLocation;
    public string _dateSaved;
    public string _dateCreated;
    public int _dailyStreak;

    public void AddEntry(JournalEntry entry)
    {
        _entries.Add(entry);
        UpdateDailyStreakCounter();
    }

    public void UpdateDailyStreakCounter()
    {
        if (_entries.Count == 0)
        {
            _dailyStreak = 0;
            return;
        }

        _entries.Sort((a, b) => DateTime.Parse(a._dateCreated).CompareTo(DateTime.Parse(b._dateCreated)));

        if (_entries.Count == 1)
        {
            _dailyStreak = 1;
            return;
        }

        var last = DateTime.Parse(_entries[^1]._dateCreated);
        var secondLast = DateTime.Parse(_entries[^2]._dateCreated);

        int difference = (last - secondLast).Days;
        if (difference == 1)
            _dailyStreak++;
        else if (difference > 1)
            _dailyStreak = 1;
    }
    public void Display()
    {
        if (_dailyStreak == 0)
        {
            Console.WriteLine($"Current Daily Streak: {_dailyStreak} days ");
        }

        else if (_dailyStreak == 1)
        {
            Console.WriteLine($"Current Daily Streak: {_dailyStreak} day ");
        }
        else
        {
            Console.WriteLine($"Current Daily Streak: {_dailyStreak} days ");
        }

        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries yet");
            return;
        }

        foreach (var entry in _entries)
        {
            entry.Display();
        }

    }

    public void Save(string fileLocation)
    {
        using (StreamWriter outputFile = new StreamWriter(fileLocation))
        {
            outputFile.WriteLine($"Streak | {_dailyStreak}");
            foreach (var entry in _entries)
            {
                outputFile.WriteLine(entry.EntryToFile());
            }
        }
        Console.WriteLine("Saved.");
    }

    public void Load(string fileLocation)
    {
        _entries.Clear();

        string[] lines = File.ReadAllLines(fileLocation);
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            for (int i = 0; i <parts.Length; i++)
            {
                parts[i] = parts[i].Trim();
            }
            if (parts[0].Equals("Streak", StringComparison.OrdinalIgnoreCase))
            {
                _dailyStreak = int.Parse(parts[1]);
            }
            else if (parts.Length >= 3)
            {
                JournalEntry entry = new JournalEntry(parts[1], parts[2]);
                entry._dateCreated = parts[0];
                _entries.Add(entry);
            }
        }
        Console.WriteLine("Journal Loaded Successfully.");
    }
}

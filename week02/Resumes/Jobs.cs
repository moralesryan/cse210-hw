using System;
using System.ComponentModel.DataAnnotations;

public class Job
{
    // data members 
    public string _company { get; set; }
    public string _jobTitle { get; set; }
    public int _startYear { get; set; }
    public int _endYear { get; set; }    

    public void Display()
    {
        Console.WriteLine("");
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
        Console.WriteLine("");
    }
}

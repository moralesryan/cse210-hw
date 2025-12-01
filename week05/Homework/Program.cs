using System;
using Microsoft.VisualBasic;

class Person
{
   private string _name;
   private int _yearOfBirth;
   private string _gender;
   public Person(string name, int yearOfBirth, string gender)
    {
        _name = name;
        _yearOfBirth = yearOfBirth;
        _gender = gender;
    }
    public string GetName()
    {
        return _name;
    }
    public int GetYearOfBirth()
    {
        return _yearOfBirth;
    }
    public string GetGender()
    {
        return _gender;
    }
}
class Student : Person
{
    private int _studentID;

    public Student(string name, int yearOfBirth, string gender, int studentID) : base(name, yearOfBirth, gender)
    {
        _studentID = studentID;
    }
    public int GetStudentID()
    {
        return _studentID;
    }
}

class Program
{
    static void Main()
    {
        Student student1 = new Student("Taylor", 2001, "Female", 199912);
        string name = student1.GetName();
        int yearOfBirth = student1.GetYearOfBirth();
        string gender = student1.GetGender();
        int studentID = student1.GetStudentID();
        //display the info

        Console.WriteLine(name);
        Console.WriteLine(yearOfBirth);
        Console.WriteLine(gender);
        Console.WriteLine(studentID);
    }
}
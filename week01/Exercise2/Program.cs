using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What grade did you get?");
        int grade = int.Parse(Console.ReadLine());
        string gradeLetter = "";


        if (grade >= 90)
        {
            gradeLetter = "A";
        }
        else if (grade >= 80)
        {
            gradeLetter = "B";
        }
        else if (grade >= 70)
        {
            gradeLetter = "C";
        }
        else if (grade >= 60)
        {
            gradeLetter = "D";
        }
        else if (grade < 60)
        {
            gradeLetter = "F";
        }

            if (gradeLetter == "A")
                Console.WriteLine($"You have an {gradeLetter} in the class. ");
            else
                Console.WriteLine($"You have a {gradeLetter} in the class. ");

        if (grade >= 70)
            Console.WriteLine("Congratulations! You passed the course!");

        else if (grade < 70)
            Console.WriteLine("Unfortunately, you didn't pass the test, but aye, you can take the course again!");
    }
}
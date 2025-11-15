using System;
using System.Runtime.Versioning;

class Program
{
    static void Main(string[] args)
    {
        string scriptureVerse = "Know ye that ye must come to the knowledge of your fathers, and repent of all your sins and iniquities, and believe in Jesus Christ, that he is the Son of God, and that he was slain by the Jews, and by the power of the Father he hath risen again, whereby he hath gained the victory over the grave; and also in him is the sting of death swallowed up.";
        
        Scripture verse = new Scripture("Mormon 7:5", scriptureVerse);

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Scripture Memorizer Project!\n");
            Console.WriteLine("Instructions:");
            Console.WriteLine("Press 'ENTER' if you want to ");
            Console.WriteLine(verse.Display());
        }
    }
}
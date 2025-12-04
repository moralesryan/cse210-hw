using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("The Mindfulness App");
            Console.WriteLine("     1. Start Breathing Activity");
            Console.WriteLine("     2. Start Reflection Activity");
            Console.WriteLine("     3. Start Listing Activity");
            Console.WriteLine("     4. Start Gratitude Activity");
            Console.WriteLine("     5. Quit");
            Console.WriteLine("Select a choice from the menu: ");

            string choice = Console.ReadLine();
            Console.Clear();

            switch (choice)
            {
                case "1":
                    new BreathingActivity().Run();
                    break;
                case "2":
                    new ReflectionActivity().Run();
                    break;
                case "3":
                    new ListingActivity().Run();
                    break;
                case "4":
                    new GratitudeActivity().Run();
                    break;
                case "5":
                    Console.WriteLine("Thanks for using the Mindfulness App today! Come back soon!");
                    return; 
            }
        }
    }
}
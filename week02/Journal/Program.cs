using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptTemplate prompt = new PromptTemplate();

        int choice = 0;
        while (choice != 5)
        {
            Console.WriteLine("Please select one of the following options: ");
            Console.WriteLine("Just type the number");
            Console.WriteLine("Journal Menu:" );
            Console.WriteLine("1. Write in your journal today ");
            Console.WriteLine("2. Display your journal ");
            Console.WriteLine("3. Save journal ");
            Console.WriteLine("4. Load journal ");
            Console.WriteLine("5. Quit ");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    string promptText = PromptTemplate.GetRandomPrompt();
                    Console.WriteLine($" {promptText}");
                    string content = Console.ReadLine();
                    JournalEntry newEntry = new JournalEntry(prompt, content);
                    journal.AddEntry(newEntry);
                    break;
                
                case 2:
                    Console.WriteLine("Displaying Journal...");
                    Console.WriteLine("Fetching some data...");
                    Console.WriteLine("Loaded.");
                    journal.Display();
                    break;
                
                case 3:
                    Console.WriteLine("Please enter the filename to save it: ");
                    string saveFile = Console.ReadLine();
                    journal.Save(saveFile);
                    break;

                case 4:
                    Console.Write("Please enter the filename to load it: ");
                    string loadFile = Console.ReadLine();
                    journal.Load(loadFile);
                    break;
                
                case 5:
                    Console.WriteLine("Saving files...");
                    Console.WriteLine("Saving personal information...");
                    Console.WriteLine("Exiting...");
                    Console.WriteLine("Goodbye!");
            }
        }   
    }
}
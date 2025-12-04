using System;
using System.Runtime.CompilerServices;
//ListingActivity class inherits properties from Activity class
class ListingActivity : Activity
{
    //made a list to store the prmpts/questions that will be asked
    private List<string> _prompts = new List<string>()
    {
        "What are some of your personal goals?",
        "What Christlike Attributes do you have?",
        "What makes you happy?",
        "Name people you look up to",
        "What are your favorite places?"
    };

    //base to inherit the parameters, acitivityName, description and duration from parent class
    public ListingActivity() : base("Listing Activity!", 
    "In this activity you will get some questions, make a list of your answers to them!", 0) {}

    public void Run()
    {
        //calling the StartActivity method to run the ListingActivity
        StartActivity();

        //setting a random variable
        Random random = new Random();
        Console.WriteLine("Prompt: ");
        //printing a random prompt from the _prompts list - the random.Next(_prompts.Count) chooses a random index/number between 0 and the amount of lines in the list
        Console.WriteLine($"{_prompts[random.Next(_prompts.Count)]}");
        RunAnimation(5);
        Console.WriteLine("Starting in:");
        RunCountDown(5);

        //making a "answers" list to store the inputs
        List<string> answers = new List<string>();
        
        Console.WriteLine("\nPlease start typing your list");
        Console.WriteLine("");
        
        //it adds the _duration to the seconds in real time to make the timer stops accurately
        DateTime end = DateTime.Now.AddSeconds(_duration);

        //for when the real time reaches the (real time + _duration) it should stop running the activity
        while (DateTime.Now < end)
        {
            //print the the input and store it in the input variable and add it to the answers list
            string input = Console.ReadLine();
            answers.Add(input);
        }
        //stop running
        RunAnimation(5);
        EndActivity();
    }
}
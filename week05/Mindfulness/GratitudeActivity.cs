using System;

//GratitudeActivity class inherits properties from Activity class
class GratitudeActivity : Activity
{
    //creating a random variable 
    private Random _random = new Random();
    //making a list named _gratitudePrompts
    private List<string> _gratitudePrompts = new List<string>()
    {
        "What are you grateful for today?",
        "A moment of your day that brought you happiness",
        "Who are you grateful for today?",
        "Who or what made you feel God's love today?"
    };

    //base to inherit the parameters, acitivityName, description and duration from parent class
    public GratitudeActivity() : base("Gratitude Activity",
    "This activity will help you reflect on the blessings you have in your life. Quoting Elder Gary B. Sabin: 'You will never be happier than you are grateful'.", 0){}
    public void Run()
    {
        //run the activity
        StartActivity();
        //gratitude activity instructions
        Console.WriteLine("Find a quiet place");
        RunCountDown(5);
        Console.WriteLine("Prompt: ");
        //printing a random _gratitudePrompt from the _gratitudePrompts list - the random.Next(_gratitudePrompts.Count) chooses a random index/number between 0 and the amount of lines in the list
        Console.WriteLine(_gratitudePrompts[_random.Next(_gratitudePrompts.Count)]);
        Console.WriteLine();
        //animation, yay! :P
        RunAnimation(5);
        Console.WriteLine("\nPlease start typing your list");
        Console.WriteLine("");
        //it adds the _duration to the seconds in real time to make the timer stops accurately
        DateTime end = DateTime.Now.AddSeconds(_duration);
        //for when the real time reaches the (real time + _duration) it should stop running the activity
        while (DateTime.Now < end)
        {
            Console.ReadLine();
        }
        //animation again! + stop running
        RunAnimation(5);
        EndActivity();

    }
}
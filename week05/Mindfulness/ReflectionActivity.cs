using System;
using System.Runtime.CompilerServices;
//ReflectionActivity class inherits properties from Activity class
class ReflectionActivity : Activity
{
    //creating a random variable 

    private Random _random = new Random();
    //making a _prompts list
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you helped someone in need",
        "Think of a time when achieved something really difficult",
        "Think of a time when you were forgiven",
        "Think of a time when you showed genuine care for someone",
        "Think of a memory you would like to run back"
    };

    //making a _questions list
    private List<string> _questions = new List<string>()
    {
        "What made this experience so meaningful?",
        "What did you learn from this experience?",
        "What would you do to have an experience like that one more time?",
        "How can you apply what you learned in the future?"
    };
   
    //base to inherit the parameters, acitivityName, description and duration from parent class
    public ReflectionActivity() : base("Reflecting Activity",
    "This activity will help you ponder on some of your most meaningful experiences and your biggest takeaways from them, take a pause and focus on your mind, body and soul.", 0) {}
    
    public void Run()
    {
        //run the program
        StartActivity();
        //reflection activity instructions
        Console.WriteLine("Find a quiet place...");
        RunAnimation(4);
        Console.Clear();

        Console.WriteLine("Get ready");
        RunAnimation(5);
        Console.Clear();
        Console.WriteLine("Consider the following prompt:");
        //printing a random prompt from the _prompts list - the random.Next(_prompts.Count) chooses a random index/number between 0 and the amount of lines in the list
        Console.WriteLine(_prompts[_random.Next(_prompts.Count)]);

        //program will wait until user is ready to continue
        Console.WriteLine("When you have something in mind, press enter to continue.");
        RunAnimation(5);
        Console.ReadLine();
        Console.Clear();

        //print more instructions + countdown
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience. ");
        Console.WriteLine($"You may begin in:" );
        RunCountDown(5);
        
        //it adds the _duration to the seconds in real time to make the timer stops accurately
        DateTime end = DateTime.Now.AddSeconds(_duration);
        //for when the real time reaches the (real time + _duration) it should stop running the activity
        while (DateTime.Now < end)
        {
            //printing a random question from the _questions list - the random.Next(_questions.Count) chooses a random index/number between 0 and the amount of lines in the list
            Console.WriteLine(_questions[_random.Next(_questions.Count)]);
            RunAnimation(5);
        }

        EndActivity();    
    }


}
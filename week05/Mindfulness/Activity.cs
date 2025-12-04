using System;
//parent class
class Activity
{
    //creating some member variables
    protected string _activityName;
    protected string _description;
    protected int _duration;

    // constructor Activity and it's parameters
    public Activity(string activityName, string description, int duration)
    {
        _activityName = activityName;
        _description = description;
        _duration = duration;
    }
    
    public void StartActivity()
    {
        //basic code, will work as a template to the other activities classes
        Console.Clear();
        Console.WriteLine($"Welcome to {_activityName}.\n");
        Console.WriteLine(_description);
        Console.WriteLine("\nHow long would you like your session to be in seconds? ");
        RunAnimation(5);
        _duration = int.Parse(Console.ReadLine());    
        }

    public void EndActivity()
    {
        //will work as a template to the other activities classes
        Console.Clear();
        Console.WriteLine("Well done! ");
        Console.WriteLine($"You have completed another session of the {_activityName}.");
        RunAnimation(5);
        Console.WriteLine("");
    }

    public void RunAnimation(int seconds)
    {
        //creating the endTime wich is real time + seconds parameter
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        //creating animationStrings list and the spinner lines
        List<string> animationStrings = new List<string>()
        {
            "|",
            "/",
            "-",
            "\\"
        };
        //for when the real time reaches the (real time + _duration) it should stop running the activity
        while (DateTime.Now < endTime)
        {
            //iterating through thte animationStrings list
            foreach (string s in animationStrings)
            {
                //when it reaches the endTime(realtime + seconds, then stop the loop)
                if (DateTime.Now >= endTime)
                {
                    break;
                }
                //print the spinner
                Console.Write(s);
                Thread.Sleep(200);
                Console.Write("\b \b");
            }
        }
    }

    public void RunCountDown(int seconds)
    {
        //loop until the countdown gets to 0
        while (seconds > 0)
        {
            //printing the countdown on the same line
            Console.Write($"{seconds}");
            Thread.Sleep(1000);
            Console.Write("\b \b");   
            //the countdown
            seconds = seconds -1;
        }
    }
}
using System;

//BreathingActivity class inherits properties from Activity class
class BreathingActivity : Activity
{
    //base to inherit the parameters, acitivityName, description and duration from parent class
    public BreathingActivity() : base("Breathing Activity ", 
    "This activity is made for those who struggle to find calmness. It will help you relax your body, mind and spirit by guiding you through a mind-focused and powerful Asian breathing technique", 0) {}

    public void Run()
    {
        //run the program and print some instructions
        StartActivity();

        Console.WriteLine("Get ready... find a comfortable position");
        RunAnimation(4);
        //it adds the _duration to the seconds in real time to make the timer stops accurately
        DateTime end = DateTime.Now.AddSeconds(_duration);
        //for when the real time reaches the (real time + _duration) it should stop running the activity
        while (DateTime.Now < end)
        {
            //print breathe in + countdown
            Console.WriteLine("Breathe in..."); 
            RunCountDown(4);
            Console.WriteLine();
            //to stop the loop when it reaches the time set by user
            if (DateTime.Now >= end)
                break;

            //print breathe out + countdown
            Console.WriteLine("Now breathe out...");
            RunCountDown(4);
            Console.WriteLine();
        }

        EndActivity();
    }

}
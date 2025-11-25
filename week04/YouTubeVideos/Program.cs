using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Quit worrying about it", "Elder David A. Bednar", 780);
        video1.AddComment(new Comment("Dieter", "Wonderful, thank you for your words dear Elder!"));
        video1.AddComment(new Comment("Ulisses", "One of my favorites! I learned a lot!"));
        video1.AddComment(new Comment("Henry", "I couldn't think of a better way to teach this principle, felt the Spirit really strong!"));
        video1.AddComment(new Comment("Ronald", "Wow! Thanks for sharing some of your wisdom!"));
        video1.AddComment(new Comment("Gerald", "We need more videos like this!"));

        Video video2 = new Video("Think Celestial", "President Russell M. Nelson", 724);
        video2.AddComment(new Comment("Gerritt", "So inspiring!"));
        video2.AddComment(new Comment("Todd", "I felt the influence of the Holy Ghost! Thank you so much!"));
        video2.AddComment(new Comment("Quentin", "Love it! This is the third time I listen to it and I keep learning new things from it!"));

        Video video3 = new Video("Motions of a hidden fire", "President Jeffrey R. Holland", 740);
        video3.AddComment(new Comment("Dale", "I feel the desire to serve him more urgent and earnestly"));
        video3.AddComment(new Comment("Patrick", "Wonderful way to invite us to pray!"));
        video3.AddComment(new Comment("Neil", "Very special words!"));
        video3.AddComment(new Comment("Gary", "Thank you dear friend, your devotion truly inspires me!"));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.DisplayVideo();
            Console.WriteLine();
        }
    }
}
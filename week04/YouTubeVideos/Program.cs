using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video { Title = "Intro to C#", Author = "CodeAcademy", LengthInSeconds = 600 };
        video1.AddComment(new Comment("Alice", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Bob", "Nice breakdown of the concepts."));
        video1.AddComment(new Comment("Charlie", "I'm new to C# and this helped a lot."));
        videos.Add(video1);

        // Video 2
        Video video2 = new Video { Title = "Object-Oriented Programming", Author = "Tech With Tim", LengthInSeconds = 800 };
        video2.AddComment(new Comment("Diana", "Excellent explanation."));
        video2.AddComment(new Comment("Evan", "OOP finally makes sense!"));
        video2.AddComment(new Comment("Faith", "Clear and concise."));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video { Title = "LINQ Basics", Author = "DotNet Tutorials", LengthInSeconds = 720 };
        video3.AddComment(new Comment("George", "LINQ is powerful."));
        video3.AddComment(new Comment("Hannah", "I wish I knew this earlier."));
        video3.AddComment(new Comment("Ian", "Good job with the examples."));
        videos.Add(video3);

        // Video 4
        Video video4 = new Video { Title = "Async Programming", Author = "Brackeys", LengthInSeconds = 900 };
        video4.AddComment(new Comment("Jack", "Asynchronous code finally explained!"));
        video4.AddComment(new Comment("Karen", "This was tricky but you made it easy."));
        video4.AddComment(new Comment("Leo", "Thanks for the deep dive."));
        videos.Add(video4);

        // Display
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"  {comment.CommenterName}: {comment.CommentText}");
            }
            Console.WriteLine(new string('-', 40));
        }
    }
}

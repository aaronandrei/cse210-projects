using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private static readonly string[] _prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    { }

    public override void Run(int duration)
    {
        Random rand = new Random();
        Console.WriteLine($"\nPrompt: {_prompts[rand.Next(_prompts.Length)]}");
        Console.WriteLine("\nYou may begin listing in:");
        ShowCountDown(5);

        Console.WriteLine("\nStart listing (press Enter after each item):");
        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            if (Console.KeyAvailable)
            {
                string input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                    items.Add(input);
            }
        }

        Console.WriteLine($"\nYou listed {items.Count} items!");
    }
}

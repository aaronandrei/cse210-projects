using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing",
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    { }

    public override void Run(int duration)
    {
        int interval = 6;
        int elapsed = 0;

        while (elapsed < duration)
        {
            Console.WriteLine("\nBreathe in...");
            ShowCountDown(3);
            Console.WriteLine("Breathe out...");
            ShowCountDown(3);
            elapsed += interval;
        }
    }
}

using System;

public class ReflectionActivity : Activity
{
    private static readonly string[] _prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private static readonly string[] _questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience?",
        "What did you learn about yourself?",
        "How can you keep this experience in mind?"
    };

    public ReflectionActivity() : base("Reflection",
        "This activity will help you reflect on times in your life when you have shown strength and resilience.")
    { }

    private string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Length)];
    }

    private string GetRandomQuestion()
    {
        Random rand = new Random();
        return _questions[rand.Next(_questions.Length)];
    }

    private void DisplayPrompt()
    {
        Console.WriteLine($"\nPrompt: {GetRandomPrompt()}");
    }

    private void DisplayQuestions(int duration)
    {
        int elapsed = 0;
        while (elapsed < duration)
        {
            Console.WriteLine($"\n{GetRandomQuestion()}");
            ShowSpinner(5);
            elapsed += 5;
        }
    }

    public override void Run(int duration)
    {
        DisplayPrompt();
        Console.WriteLine("\nReflect on the following questions:");
        DisplayQuestions(duration);
    }
}

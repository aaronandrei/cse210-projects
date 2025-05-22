using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts;
    public Random random = new Random();

    public PromptGenerator()
    {
        _prompts = new List<string>()
        {
            "What belief do I hold that might be limiting me and what would happen if I let it go?",
            "Who in my life has influenced me the most, and what part of their influence do I carry with me today?",
            "If everyone lived exactly like me, what would the world be like?",
            "What patterns do I keep repeating and what might they be trying to teach me?",
            "If I wasn't afraid of failing, what would I attempt?",
            "What parts of myself do I hide from others and why?",
            "What would I regret not doing if I found out I only had one year to live?",
            "What did you fail at today?"
        };
    }

    public string GetRandomPrompt()
    {
        int randomIndex = random.Next(_prompts.Count);
        return _prompts[randomIndex];
    }
}
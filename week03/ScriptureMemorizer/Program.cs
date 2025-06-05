using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptureLibrary = new List<Scripture>
        {
            new Scripture(new Reference("John", 3, 16),
                "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),

            new Scripture(new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."),

            new Scripture(new Reference("Psalm", 23, 1),
                "The Lord is my shepherd; I shall not want."),

            new Scripture(new Reference("2 Nephi", 2, 25),
                "Adam fell that men might be; and men are, that they might have joy.")
        };

        Random random = new Random();
        bool keepGoing = true;

        while (keepGoing)
        {
            Scripture currentScripture = scriptureLibrary[random.Next(scriptureLibrary.Count)];

            while (true)
            {
                Console.Clear();
                Console.WriteLine(currentScripture.GetDisplayText());

                Console.WriteLine("\nPress Enter to hide more words, type 'next' for a new scripture, or 'quit' to exit.");
                string input = Console.ReadLine().ToLower();

                if (input == "quit")
                {
                    keepGoing = false;
                    break;
                }
                else if (input == "next")
                {
                    break;
                }
                else if (input == "")
                {
                    currentScripture.HideRandomWords(3);

                    if (currentScripture.AllWordsHidden())
                    {
                        Console.Clear();
                        Console.WriteLine(currentScripture.GetDisplayText());
                        Console.WriteLine("\nAll words are hidden. Press Enter to view a new scripture or type 'quit'.");
                        input = Console.ReadLine().ToLower();

                        if (input == "quit")
                        {
                            keepGoing = false;
                        }
                        break;
                    }
                }
            }
        }
    }
}

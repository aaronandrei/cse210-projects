using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Journal
{
    public List<Entry> _entries;
    public PromptGenerator promptGenerator;

    public Journal()
    {
        _entries = new List<Entry>();
        promptGenerator = new PromptGenerator();
    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
        Console.WriteLine("Entry added successfully!");
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("Your journal is currently empty.");
            return;
        }
        Console.WriteLine("--- Journal Entries ---");
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
        Console.WriteLine("--- End of Journal ---");
    }

    public void SaveToFile(string file)
    {
        try
        {
            string jsonString = JsonSerializer.Serialize(_entries);
            File.WriteAllText(file, jsonString);
            Console.WriteLine($"Journal saved to {file}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving journal: {ex.Message}");
        }
    }

    public void LoadFromFile(string file)
    {
        try
        {
            if (File.Exists(file))
            {
                string jsonString = File.ReadAllText(file);
                List<Entry> loadedEntries = JsonSerializer.Deserialize<List<Entry>>(jsonString);
                if (loadedEntries != null)
                {
                    _entries = loadedEntries;
                    Console.WriteLine($"Journal loaded from {file}");
                }
                else
                {
                    Console.WriteLine("Error loading journal: File is empty or contains invalid data.");
                }
            }
            else
            {
                Console.WriteLine($"File not found: {file}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading journal: {ex.Message}");
        }
    }
}
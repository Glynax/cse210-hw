using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    private List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }

    public void WriteNewEntry()
    {
        Console.WriteLine("\nWrite a new entry:");
        string prompt = GetRandomPrompt();
        Console.WriteLine("Prompt: " + prompt);
        Console.Write("Response: ");
        string response = Console.ReadLine();
        string date = DateTime.Now.ToString("yyyy-MM-dd");
        entries.Add(new Entry(prompt, response, date));
        Console.WriteLine("Entry added successfully!");
    }

    public void DisplayJournal()
    {
        Console.WriteLine("\nJournal entries:");
        if (entries.Count == 0)
        {
            Console.WriteLine("No entries found.");
        }
        else
        {
            foreach (Entry entry in entries)
            {
                Console.WriteLine(entry.ToString());
            }
        }
    }

    public void SaveJournal()
    {
        Console.Write("\nEnter the filename to save the journal: ");
        string filename = Console.ReadLine();

        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (Entry entry in entries)
                {
                    writer.WriteLine(entry.ToCsvString());
                }
            }
            Console.WriteLine("Journal saved successfully!");
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }

    public void LoadJournal()
    {
        Console.Write("\nEnter the filename to load the journal: ");
        string filename = Console.ReadLine();

        try
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                entries.Clear();
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] fields = line.Split(',');
                    if (fields.Length == 3)
                    {
                        string prompt = fields[0];
                        string response = fields[1];
                        string date = fields[2];
                        entries.Add(new Entry(prompt, response, date));
                    }
                }
            }
            Console.WriteLine("Journal loaded successfully!");
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }

    private string GetRandomPrompt()
    {
        string[] prompts = {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What is something new you learned today?",
            "Describe a moment that made you laugh today.",
            "How did you show kindness to someone today?",
            "Reflect on a challenge you faced and how you overcame it.",
            "What is a goal you have for tomorrow?"           
        };

        Random random = new Random();
        int index = random.Next(prompts.Length);
        return prompts[index];
    }
}

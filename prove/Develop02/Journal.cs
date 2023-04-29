using System.IO;
using System.Collections.Generic;

public class Journal
{
    public List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }

    public void AddEntry() //DONE
    {
        // Get date
        DateTime theCurrentTime = DateTime.Now;
        string date = theCurrentTime.ToShortDateString();

        // Get prompt
        PromptGenerator prompter = new PromptGenerator();
        string prompt = prompter.ChoosePrompt();
        Console.WriteLine(prompt);

        // Get response
        Console.Write("> ");
        string response = Console.ReadLine();

        // Put into entry
        Entry entry = new Entry(date, prompt, response);
        
        // Add to list
        entries.Add(entry);
    }

    public void DisplayAllEntries() // DONE
    {
        foreach (Entry i in entries)
        {
            i.DisplayEntry();
        }

    }

    public void SavetoFile(List<Entry> _entries) // DONE
    {
        Console.WriteLine("What is the file name?");
        Console.Write("> ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry i in _entries)
            {
                string stringEntry = i.GetEntryAsString();
                outputFile.WriteLine(stringEntry);
            }
            
        }
    }

    public List<Entry> ReadFromFile() // DONE
    {
        List<Entry> entryList = new List<Entry>();
        
        Console.WriteLine("What is the file name?");
        Console.Write("> ");
        string response = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(response);

        foreach (string line in lines)
        {
            // Split up string
            string[] parts = line.Split(",");
            // parts[0] - date
            // parts[1] - prompt
            // parts[2] - entry

            // Create new entry
            Entry entry = new Entry(parts[0], parts[1], parts[2]);

            //Add entry to entry list
            entryList.Add(entry);
        }

        return entryList;
    }
}
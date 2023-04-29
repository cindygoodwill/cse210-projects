using System;

class Program
{
    static void Main(string[] args)
    {
        // create menu and user input varialbes
        Journal journal = new Journal();
        int input = 0;

        List<string> menu = new List<string>
        {
            "Please select one of the following choices:",
            "1. Write",
            "2. Display",
            "3. Load",
            "4. Save",
            "5. Quit",
            "What would you like to do?"
        };

        // While user input is not 5 keep displaying menu
        while (input != 5)
        {
            foreach(string menuItem in menu)
            {
                Console.WriteLine(menuItem);
            }
            
            Console.Write("> ");
            string response = Console.ReadLine();
            int userInput = int.Parse(response);
            input = userInput;

            if (input == 1) // Write
            {
                journal.AddEntry();
            }
            else if (input == 2) // Display
            {
                journal.DisplayAllEntries();
            }
            else if (input == 3) // Load - NOT DONE
            {
                List<Entry> newEntry = journal.ReadFromFile(); 
               
                foreach (Entry i in newEntry)
                {
                    journal.entries.Add(i); 
                }
                journal.DisplayAllEntries();
            }
            else if (input == 4) // DONE
            {
                journal.SavetoFile(journal.entries);
            }
            
        }

        return;

    }
}
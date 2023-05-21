using System;

class Program
{
    static void Main(string[] args)
    {
        // create menu and user input varialbes
        Journal journal = new Journal();
        int _input = 0;

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
        while (_input != 5)
        {
            foreach(string menuItem in menu)
            {
                Console.WriteLine(menuItem);
            }
            
            Console.Write("> ");
            string response = Console.ReadLine();
            int userInput = int.Parse(response);
            _input = userInput;

            if (_input == 1) // Write
            {
                journal.AddEntry();
            }
            else if (_input == 2) // Display
            {
                journal.DisplayAllEntries();
            }
            else if (_input == 3) // Load DONE
            {
                List<Entry> newEntry = journal.ReadFromFile(); 
               
                foreach (Entry i in newEntry)
                {
                    journal._entries.Add(i); 
                }
                journal.DisplayAllEntries();
            }
            else if (_input == 4) // DONE
            {
                journal.SavetoFile(journal._entries);
            }
            
        }

        return;

    }
}
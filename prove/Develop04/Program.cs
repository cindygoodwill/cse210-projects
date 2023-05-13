using System;

class Program
{
    static void Main(string[] args)
    {
        // Variables
        int _input = 0;
        List<string> menu = new List<string>
        {
            "Menu options:",
            "1. Start breathing activity",
            "2. Start reflecting activity",
            "3. Start listing activity",
            "4. Quit"
        };
        
        // While user input is not 3 keep displaying the menu
        while (_input != 4)
        {
            // Writes menu from list above
            Console.Clear();
            foreach (string menuItem in menu)
            {
                Console.WriteLine(menuItem);
            }

            // Gets input from user
            Console.Write("Select a choice from the menu: ");
            string response = Console.ReadLine();
            int input = int.Parse(response);
            _input = input;

            // Takes action for each input
            if (_input == 1 ) // Breathing Activity
            {
                Breathing myActivity1 = new Breathing();

                myActivity1.BreathingActivity();
                
            }
            else if (_input == 2) // Reflecting Activity
            {
                Reflecting myActivity2 = new Reflecting();

                myActivity2.ReflectingActivity();
            }
            else if (_input == 3) // Listing Activity
            {
                Listing myActivity3 = new Listing();

                myActivity3.ListingActivity();
            }
            else
            {
                break;
            }
        }
        
        return;


    }
}
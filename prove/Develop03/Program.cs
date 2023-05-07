using System;

class Program
{
    static void Main(string[] args)
    {
        // Variables
        Scripture scripture = new Scripture();
        Reference reference = new Reference();
        int _input = 0;
        List<string> menu = new List<string>
        {
            "Welcome to the Scripture Memorizer!",
            "Please select one of the following choices:",
            "1. Enter a scripture",
            "2. Display the scripture",
            "3. Memorize the scripture",
            "4. Quit"
        };


        // While user input is not 3 keep displaying the menu
        while (_input != 4)
        {
            // Writes menu from list above
            foreach (string menuItem in menu)
            {
                Console.WriteLine(menuItem);
            }

            // Gets input from user
            Console.Write("What would like to do? ");
            string response = Console.ReadLine();
            int input = int.Parse(response);
            _input = input;

            // Takes action for each input
            if (_input == 1 ) // Enter Scrip
            {
                Console.WriteLine("Enter the reference to the Scripture.");
                reference.UserEnterRef();
                scripture.SetText();
                
            }
            else if (_input == 2) // Display
            {
                scripture.SetReference(reference.GetReference());
                scripture.DisplayScrip();
            }
            else if (_input == 3) //Memorize
            {
                int getOut = 0;
                
                while (scripture.IsCompletelyHidden() == false && getOut == 0)
                {
                    // Clear console
                    Console.Clear();

                    // Display scripture and statement to request user input
                    scripture.DisplayScrip();

                    Console.WriteLine();
                    Console.Write("Press enter to hide words. Or type \"quit\" to return to the menu. ");
                    string userInput = Console.ReadLine();


                    if (userInput == "")
                    {
                        scripture.HideWords();
                    }
                    else if (userInput == "quit")
                    {
                        getOut = 1;
                    }
                    else
                    {
                        Console.WriteLine("This isn't one of the accepted inputs. Try harder!");
                    }
                }

                // Unhide all
                scripture.UnhideAll();
                
                // Quit
                break;
            }
            else
            {
                break;
            }
        }
        
        return;
    }
}
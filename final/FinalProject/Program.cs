using System;

class Program
{
    static void Main(string[] args)
    {
        //Variables
        int _input = 0;
        Parent parent = new Parent();

        // Find out who is here
        Console.Clear();
        Console.Write("First name: ");
        string responseFirst = Console.ReadLine();

        Console.Write("Last name: ");
        string responseLast = Console.ReadLine();

        bool isItNew = parent.IsThisNewUser(responseFirst, responseLast);

        if (isItNew == false)
        {
            parent.ReadFromFile();
            parent.DisplayDash();
        }
        else if (isItNew == true)
        {
            parent.DisplayDash();
        }

        // Create menu
        List<string> menu = new List<string>
        {
            "Options:",
            "  1. Display My Info",
            "  2. Create Child",
            "  3. Check Chores",
            "  4. Save",
            "  5. Quit"
        };

        // While user input is not 5 keep displaying the menu
        while (_input != 5)
        {
            Console.Clear();
            // Writes menu from list above
            foreach (string menuItem in menu)
            {
                Console.WriteLine(menuItem);
            }

            // Gets input from user
            Console.Write("What do you want to do?: ");
            string response = Console.ReadLine();
            int input = int.Parse(response);
            _input = input;

            // Take action for each input
            if (_input == 1) // Display my info
            {
                parent.DisplayDash();
                Console.Write("Press Enter to choose another option. ");
                string input2 = Console.ReadLine();

                if (string.IsNullOrEmpty(input2))
                {
                    break;
                }
            }
            else if (_input == 2) // Create child
            {
                Child child = new Child();

                // Name
                Console.Write("First name: ");
                string name = Console.ReadLine();
                child.SetFirstName(name);

                Console.Write("Last name: ");
                string lname = Console.ReadLine();
                child.SetLastName(lname);

                // Age
                Console.Write("Age: ");
                string age = Console.ReadLine();
                int ageNum = int.Parse(age);
                child.SetAge(ageNum);

                // Type
                child.SetType("child");

                // Standing
                child.SetGoodStanding(true);

                // Add Chores
                Console.Write("Add chores (Y/N): ");
                string addResponse = Console.ReadLine();
                string again = "Y";

                if (addResponse == "Y")
                {
                    while (again == "Y")
                    {
                        child.AddChores();
                        Console.Write("Add another (Y/N): ");
                        string addResponse2 = Console.ReadLine();
                        again = addResponse2;
                    }
                }
                

                // Add Consequences
                Console.Write("Add consequence (Y/N): ");
                string addResponse3 = Console.ReadLine();
                string again2 = "Y";

                if (addResponse == "Y")
                {
                    while (again == "Y")
                    {
                        child.AddConsequences();
                        Console.Write("Add another (Y/N): ");
                        string addResponse4 = Console.ReadLine();
                        again2 = addResponse4;
                    }
                }

                // Add to Child list
                parent.AddToChildList(child);

            }
            else if (_input == 3) // Check chores
            {
                // Which child?
                
                // how to remove a chore from a child using RemoveChore()
            }
            else if (_input == 4) // Save
            {
                // Adult save to file
                // Rotate through all children and save to file 
            }
            else // Quit
            {
                break;
            }
        }

        return;
    }
}
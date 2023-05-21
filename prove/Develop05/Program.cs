using System.IO;
using System.Collections.Generic;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Start with blank, You have ___ points, blank, then menu
        // Variables
        int _input = 0;
        User user = new User();

        // Menu
        List<string> menu = new List<string>
        {
            "Menu Options:",
            "  1. Create New Goal",
            "  2. List Goals",
            "  3. Save Goals",
            "  4. Load Goals",
            "  5. Record Event",
            "  6. Quit"
        };

        // While user input is not 6 keep displaying the menu
        while (_input != 6)
        {
            // Display points
            user.DisplayPoints();

            // Writes menu from list above
            foreach (string menuItem in menu)
            {
                Console.WriteLine(menuItem);
            }

            // Gets input from user
            Console.Write("Select a choice from the menu: ");
            string response = Console.ReadLine();
            int input = int.Parse(response);
            _input = input;

            // Take action for each input
            if (_input == 1) // Create New Goal
            {
                Console.WriteLine("The types of Goals are:");
                Console.WriteLine("  1. Simple Goal");
                Console.WriteLine("  2. Eternal Goal");
                Console.WriteLine("  3. Checklist Goal");

                Console.Write("Which type of goal would you like to create? ");
                string goalResponse = Console.ReadLine();
                int goalInput = int.Parse(goalResponse);

                if (goalInput == 1) // Simple Goal
                {
                    // Create a simple goal
                    SimpleGoal simple = new SimpleGoal("", "", 0, "");

                    // Setup simple goal
                    simple.SetupGoal();

                    // Add to goal list
                    user.AddGoalToList(simple);

                }
                else if (goalInput == 2) // Eternal Goal
                {

                    // Create an eternal goal
                    EternalGoal eternal = new EternalGoal("", "", 0, "");

                    // Setup eternal goal
                    eternal.SetupGoal();

                    // Add to goal list
                    user.AddGoalToList(eternal);

                }
                else if (goalInput == 3) // Checklist Goal
                {
                    // Create a checklist goal
                    ChecklistGoal checklist = new ChecklistGoal("", "", 0, "", 0, 0);

                    // Setup checklist goal
                    checklist.SetupGoal();

                    // Add to goal list
                    user.AddGoalToList(checklist);
                }

            }
            else if (_input == 2) // List Goals
            {
                user.DisplayGoals();
                user.DisplayCompletedGoals();
            }
            else if (_input == 3) // Save Goals to file
            {
                user.SavetoFile();
            }
            else if (_input == 4) // Load goals from file
            {
                user.ReadFromFile();
            }
            else if (_input == 5) // Record event
            {
                user.RecordEvent();
            }
            else
            {
                break;
            }
        }

        return;
    }
}
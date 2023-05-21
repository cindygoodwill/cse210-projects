using System.IO;
using System.Collections.Generic;

public class User
{
    private int _totalPoints;
    private List<Goal> _goals;
    private List<Goal> _completed;

    // Constructors
    public User()
    {
        _goals = new List<Goal>();
        _completed = new List<Goal>();
    }

    // Getters and Setters
    public int GetTotalPoints()
    {
        return _totalPoints;
    }

    public void SetTotalPoints(int points)
    {
        _totalPoints = points;
    }


    // Methods
    public void SavetoFile() // DONE - if it works, see note below, puts _goals and _completed into file
    {
        Console.WriteLine("What is the file name?" );
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            string totPointsString = _totalPoints.ToString();
            outputFile.WriteLine(totPointsString);
        }

        using (StreamWriter outputFile = new StreamWriter(fileName, true)) // true means it will append not write over the other parts
        {
            foreach (Goal i in _goals)
            {
                string stringEntry = i.GetEntryAsString();
                outputFile.WriteLine(stringEntry);
            }
        }

        using (StreamWriter outputFile = new StreamWriter(fileName, true))
        {
            foreach (Goal i in _completed) 
            {
                string stringEntry = i.GetEntryAsString();
                outputFile.WriteLine(stringEntry);
            }
        }
        Console.WriteLine("Saved to file.");
    }

    public  void ReadFromFile() // Use this with next method, puts this list into _goals
    {
        List<Goal> goalList = new List<Goal>();

        Console.Write("What is the file name? ");
        string response = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(response); // Creates an array not a list

        _totalPoints = int.Parse(lines[0]);
        lines = lines.Skip(1).ToArray(); // Skips one item, puts remaining items into a new array called lines
        
        foreach (string line in lines)
        {
            bool boolTemp = true;
            
            // Split up string
            string[] part = line.Split("|");
            // part[0] is name
            // part[1] is description
            // part[2] is points
            // part[3] is type
            // part[4] is isComplete NEW!!!
            // part[5] is bonus
            // part[6] is time to bonus
            // part[7] is tracker

            // Create new entry if checklist
            if (part[3] == "checklist")
            {
                if (part[4] == "true")
                {
                    boolTemp = true;
                }
                else 
                {
                    boolTemp = false;
                }
                ChecklistGoal goal = new ChecklistGoal(part[0], part[1], int.Parse(part[2]), part[3], int.Parse(part[5]), int.Parse(part[6]), int.Parse(part[7]), boolTemp);

                goalList.Add(goal);
            }
            // Create new entry if simple
            else if (part[3] == "simple")
            {
                if (part[4] == "true")
                {
                    boolTemp = true;
                }
                else 
                {
                    boolTemp = false;
                }
                
                SimpleGoal goal = new SimpleGoal(part[0], part[1], int.Parse(part[2]), part[3], boolTemp);
                goalList.Add(goal);
            }
            // Create a new entry if eternal
            else
            {
                if (part[4] == "true")
                {
                    boolTemp = true;
                }
                else 
                {
                    boolTemp = false;
                }
                
                EternalGoal goal = new EternalGoal(part[0], part[1], int.Parse(part[2]), part[3], boolTemp);
                goalList.Add(goal);
            }
            
        }

        _goals = goalList; 
        SplitOffCompletedList();
    }

    public void SplitOffCompletedList() // Included in previous method, puts list into _completed
    {
        for (int i = _goals.Count - 1; i >= 0; i--)
        {
            if (_goals[i].GetIsComplete() == true)
            {
                _completed.Add(_goals[i]);
                _goals.RemoveAt(i);
            }
        }
    }

    public void RecordEvent()
    {
        // Bonus
        int points = 0;
        
        // List the goals
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
        }
        
        // Which did you complete?
        Console.Write("Which goal did you accomplish? ");
        string response = Console.ReadLine();
        int responseNumber = int.Parse(response);

        // Change to complete if it's a simple goal
        if (_goals[responseNumber - 1] is SimpleGoal simpleGoal)
        {
            simpleGoal.SetIsComplete(true);
            points = simpleGoal.GetPoints();
        }
        // Tick if checklist goal
        else if (_goals[responseNumber - 1] is ChecklistGoal checklistGoal)
        {
            checklistGoal.TickGoal();
            if (checklistGoal.GetTimesToBonus() == checklistGoal.GetTracker())
            {
                checklistGoal.SetIsComplete(true);
                points = checklistGoal.GetBonusPoints();
            }
            else
            {
                points = checklistGoal.GetPoints();
            }
            
        }
        else if (_goals[responseNumber - 1] is EternalGoal eternalGoal)
        {
            points = eternalGoal.GetPoints();
        }

        // Move to completed list
        SplitOffCompletedList();

        // Add points to total
        _totalPoints = _totalPoints + points;

        // Announce results!
        Console.WriteLine($"Congratuations! You have earned {points} points!");
        Console.WriteLine($"You now have {_totalPoints} points.");
        DisplayCompletedGoals();

    }

    public void DisplayGoals()
    {
        Console.WriteLine("The goals are:");

        // Write each goal
        for (int i = 0; i < _goals.Count; i++)
        {
            // Writing checklist goals
            if (_goals[i] is ChecklistGoal checklistGoal)
            {
                // Variable for IsComplete X
                string complete = " ";
                
                // Change IsComplete to X
                if (checklistGoal.GetIsComplete() == true)
                {
                    complete = "X";
                }
                
                Console.WriteLine($"{i + 1}. [{complete}] {checklistGoal.GetName().ToUpper()}: {checklistGoal.GetDescription()} (Points: {checklistGoal.GetPoints()} Bonus: {checklistGoal.GetBonusPoints()}) --- Currently completed {checklistGoal.GetTracker()}/{checklistGoal.GetTimesToBonus()}");
            }
            // Writing simple goals
            else if (_goals[i] is SimpleGoal simpleGoal)
            {
                // Variable for IsComplete X
                string complete = " ";
                
                // Change IsComplete to X
                if (simpleGoal.GetIsComplete() == true)
                {
                    complete = "X";
                }
                
                Console.WriteLine($"{i + 1}. [{complete}] {simpleGoal.GetName().ToUpper()}: {simpleGoal.GetDescription()} (Points: {simpleGoal.GetPoints()})");
            }
            // Writing eternal goals
            else if (_goals[i] is EternalGoal eternalGoal)
            {
                // Variable for IsComplete X
                string complete = " ";
                
                // Change IsComplete to X
                if (eternalGoal.GetIsComplete() == true)
                {
                    complete = "X";
                }
                
                Console.WriteLine($"{i + 1}. [{complete}] {eternalGoal.GetName().ToUpper()}: {eternalGoal.GetDescription()} (Points: {eternalGoal.GetPoints()})");
            }
        }
    }

    public void DisplayCompletedGoals()
    {
        Console.WriteLine("The completed goals are:");

        // Write each goal
        for (int i = 0; i < _completed.Count; i++)
        {
            // Writing checklist goals
            if (_completed[i] is ChecklistGoal checklistGoal)
            {
                // Variable for IsComplete X
                string complete = "";
                
                // Change IsComplete to X
                if (checklistGoal.GetIsComplete() == true)
                {
                    complete = "X";
                }
                
                Console.WriteLine($"{i + 1}. [{complete}] {checklistGoal.GetName().ToUpper()}: {checklistGoal.GetDescription()} (Points: {checklistGoal.GetPoints()} Bonus: {checklistGoal.GetBonusPoints()}) --- Currently completed {checklistGoal.GetTracker()}/{checklistGoal.GetTimesToBonus()}");
            }
            // Writing simple goals
            else if (_completed[i] is SimpleGoal simpleGoal)
            {
                // Variable for IsComplete X
                string complete = "";
                
                // Change IsComplete to X
                if (simpleGoal.GetIsComplete() == true)
                {
                    complete = "X";
                }
                
                Console.WriteLine($"{i + 1}. [{complete}] {simpleGoal.GetName().ToUpper()}: {simpleGoal.GetDescription()} (Points: {simpleGoal.GetPoints()})");
            }
            // Writing eternal goals
            else if (_completed[i] is EternalGoal eternalGoal)
            {
                // Variable for IsComplete X
                string complete = "";
                
                // Change IsComplete to X
                if (eternalGoal.GetIsComplete() == true)
                {
                    complete = "X";
                }
                
                Console.WriteLine($"{i + 1}. [{complete}] {eternalGoal.GetName().ToUpper()}: {eternalGoal.GetDescription()} (Points: {eternalGoal.GetPoints()})");
            }
        }
    }

    public void AddGoalToList(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RemoveGoalFromList(Goal goal)
    {
        _goals.Remove(goal);
    }

    public void AddCompletedToList(Goal goal)
    {
        _completed.Add(goal);
    }

    public void RemoveCompletedFromList(Goal goal)
    {
        _completed.Remove(goal);
    }

    public void DisplayPoints()
    {
        Console.WriteLine();
        Console.WriteLine($"You have {_totalPoints} points.");
        Console.WriteLine();
    }
}
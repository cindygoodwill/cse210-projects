public class DailyChore : Chore
{
    // Attributes


    // Constructors
    public DailyChore()
    {
        SetChoreConsequence("No electronics");
        SetChoreType("Daily");
        SetRepeat(1);
        SetAge(1);
        SetDueDayTime(9);
    }

    // Getters and Setters


    // Methods
    
    public override void PickChore()
    {
        // Variables

        List<String> listChores = new List<String>
        {
            "  1. Take out Trash",
            "  2. Feed Dog",
            "  3. Bring in Mail",
            "  4. Straighten House"
        };

        List<String> listName = new List<String>
        {
            "Take out Trash",
            "Feed Dog",
            "Bring in Mail",
            "Straighten House"
        };
        
        // Ask for input
        foreach (string list in listChores)
        {
            Console.WriteLine(list);
        }

        Console.Write("Pick a chore to add: ");
        string response = Console.ReadLine();

        // Create chore and then return it
        if(response == "1")
        {
            SetChoreName(listName[0]);
        }
        else if (response == "2")
        {
            SetChoreName(listName[1]);
        }
        else if (response == "3")
        {
            SetChoreName(listName[2]);
        }
        else if (response == "4")
        {
            SetChoreName(listName[3]);
        }

    }
    public override void RecordEvent()
    {
        throw new NotImplementedException();
    }
}
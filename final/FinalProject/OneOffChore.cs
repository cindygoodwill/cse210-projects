public class OneOffChore : Chore
{
    // Attributes


    // Constructors
    public OneOffChore()
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
            "  1. Wash Windows",
            "  2. Wash Car",
            "  3. Deep Clean",
            "  4. Weed Garden"
        };

        List<String> listName = new List<String>
        {
            "Wash Windows",
            "Wash Car",
            "Deep Clean",
            "Weed Garden"
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
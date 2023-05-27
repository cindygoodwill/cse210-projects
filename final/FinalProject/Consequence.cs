public class Consequence
{
    // Attributes
    private string _consequenceName, _consequenceDescription;
    private int _length;

    // Constructors
    public Consequence()
    {
        _length = 1;
    }


    // Getters and Setters
    public string GetConsequenceName()
    {
        return _consequenceName;
    }
    public void SetConsequenceName(string name)
    {
        _consequenceName = name;
    }
    public string GetConsequenceDescription()
    {
        return _consequenceDescription;
    }
    public void SetConsequenceDescription(string description)
    {
        _consequenceDescription = description;
    }
    public int GetConsequenceLength()
    {
        return _length;
    }
    public void SetConsequenceLength(int length)
    {
        _length = length;
    }

    // Methods
    public void PickConsequence()
    {
        // Variables

        List<String> listCons = new List<String>
        {
            "  1. Lose Electronics",
            "  2. Extra Chore",
            "  3. No Friends",
            "  4. Lose Door"
        };

        List<String> listName = new List<String>
        {
            "Lose Electronics",
            "Extra Chore",
            "No Friends",
            "Lose Door"
        };

        List<String> listDescription = new List<String>
        {
            "Lose all extronics",
            "Do one of your siblings chores",
            "No going out with friends or having them over",
            "Door removed from room"
        };
        
        // Ask for input
        foreach (string list in listCons)
        {
            Console.WriteLine(list);
        }

        Console.Write("Pick a consequence to add: ");
        string response = Console.ReadLine();

        // Create chore and then return it
        if(response == "1")
        {
            SetConsequenceName(listName[0]);
            SetConsequenceDescription(listDescription[0]);
        }
        else if (response == "2")
        {
            SetConsequenceName(listName[1]);
            SetConsequenceDescription(listDescription[1]);
        }
        else if (response == "3")
        {
            SetConsequenceName(listName[2]);
            SetConsequenceDescription(listDescription[2]);
        }
        else if (response == "4")
        {
            SetConsequenceName(listName[3]);
            SetConsequenceDescription(listDescription[3]);
        }

    }
    public string GetConsequenceAsString()
    {
        string consequence = $"{_consequenceName}|{_consequenceDescription}|{_length}";
        return consequence;
    }
}
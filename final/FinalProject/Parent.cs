public class Parent : Person
{
    // Attributes
    private bool _doneChecking;
    private List<Child> _children;

    // Constructors
    public Parent()
    {
        _children = new List<Child>();
        _doneChecking = true;
        SetType("parent");
        SetAge(100);
    }


    // Getters and Setters
    public bool GetDoneChecking()
    {
        return _doneChecking;
    }
    public void SetDoneChecking(bool checking)
    {
        _doneChecking = checking;
    }
    public List<Child> GetChildren()
    {
        return _children;
    }
    public void SetChildren(List<Child> children)
    {
        _children = children;
    }

    // Methods
    public void AddToChildList(Child child)
    {
        _children.Add(child);
    }
    public override void SaveToFile()
    {
        // Put adult info into file: CindyGoodwillAdult.txt
        string adultFileName = $"{GetFirstName()}{GetLastName()}Adult.txt";

        using (StreamWriter outputFile = new StreamWriter(adultFileName))
        {
            outputFile.WriteLine(PersonToString());
        }

        // Create file for children: CindyGoodwillChildren.txt
        string adultChildrenFileName = $"{GetFirstName()}{GetLastName()}Children.txt";
        
        using (StreamWriter outputFile = new StreamWriter(adultChildrenFileName))
        {
            foreach (Child i in _children)
            {
                string stringEntry = i.PersonToString();
                outputFile.WriteLine(stringEntry);
            }
        }

        Console.WriteLine("Saved to file.");
    }
    public override void ReadFromFile()
    {
        // Variables
        List<Child> childList = new List<Child>();

        // Create person
        string firstName = GetFirstName();
        string lastName = GetLastName();

        string[] lines = System.IO.File.ReadAllLines ($"{firstName}{lastName}Adult.txt"); 

        // string _personString = $"{GetFirstName()}|{GetLastName()}|{GetPersonType()}|{GetAge()}";
        string[] part = lines[0].Split("|");
        SetFirstName(part[0]);
        SetLastName(part[1]);
        SetType(part[2]);
        int numAge = int.Parse(part[3]);
        SetAge(numAge);

        // Create child list
        string[] lines2 = System.IO.File.ReadAllLines ($"{firstName}{lastName}Children.txt");

        // string _personString = $"{GetFirstName()}|{GetLastName()}|{GetPersonType()}|{GetAge()}|{_goodStanding}";
        foreach (string line in lines2)
        {
            Child child = new Child();
            
            string[] part2 = line.Split("|");
            // part[0] firstname
            // part[1] lastname
            // part[2] type
            // part[3] age
            // part[4] good standing
            
            child.SetFirstName(part2[0]);
            child.SetLastName(part2[1]);
            child.SetLastName(part2[2]);
            int numAge3 = int.Parse(part2[3]);
            child.SetAge(numAge3);
            bool GSbool = bool.Parse(part2[4]);
            child.SetGoodStanding(GSbool);

            childList.Add(child);
        }

        _children = childList;

        Console.WriteLine("Files loaded.");

    }
    public override string PersonToString()
    {
        string _personString = $"{GetFirstName()}|{GetLastName()}|{GetPersonType()}|{GetAge()}";
        return _personString;
    }
    public override void DisplayDash()
    {
        Console.Clear();
        Console.WriteLine($"Hi {GetFirstName()}!");
        // Here are your children, their chores, and their consequences. 
        Console.WriteLine("Here are your children, their chores, and their consequences.");
        
        // For each child display name, chores and consequences.
        foreach (Child child in _children)
        {
            Console.WriteLine(child.GetFirstName());
            child.DisplayChores();
            child.DisplayConsequences();
        }
    }
}
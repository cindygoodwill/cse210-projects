using System.IO;
using System.Collections.Generic;

public class Child : Person
{
    // Attributes
    private bool _goodStanding;
    private List<Consequence> _consequences;
    private List<Chore> _chores;

    // Constructors
    public Child()
    {
        _consequences = new List<Consequence>();
        _chores = new List<Chore>();
        _goodStanding = true;
        SetType("child");
    }


    // Getters and Setters
    public bool GetGoodStanding()
    {
        return _goodStanding;
    }
    public void SetGoodStanding(bool standing)
    {
        _goodStanding = standing;
    }
    public List<Consequence> GetConsequncesList()
    {
        return _consequences;
    }
    public void SetConsequences(List<Consequence> list)
    {
        _consequences = list;
    }
    public List<Chore> GetChoreList()
    {
        return _chores;
    }
    public void SetChoreList(List<Chore> list)
    {
        _chores = list;
    }

    // Methods
    public void RemoveChore()
    {
        DisplayChores();
        
        Console.WriteLine();
        Console.Write("Number of completed chore: ");
        string remove = Console.ReadLine();
        int removeInt = int.Parse(remove);

        _chores.RemoveAt(removeInt - 1);

    }
    public void AddChores()
    {
        Console.Write("What type of chore? (Daily, Dishes, Saturday, OneOff): ");
        string selectChore = Console.ReadLine();

        if (selectChore == "Daily")
        {
            DailyChore newConsequence = new DailyChore();
            newConsequence.PickChore();
            _chores.Add(newConsequence);
        }
        else if (selectChore == "Dishes")
        {
            DishesChore newDishes = new DishesChore();
            newDishes.PickChore();
            _chores.Add(newDishes);
        }
        else if (selectChore == "Saturday")
        {
            SaturdayChore newSaturday = new SaturdayChore();
            newSaturday.PickChore();
            _chores.Add(newSaturday);
        }
        else if (selectChore == "OneOff")
        {
            OneOffChore newOneOff = new OneOffChore();
            newOneOff.PickChore();
            _chores.Add(newOneOff);
        }
    }
    public void AddConsequences()
    {
        
        Consequence newConsequence = new Consequence();
        newConsequence.PickConsequence();
        _consequences.Add(newConsequence);
    
    }
    public void DisplayChores()
    {
        Console.WriteLine("CHORE LIST:");
        foreach (Chore chore in _chores)
        {
            int indexInt = _chores.IndexOf(chore);
            Console.WriteLine($"  {indexInt + 1}. {chore.GetChoreName()}");
        }
    }
    public void DisplayConsequences()
    {
        Console.WriteLine("CONSEQUENCE LIST:");
        foreach (Consequence consequence in _consequences)
        {
            Console.WriteLine(consequence.GetConsequenceName());
        }
    }
    public override void SaveToFile()
    {
        // Save Chores to file: HoytGoodwillChores.txt
        string FileName1 = $"{GetFirstName()}{GetLastName()}Chores.txt";
        
        using (StreamWriter outputFile = new StreamWriter(FileName1))
        {
            foreach (Chore i in _chores)
            {
                string stringEntry = i.GetChoreAsString();
                outputFile.WriteLine(stringEntry);
            }
        }

        // Save Consequences to file: HoytGoodwillConsequences.txt
        string FileName2 = $"{GetFirstName()}{GetLastName()}Consequences.txt";
        
        using (StreamWriter outputFile = new StreamWriter(FileName2))
        {
            foreach (Consequence i in _consequences)
            {
                string stringEntry2 = i.GetConsequenceAsString();
                outputFile.WriteLine(stringEntry2);
            }
        }

        Console.WriteLine("Saved to file.");
    }
    public override void ReadFromFile()
    {
        // Variables
        List<Consequence> consequenceList = new List<Consequence>();
        List<Chore> choreList = new List<Chore>();
        string firstName = GetFirstName();
        string lastName = GetLastName();

        // Create consequence list
        string[] lines2 = System.IO.File.ReadAllLines ($"{firstName}{lastName}Consequences.txt");
        foreach (string line in lines2)
        {
            Consequence consequence = new Consequence();
            
            string[] part2 = line.Split("|");
            // part[0] is name
            // part[1] is description
            // part[2] is length
            
            consequence.SetConsequenceName(part2[0]);
            consequence.SetConsequenceDescription(part2[1]);
            int numLength = int.Parse(part2[2]);
            consequence.SetConsequenceLength(numLength);

            consequenceList.Add(consequence);
        }

        _consequences = consequenceList;

        // Create chore list
        string[] lines3 = System.IO.File.ReadAllLines ($"{firstName}{lastName}Chores.txt");
        foreach (string line in lines3)
        {   
            string[] part3 = line.Split("|");
            // part3[0] chorename
            // part3[1] consequences
            // part3[2] type
            // part3[3] repeat
            // part3[4] age
            // part3[5] dueDayTime
            
            if (part3[2] == "Dishes")
            {
                DishesChore dChore = new DishesChore();
                dChore.SetChoreName(part3[0]);
                dChore.SetChoreConsequence(part3[1]);
                dChore.SetChoreType(part3[2]);
                int numRepeat = int.Parse(part3[3]);
                dChore.SetRepeat(numRepeat);
                int numAge2 = int.Parse(part3[4]);
                dChore.SetAge(numAge2);
                int numDDT = int.Parse(part3[5]);
                dChore.SetDueDayTime(numDDT);

                choreList.Add(dChore);
            }
            else if (part3[2] == "Saturday")
            {
                SaturdayChore sChore = new SaturdayChore();
                sChore.SetChoreName(part3[0]);
                sChore.SetChoreConsequence(part3[1]);
                sChore.SetChoreType(part3[2]);
                int numRepeat = int.Parse(part3[3]);
                sChore.SetRepeat(numRepeat);
                int numAge2 = int.Parse(part3[4]);
                sChore.SetAge(numAge2);
                int numDDT = int.Parse(part3[5]);
                sChore.SetDueDayTime(numDDT);

                choreList.Add(sChore);
            }
            else if (part3[2] == "Daily")
            {
                DailyChore yChore = new DailyChore();
                yChore.SetChoreName(part3[0]);
                yChore.SetChoreConsequence(part3[1]);
                yChore.SetChoreType(part3[2]);
                int numRepeat = int.Parse(part3[3]);
                yChore.SetRepeat(numRepeat);
                int numAge2 = int.Parse(part3[4]);
                yChore.SetAge(numAge2);
                int numDDT = int.Parse(part3[5]);
                yChore.SetDueDayTime(numDDT);

                choreList.Add(yChore);
            }
            else if (part3[2] == "OneOff")
            {
                OneOffChore oChore = new OneOffChore();
                oChore.SetChoreName(part3[0]);
                oChore.SetChoreConsequence(part3[1]);
                oChore.SetChoreType(part3[2]);
                int numRepeat = int.Parse(part3[3]);
                oChore.SetRepeat(numRepeat);
                int numAge2 = int.Parse(part3[4]);
                oChore.SetAge(numAge2);
                int numDDT = int.Parse(part3[5]);
                oChore.SetDueDayTime(numDDT);

                choreList.Add(oChore);
            }
            
        }
        _chores = choreList;

    }
    public override string PersonToString()
    {
        string _personString = $"{GetFirstName()}|{GetLastName()}|{GetPersonType()}|{GetAge()}|{_goodStanding}";
        return _personString;
    }
}
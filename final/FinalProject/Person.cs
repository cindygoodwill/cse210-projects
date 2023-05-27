public class Person
{
    // Attributes
    private string _firstName, _lastName, _type;
    private int _age;

    // Constructors
    public Person()
    {

    }


    // Getters and Setters
    public string GetFirstName()
    {
        return _firstName;
    }
    public void SetFirstName(string name)
    {
        _firstName = name;
    }
     public string GetLastName()
    {
        return _lastName;
    }
    public void SetLastName(string name)
    {
        _lastName = name;
    }
    public string GetPersonType()
    {
        return _type;
    }
    public void SetType(string type)
    {
        _type = type;
    }
    public int GetAge()
    {
        return _age;
    }
    public void SetAge(int age)
    {
        _age = age;
    }

    // Methods
    public bool IsThisNewUser(string first, string last)
    {
        List<string> mylist = new List<string> {"BobJones", "TimGoodwill", "JaniceStegner", "ShelleyMoehle", "JohnMorris"};
        string searchString = first + last;

        return mylist.Contains(searchString);
    }
    public virtual void SaveToFile() // Nothing here
    {

    }
    public virtual void ReadFromFile() // Nothing here
    {

    }
    public virtual string PersonToString() // Nothing here
    {
        return "nothing";
    }
    public virtual void DisplayDash() // Nothing here
    {

    }
}
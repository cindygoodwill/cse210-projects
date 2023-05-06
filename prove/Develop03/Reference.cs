public class Reference
{
    private string _book;
    private int _chapter, _verse, _endVerse;

    public Reference()
    {
    }
    
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public string GetReference()
    {
        if (_endVerse == 0)
        {
            return $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
        
    }

    public void SetReference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public void UserEnterRef()
    {
        Console.WriteLine();
        Console.Write("Book: ");
        string book = Console.ReadLine();

        _book = book;

        Console.Write("Chapter: ");
        string chap = Console.ReadLine();
        int chapNum = int.Parse(chap);

        _chapter = chapNum;

        Console.Write("First verse: ");
        string verseBeg = Console.ReadLine();
        int verseBegNum = int.Parse(verseBeg);

        _verse = verseBegNum;

        Console.Write("End Verse (if none, leave blank): ");
        string endVerse = Console.ReadLine();

        if (endVerse == "")
        {
            _endVerse = 0;
        }

        else 
        {
            _endVerse = int.Parse(endVerse);
        }
        

        
    }
}
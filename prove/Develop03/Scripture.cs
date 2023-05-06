public class Scripture
{
    private string _reference;
    private List<Word> _text;

    public Scripture()
    {
        _text = new List<Word>();
    }
    
    // I don't know if I need this!
    public Scripture(string reference, List<Word> words)
    {
        _reference = reference;
        _text = words;
    }

    public void SetText()
    {
        // Get the text from the user
        Console.WriteLine("Write the scripture here: ");
        Console.Write("> ");
        string response = Console.ReadLine();

        // Split up and put in Word and add to list
        string[] parts = response.Split(' ');

        // Get the length of the list
        int length = parts.Length;

        // count through the length and put each part into Word
        for (int i = 0; i < length; i++)
        {
            Word word = new Word(parts[i]);

            _text.Add(word);
        } 

    }

    public void SetReference(string reference)
    {
        _reference = reference;
    }

    public void DisplayScrip()
    {
        string text = GetRenderedText();
        
        Console.WriteLine(_reference + text);
    }

    public void HideWords() // NOT DONE
    {
        //Variables
        bool _reallyRandom = false;
        
        // Choose random
        while (_reallyRandom == false)
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(0, _text.Count);
            // Test if hidden
            if (_text[number].IsItHidden() == false);
            {
                _text[number].HideWord();
            }
                
            // Hide word      
            
            // Clear consol   
            
            // Display scripture and statement to request user input
        }
    }

    public void UnhideAll() // DONE
    {
        foreach (Word word in _text)
        {
            word.ShowWord();
        }
    }

    public bool IsCompletelyHidden() // DONE
    {
        bool hidden = true;
        foreach (Word word in _text)
        {
            if (word.IsItHidden() == false)
            {
                hidden = false;
                break;
            }
        }
        return hidden;
    }

    public string GetRenderedText() // DONE
    {
        string text = "";

        int count = _text.Count;
        
        foreach (Word word in _text)
        {
            text = text + " " + word.GetWord();
        }

        return text;
    }
}
public class Entry
{
    string _date, _mood, _prompt, _response;

    public Entry(string date, string mood, string prompt, string response)
    {
        _date = date;
        _mood = mood;
        _prompt = prompt;
        _response = response;
    }
    
    public void DisplayEntry() // DONE
    {
        Console.WriteLine($"Date: {_date} | Mood: {_mood} | Prompt: {_prompt}");
        Console.WriteLine(_response);
        Console.WriteLine();
    }

    public string GetEntryAsString()  // DONE

    {
        return string.Format("{0},{1},{2},{3}", _date, _mood, _prompt, _response);
    }

}
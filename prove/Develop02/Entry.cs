public class Entry
{
    string date, mood, prompt, response;

    public Entry(string _date, string _mood, string _prompt, string _response)
    {
        date = _date;
        mood = _mood;
        prompt = _prompt;
        response = _response;
    }
    
    public void DisplayEntry() // DONE
    {
        Console.WriteLine($"Date: {date} | Mood: {mood} | Prompt: {prompt}");
        Console.WriteLine(response);
        Console.WriteLine();
    }

    public string GetEntryAsString()  // DONE

    {
        return string.Format("{0},{1},{2},{3}", date, mood, prompt, response);
    }

}
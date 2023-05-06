public class Word
{
    private string _word, _hiddenWord;
    private bool _isHid = false;

    public Word(string word)
    {
        _word = word;

        int letterCounter = 0;

        foreach (char i in _word)
        {
            if (Char.IsLetter(i))
            {
                letterCounter++;
            }
        }

        _hiddenWord = "";

        for (int i = 0; i < letterCounter; i++)
        {
            _hiddenWord = _hiddenWord + "_";
        }

    }

    public string GetWord()
    {
        return _word;
    }

    public string GetHiddenWord()
    {
        return _hiddenWord;
    }

    public bool IsItHidden()
    {
        return _isHid;
    }

    public void SetWord(string word)
    {
        _word = word;

        int letterCounter = 0;

        foreach (char i in _word)
        {
            if (Char.IsLetter(i))
            {
                letterCounter++;
            }
        }

        _hiddenWord = "";

        for (int i = 0; i < letterCounter; i++)
        {
            _hiddenWord = _hiddenWord + "_";
        }
    }

    public void HideWord() // Done
    {
        if (_isHid == false)
        {
            string tempWord = _word;
            string tempHidWord = _hiddenWord;

            _word = tempHidWord;
            _hiddenWord = tempWord;
            _isHid = true;
        }
        
    }

    public void ShowWord() //NOT Done
    {
        if (_isHid == true)
        {
            string tempWord = _word;
            string tempHidWord = _hiddenWord;

            _word = tempHidWord;
            _hiddenWord = tempWord;
            _isHid = false;
        }
    }

    // public string IsHidden() //NOT Done
    // {
    //     return "";
    // }

    public string GetRenderedText() // Done
    {
        return _word;
    }
}
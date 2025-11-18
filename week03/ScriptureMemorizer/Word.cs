class Word
{
    private string _wordContent;
    private bool _visibility;

    public Word(string content)
    {
        _wordContent = content;
        _visibility = true;
    }

    public void ToggleVisibility()
    {
        _visibility = !_visibility;
    }

    public bool GetVisibility()
    {
        return _visibility;
    }
    
    public string GetDisplay()
    {
        if (_visibility)
        {
            return _wordContent;
        }
        else
        {
            return new string('_', _wordContent.Length);
        }
    }
}
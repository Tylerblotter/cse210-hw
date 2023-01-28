class Entries
{
    public List<string> _entry = new List<string>();
    public string _date = DateTime.Now.ToShortDateString();
    public string _response = "";
    public Entries()
    {

    }
    public List<string> newEntry()
    {
        Prompter prompt1 = new Prompter();
        string prompt = prompt1.sendPrompt();
        Console.Write(prompt);
        _response = Console.ReadLine();
        _entry.Add(_date);
        _entry.Add(prompt);
        _entry.Add(_response);
        return _entry;
    }
}
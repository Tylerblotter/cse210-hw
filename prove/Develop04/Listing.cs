public class Listing : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _items = new List<string>();

    private string _prompt = "";

    public Listing()
    {

    }

    public void ListingActivity()
    {
        getPrompt();
        Console.WriteLine(_prompt);
        DisplayCountdown(5);
        Console.WriteLine("List all of the items you can think of.");
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_seconds);
        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            _items.Add(Console.ReadLine());
            currentTime = DateTime.Now;
        }

        Console.WriteLine($"You listed {_items.Count} items!");
    }   

    public void getPrompt()
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");

        var random = new Random();
        int randNum = random.Next(_prompts.Count);
        string prompt = _prompts[randNum];
        _prompt = prompt;
    }

}
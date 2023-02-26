public class Reflection : Activity
{

    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();
    
    private string _prompt = "";
    private string _question = "";


    public Reflection()
    {
        
    }

    public void ReflectionActivity()
    {
        getPrompt();
        Console.WriteLine(_prompt);
        Thread.Sleep(3000);

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_seconds);
        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            getQuestion();
            Console.WriteLine(_question);
            DisplaySpinner(5);
            currentTime = DateTime.Now;
        }
    }   


    public void getPrompt()
    {
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        var random = new Random();
        int randNum = random.Next(_prompts.Count);
        string prompt = _prompts[randNum];
        _prompt = prompt;
    }
    public void getQuestion()
    {
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?"); 
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?"); 

        var random = new Random();
        int randNum = random.Next(_questions.Count);
        string q = _questions[randNum];
        _question = q;
    }
}
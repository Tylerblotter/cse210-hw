public class Activity
{
    private string _startMessage = "";
    private string _endMessage = "Thank you for participating in this activity. Have a nice day!";

    public int _seconds = 0;

    public Activity()
    {

    }

    public void setStartMessage(string message)
    {
        _startMessage = message;
    }

    public void DisplayStartMessage()
    {
        Console.Clear();
        Console.WriteLine(_startMessage);
        Console.WriteLine("\n\n");
        Thread.Sleep(3000);
    }
    public void DisplayEndMessage()
    {
        Console.WriteLine(_endMessage);
        Thread.Sleep(3000);
        Console.Clear();
    }

    public void InputSeconds()
    {
        Console.Write("how long would you like to do this activity (in seconds)? ");
        int userInput;

        while (!int.TryParse(Console.ReadLine(), out userInput))
        {
            Console.WriteLine("Invalid input. Please enter an integer: ");
        }

        _seconds =  userInput;
    }

    public void DisplaySpinner(int sec)
    {    
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(sec);

        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            Console.Write("        |");
            Thread.Sleep(20);
            Console.Write("\b\b\b\b\b\b\b\b\b"); // Erase the | character
            Console.Write("        /");    // Replace it with the / character
            Thread.Sleep(20);
            Console.Write("\b\b\b\b\b\b\b\b\b"); // Erase the / character
            Console.Write("        -"); // Replace it with the - character
            Thread.Sleep(20);
            Console.Write("\b\b\b\b\b\b\b\b\b"); // Erase the - character
            currentTime = DateTime.Now;
        }
    }

    public void DisplayCountdown(int sec)
    {    
        // Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(sec);

        DateTime currentTime = DateTime.Now;
        int timeSec = sec;
        while (currentTime < futureTime)
        {
            Console.Write(timeSec);
            Thread.Sleep(1000);
            timeSec --;
            Console.Write("\b");
            currentTime = DateTime.Now;
        }
    }
    

}
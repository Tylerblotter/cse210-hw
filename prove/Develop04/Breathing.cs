public class Breathing : Activity
{

    public Breathing()
    {

    }
    
    public void BreathingActivity()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_seconds);

        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            Console.WriteLine("Breath In");
            DisplayCountdown(4);
            Console.WriteLine("Breath Out");
            DisplayCountdown(6);
            currentTime = DateTime.Now;
        }
    }



}
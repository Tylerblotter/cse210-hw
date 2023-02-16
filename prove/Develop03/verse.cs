public class Verse
{
        
    public int StartV { get; set; }
    public int EndV { get; set; }

    private Verse(int startVerse, int endVerse)
    {
        StartV = startVerse;
        EndV = endVerse;
    }
    
}
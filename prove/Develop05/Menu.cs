public class Menu
{

    public Menu()
    {

    }

    public int MainMenu()
    {
        Console.WriteLine("\nPlease select one of the following options");
        Console.WriteLine("0. to quit");
        Console.WriteLine("1. Create a Goal");
        Console.WriteLine("2. Check off a Goal");
        Console.WriteLine("3. See your total Points");
        Console.WriteLine("4. See a list of your goals");
        Console.WriteLine("5. Save your goals");
        Console.WriteLine("6. Load your goals");
        Console.Write(":>");
        return int.Parse(Console.ReadLine());
    }
    public int GoalMenu()
    {
        Console.Clear();
        Console.WriteLine("Which goal would you like to create");
        Console.WriteLine("1. Simple");
        Console.WriteLine("2. Eternal");
        Console.WriteLine("3. Checklist");
        Console.Write(":>");
        return int.Parse(Console.ReadLine());
    }

}
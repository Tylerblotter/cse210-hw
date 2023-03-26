public class Tracker
{

    public int totalPoints = 0;
    public List<Goal> goalList = new List<Goal>();
    public string fileName = "myFile.txt"; 

    public Tracker()
    {
        
    }

    public void AddSimpleGoal()
    {
        Console.Write("What do you want to name this goal: ");
        string nameOfGoal = Console.ReadLine(); 

        Console.Write("How many points is this goal worth: ");
        int pointWorth = int.Parse(Console.ReadLine()); 

        Goal newName = new Goal(nameOfGoal, pointWorth);
        goalList.Add(newName);
    }
    public void AddEternalGoal()
    {
        Console.Write("What do you want to name this goal: ");
        string nameOfGoal = Console.ReadLine(); 

        Console.Write("How many points is this goal worth: ");
        int pointWorth = int.Parse(Console.ReadLine()); 

        Eternal newName = new Eternal(nameOfGoal, pointWorth);
        goalList.Add(newName);
    }
    public void AddChecklistGoal()
    {
        Console.Write("What do you want to name this goal: ");
        string nameOfGoal = Console.ReadLine(); 

        Console.Write("How many points is this goal worth: ");
        int pointWorth = int.Parse(Console.ReadLine()); 

        Console.Write("How many time does this goal need to be completed: ");
        int amount = int.Parse(Console.ReadLine()); 

        Checklist newName = new Checklist(nameOfGoal, pointWorth, amount);
        goalList.Add(newName);
    }

    public void CompleteGoal()
    {
        Console.Write($"Which goal did you complete(1-{goalList.Count}): ");
        int goalNum = int.Parse(Console.ReadLine()) - 1;
        
        if (goalList[goalNum].IsCompleted())
        {
            Console.WriteLine("This goal has already been completed! ");
        }

        else
        {
        goalList[goalNum].MarkCompleted();
        totalPoints += goalList[goalNum].GetPoints();
        }
    }

    public void DisplayPoints()
    {
        Console.WriteLine($"You have {totalPoints} points!");
    }

    public void DisplayGoals()
    {
        if (goalList.Count() == 0)
        {
            Console.WriteLine("You don't have any goals yet!");
        }
        else
        {
            int counter = 0;
            foreach (Goal currentGoal in goalList)
            {
                counter ++;
                string check = "[]";
                // if (typeof(currentGoal).GetProperty("amountGoal"))
                if (currentGoal.IsCompleted())
                    check = "[X]";
                Console.WriteLine($"{counter}: {currentGoal.GetName()}  pnts-{currentGoal.GetPoints()} {currentGoal.DisplayCount()} {check}");
            }
        }
    }
    public string DisplaySaveGoals()
    {
        string saveString = $"Total Points {totalPoints}\n";
        
        if (goalList.Count() == 0)
        {
            return "You don't have any goals yet!";
        }
        else
        {
            int counter = 0;
            foreach (Goal currentGoal in goalList)
            {
                counter ++;
                string check = "[]";
                if (currentGoal.IsCompleted())
                    check = "[X]";
                saveString = saveString + $"{counter}: {currentGoal.GetName()}  pnts-{currentGoal.GetPoints()} {currentGoal.DisplayCount()} {check}\n";
            }
        }
        return saveString;
    }

    public void saveGoals()
    {   
        // Console.Write("What would you like to name this file: ");
        // fileName = Console.ReadLine();
        // fileName = fileName + ".txt";
        Console.WriteLine("");
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            string goalListStr = DisplaySaveGoals();
            outputFile.WriteLine(goalListStr);
        }
    }

    public void loadGoals()
    {
        // Console.Write("What journal would you like to load (name only don't include .txt): ");
        // fileName = Console.ReadLine();
        // fileName = fileName + ".txt";
        Console.WriteLine("");
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }

}
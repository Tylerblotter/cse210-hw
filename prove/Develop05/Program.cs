using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to Goal Tracker");

        Tracker t = new Tracker();
        Menu myMenu = new Menu();
        
        bool run = true;
        while (run == true)
        {
            int userInt = myMenu.MainMenu();
            
            // Exit the while loop.
            if (userInt == 0)
            {
                run = false;
            }
            // Add a new goal
            else if (userInt == 1)
            {
                int goalInt = myMenu.GoalMenu();
                if (goalInt == 1)
                {
                    t.AddSimpleGoal();
                }
                else if (goalInt == 2)
                {
                    t.AddEternalGoal();
                }
                else if (goalInt == 3)
                {
                    t.AddChecklistGoal();
                }
            }
            // Mark a goal as complete
            else if (userInt == 2)
            {
                t.CompleteGoal();
            }
            // Display the total points the user has.
            else if (userInt == 3)
            {
                t.DisplayPoints();
            }
            // Display the goal list.
            else if (userInt == 4)
            {
                Console.Clear();
                t.DisplayGoals();
                Thread.Sleep(3000);
            }
            //Save the file
            else if (userInt == 5)
            {
                t.saveGoals();
            }
            //Load the file
            else if (userInt == 6)
            {
                t.loadGoals();
            }
        }
    }
}
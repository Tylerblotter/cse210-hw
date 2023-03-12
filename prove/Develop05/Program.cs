using System;


public class Program {
    private static List<Goal> goals = new List<Goal>();

    public static void Main() {

        Goal goal1 = new SimpleGoal("Run a marathon", 1000);
        Goal goal2 = new EternalGoals("Read scriptures", 100);
        Goal goal3 = new ChecklistGoal("Attend temple", 50, 10);


        goals.Add(goal1);
        goals.Add(goal2);
        goals.Add(goal3);


        goal1.RecordEvent();
        goal2.RecordEvent();
        goal2.RecordEvent();
        goal3.RecordEvent();
        goal3.RecordEvent();
        goal3.RecordEvent();


        foreach (Goal goal in goals) {
            Console.WriteLine($"{goal.GetName()} - {goal.GetValue()} points");
            Console.WriteLine($"{goal.GetProgress()}");
            Console.WriteLine();
        }
    }
}

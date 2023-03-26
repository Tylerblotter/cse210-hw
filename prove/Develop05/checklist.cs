public class Checklist : Goal
{
    public int amountGoal = 0;
    public int counter = 0;
    public Checklist(string nameOfGoal, int numPoints, int timesChecked) : base(nameOfGoal, numPoints)
    {
        name = nameOfGoal;
        points = numPoints;
        amountGoal = timesChecked;
    }

    public override void MarkCompleted()
    {
        counter ++;
        if (counter >= amountGoal)
        {
            completed = true;
        }
        
        else
        {
            completed = false;
        }
    }

     public override string DisplayCount()
    {
        string checker = $"[{counter}/{amountGoal}]";
        return checker;
    }
}
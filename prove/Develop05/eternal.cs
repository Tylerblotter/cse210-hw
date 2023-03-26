public class Eternal : Goal
{
    public Eternal(string nameOfGoal, int numPoints) : base(nameOfGoal, numPoints)
    {
        name = nameOfGoal;
        points = numPoints;
    }

    public override void MarkCompleted()
    {
        completed = false;
    }

}
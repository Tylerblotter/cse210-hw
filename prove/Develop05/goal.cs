public class Goal
{

    public string name = "";
    public int points = 0;
    public bool completed = false;

    public Goal(string nameOfGoal, int numPoints)
    {
        name = nameOfGoal;
        points = numPoints;
    }
   
    public virtual int GetPoints()
    { 
        return points;
    }

    public string GetName()
    {
        return name;
    }

    public virtual void MarkCompleted()
    {
        completed = true;
    }

    public virtual string DisplayCount()
    {
        return "";
    }

    public bool IsCompleted()
    {
        if (completed)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}
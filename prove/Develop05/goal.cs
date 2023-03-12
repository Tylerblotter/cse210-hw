public abstract class Goal {
    private string name;
    private int value;

    public Goal(string name, int value) {
        this.name = name;
        this.value = value;
    }

    public string GetName() {
        return name;
    }

    public int GetValue() {
        return value;
    }

    // Check if the goal is complete
    public abstract bool IsComplete();

    // Get the progress of the goal
    public abstract string GetProgress();

    // Record an event for the goal
    public abstract void RecordEvent();
}
public class SimpleGoal : Goal {
    private bool completed;

    public SimpleGoal(string name, int value) : base(name, value) {
        completed = false;
    }

    public override bool IsComplete() {
        return completed;
    }

    public override string GetProgress() {
        return completed ? "Completed" : "Not Completed";
    }

    public override void RecordEvent() {
        completed = true;
    }
}
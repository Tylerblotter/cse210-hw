public class ChecklistGoal : Goal {
    private int count;
    private int target;
    private bool completed;

    public ChecklistGoal(string name, int value, int target) : base(name, value) {
        count = 0;
        this.target = target;
        completed = false;
    }

    public override bool IsComplete() {
        return completed;
    }

    public override string GetProgress() {
        return $"Completed {count}/{target} times";
    }

    public override void RecordEvent() {
        count++;
        if (count == target) {
            completed = true;
        }
    }
}


public class EternalGoals : Goal {
    private int count;

    public EternalGoals(string name, int value) : base(name, value) {
        count = 0;
    }

    public override bool IsComplete() {
        return false;
    }

    public override string GetProgress() {
        return $"Recorded {count} times";
    }

    public override void RecordEvent() {
        count++;
    }
}
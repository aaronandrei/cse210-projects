public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
        // Nothing additional needed
    }

    public override int RecordEvent() => _points;

    public override bool IsComplete() => false;

    public override string GetStatus() => $"[∞] {_shortName}";

    public override string GetGoalType() => "EternalGoal";

    public override string Serialize() =>
        $"{GetGoalType()}|{_shortName}|{_description}|{_points}";
}

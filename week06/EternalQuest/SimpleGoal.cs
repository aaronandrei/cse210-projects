public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isComplete = false; // Set completed status to false initially
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return _points;
        }
        return 0;
    }

    public override bool IsComplete() => _isComplete;

    public override string GetStatus() => $"[{(_isComplete ? "X" : " ")}] {_shortName}";

    public override string GetGoalType() => "SimpleGoal";

    public override string Serialize() =>
        $"{GetGoalType()}|{_shortName}|{_description}|{_points}|{_isComplete}";
}

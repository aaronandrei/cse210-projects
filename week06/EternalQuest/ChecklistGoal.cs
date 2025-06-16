public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0; // Start at zero
    }

    public override int RecordEvent()
    {
        if (!IsComplete())
        {
            _amountCompleted++;
            return _amountCompleted == _target ? _points + _bonus : _points;
        }
        return 0;
    }

    public override bool IsComplete() => _amountCompleted >= _target;

    public override string GetStatus() =>
        $"[{(IsComplete() ? "X" : " ")}] {_shortName} -- Completed {_amountCompleted}/{_target}";

    public override string GetGoalType() => "ChecklistGoal";

    public override string Serialize() =>
        $"{GetGoalType()}|{_shortName}|{_description}|{_points}|{_target}|{_bonus}|{_amountCompleted}";
}

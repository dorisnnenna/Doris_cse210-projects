public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points,
                         int targetCount, int bonus)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonus = bonus;
        _currentCount = 0;
    }

    public ChecklistGoal(string name, string description, int points,
                     int targetCount, int bonus, int currentCount)
    : base(name, description, points)
{
    _targetCount = targetCount;
    _bonus = bonus;
    _currentCount = currentCount;
}

    public override int RecordEvent()
    {
        _currentCount++;
        int total = _points;

        if (_currentCount == _targetCount)
        {
            total += _bonus;
        }

        return total;
    }

    public override bool IsComplete()
    {
        return _currentCount >= _targetCount;
    }

    public override string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {_name} ({_description}) -- Completed {_currentCount}/{_targetCount}";
    }

    public override string GetStringRepresentation()
{
    return $"ChecklistGoal|{_name}|{_description}|{_points}|{_currentCount}|{_targetCount}|{_bonus}";
}
}
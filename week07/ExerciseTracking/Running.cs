using System;

public class Running : Activity
{
    private double _distanceMiles;

    public Running(DateTime date, int lengthInMinutes, double distanceMiles)
        : base(date, lengthInMinutes)
    {
        _distanceMiles = distanceMiles;
    }

    public override double GetDistance() => _distanceMiles;

    public override double GetSpeed() => (_distanceMiles / GetLengthInMinutes()) * 60;

    public override double GetPace() => GetLengthInMinutes() / _distanceMiles;
}

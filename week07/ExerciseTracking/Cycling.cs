using System;

public class Cycling : Activity
{
    private double _speedMph;

    public Cycling(DateTime date, int lengthInMinutes, double speedMph)
        : base(date, lengthInMinutes)
    {
        _speedMph = speedMph;
    }

    public override double GetSpeed() => _speedMph;

    public override double GetDistance() => (_speedMph * GetLengthInMinutes()) / 60;

    public override double GetPace() => 60 / _speedMph;
}

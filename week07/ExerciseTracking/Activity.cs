using System;

public abstract class Activity
{
    private DateTime _date;
    private int _lengthInMinutes;

    public Activity(DateTime date, int lengthInMinutes)
    {
        _date = date;
        _lengthInMinutes = lengthInMinutes;
    }

    public DateTime GetDate() => _date;
    public int GetLengthInMinutes() => _lengthInMinutes;

    public abstract double GetDistance(); // in miles or km
    public abstract double GetSpeed();    // mph or kph
    public abstract double GetPace();     // min per mile or km

    public virtual string GetSummary()
    {
        return $"{_date.ToShortDateString()} {GetType().Name} ({_lengthInMinutes} min) - " +
               $"Distance: {GetDistance():0.00} miles, Speed: {GetSpeed():0.00} mph, Pace: {GetPace():0.00} min/mile";
    }
}

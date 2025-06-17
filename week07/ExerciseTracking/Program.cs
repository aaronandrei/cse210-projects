using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(DateTime.Now.AddDays(-2), 30, 3.0),
            new Cycling(DateTime.Now.AddDays(-1), 45, 15.0),
            new Swimming(DateTime.Now, 40, 30)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
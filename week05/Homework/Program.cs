using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Haley Marie", "Statistics");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Kelton Michael", "Geometry", "1.1", "4-5");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Alina Adele", "Creative Writing", "Suspense Stories");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}
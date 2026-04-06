using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment math = new MathAssignment("John Doe", "Fractions", "7.3", "3-10, 20-21");
        WritingAssignment writing = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");

        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());

        Console.WriteLine();

        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());
    }
}
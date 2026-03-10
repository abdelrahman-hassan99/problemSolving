using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("==== Student Marks Calculator ====");
        int studentCount = GetStudentCount();

        List<string> names = new List<string>();
        List<int> marks = new List<int>();

        for (int i = 0; i < studentCount; i++)
        {
            Console.Write($"\nEnter name of student #{i + 1}: ");
            names.Add(Console.ReadLine());

            int mark = GetValidMark(i + 1);
            marks.Add(mark);
        }

        double average = CalculateAverage(marks);
        int highest = GetHighestMark(marks);
        int lowest = GetLowestMark(marks);

        DisplayResults(names, marks, average, highest, lowest);
    }

    static int GetStudentCount()
    {
        int count;
        while (true)
        {
            Console.Write("Enter number of students: ");
            if (int.TryParse(Console.ReadLine(), out count) && count > 0)
                return count;
            Console.WriteLine("Please enter a valid positive number.");
        }
    }

    static int GetValidMark(int studentNumber)
    {
        int mark;
        while (true)
        {
            Console.Write($"Enter marks for student #{studentNumber} (0-100): ");
            if (int.TryParse(Console.ReadLine(), out mark) && mark >= 0 && mark <= 100)
                return mark;
            Console.WriteLine("Please enter a valid mark between 0 and 100.");
        }
    }

    static double CalculateAverage(List<int> marks)
    {
        int sum = 0;
        foreach (int mark in marks)
            sum += mark;
        return (double)sum / marks.Count;
    }

    static int GetHighestMark(List<int> marks)
    {
        int highest = marks[0];
        foreach (int mark in marks)
            if (mark > highest)
                highest = mark;
        return highest;
    }

    static int GetLowestMark(List<int> marks)
    {
        int lowest = marks[0];
        foreach (int mark in marks)
            if (mark < lowest)
                lowest = mark;
        return lowest;
    }

    static void DisplayResults(List<string> names, List<int> marks, double average, int highest, int lowest)
    {
        Console.WriteLine("\n==== Results ====");
        Console.WriteLine("{0,-20} {1,5}", "Student Name", "Mark");
        Console.WriteLine(new string('-', 30));

        for (int i = 0; i < names.Count; i++)
            Console.WriteLine("{0,-20} {1,5}", names[i], marks[i]);

        Console.WriteLine("\nAverage Mark: {0:F2}", average);
        Console.WriteLine("Highest Mark: {0}", highest);
        Console.WriteLine("Lowest Mark: {0}", lowest);
    }
}

using System;
using System.Collections.Generic;

class StudentGrades
{
    private Dictionary<string, string> grades = new Dictionary<string, string>();

    public string this[string subject]
    {
        get
        {
            if (grades.TryGetValue(subject, out string grade))
                return grade;
            else
                return "Not graded";

        }
        set
        {
            grades[subject] = value;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        StudentGrades student = new StudentGrades();

        student["Math"] = "A";        
        student["Science"] = "B+";

        Console.WriteLine($"Math: {student["Math"]}");
        Console.WriteLine($"Science: {student["Science"]}");
        Console.WriteLine($"History: {student["History"]}");  
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static Dictionary<string, List<int>> GroupScoresByStudent(List<(string name, int score)> studentScores)
    {
        var studentDictionary = new Dictionary<string, List<int>>();

        foreach (var item in studentScores)
        {
            if (!studentDictionary.ContainsKey(item.name))
            {
                studentDictionary[item.name] = new List<int>();
            }
            studentDictionary[item.name].Add(item.score);
        }

        return studentDictionary;
    }

    static void CalculateAndPrintAverages(Dictionary<string, List<int>> studentScores)
    {
        foreach (var student in studentScores)
        {
            double average = student.Value.Average();
            Console.WriteLine($"{student.Key}: {average:F0}");
        }
    }

    static void Main()
    {
        var studentScores = new List<(string name, int score)>
        {
            ("Ahmed", 85),
            ("Amr", 90),
            ("Ahmed", 95),
            ("Amr", 82),
            ("Heba", 78)
        };

        var groupedScores = GroupScoresByStudent(studentScores);

        CalculateAndPrintAverages(groupedScores);
    }
}

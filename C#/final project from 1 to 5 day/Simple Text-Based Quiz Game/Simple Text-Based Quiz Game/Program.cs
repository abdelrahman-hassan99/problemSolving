using System;
using System.Collections.Generic;

class Program
{
    // Structure to hold a question and its answer
    public struct QuizQuestion
    {
        public string Question;
        public string[] Options;
        public int CorrectOption;

        public QuizQuestion(string question, string[] options, int correctOption)
        {
            Question = question;
            Options = options;
            CorrectOption = correctOption;
        }
    }

    static void Main()
    {
        Console.WriteLine("==== Welcome to the Quiz Game ====\n");

        List<QuizQuestion> questions = LoadQuestions();
        int score = 0;

        for (int i = 0; i < questions.Count; i++)
        {
            Console.WriteLine($"Q{i + 1}: {questions[i].Question}");
            for (int j = 0; j < questions[i].Options.Length; j++)
            {
                Console.WriteLine($"{j + 1}. {questions[i].Options[j]}");
            }

            int userChoice = GetUserAnswer();

            if (userChoice == questions[i].CorrectOption)
            {
                Console.WriteLine("Correct!\n");
                score++;
            }
            else
            {
                Console.WriteLine($"Wrong! The correct answer was: {questions[i].Options[questions[i].CorrectOption - 1]}\n");
            }
        }

        Console.WriteLine("==== Quiz Finished ====");
        Console.WriteLine($"Your Score: {score}/{questions.Count}");
    }

    static List<QuizQuestion> LoadQuestions()
    {
        return new List<QuizQuestion>
        {
            new QuizQuestion("What is the capital of France?", new string[] { "Berlin", "Madrid", "Paris", "Rome" }, 3),
            new QuizQuestion("Which planet is known as the Red Planet?", new string[] { "Earth", "Mars", "Jupiter", "Venus" }, 2),
            new QuizQuestion("Who wrote 'Romeo and Juliet'?", new string[] { "Mark Twain", "William Shakespeare", "Leo Tolstoy", "Jane Austen" }, 2),
            new QuizQuestion("What is 5 x 6?", new string[] { "30", "25", "35", "40" }, 1)
        };
    }

    static int GetUserAnswer()
    {
        int choice;
        while (true)
        {
            Console.Write("Your answer (1-4): ");
            if (int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= 4)
                return choice;
            Console.WriteLine("Please enter a valid option (1-4).");
        }
    }
}

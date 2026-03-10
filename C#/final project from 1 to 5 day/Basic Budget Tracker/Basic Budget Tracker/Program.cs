using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static List<decimal> incomes = new List<decimal>();
    static List<decimal> expenses = new List<decimal>();
    static string filePath = "budget.txt";

    static void Main()
    {
        Console.WriteLine("==== Basic Budget Tracker ====");

        bool exit = false;
        while (!exit)
        {
            ShowMenu();
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddIncome();
                    break;
                case "2":
                    AddExpense();
                    break;
                case "3":
                    ShowSummary();
                    break;
                case "4":
                    SaveToFile();
                    Console.WriteLine("Data saved. Exiting...");
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option. Try again.\n");
                    break;
            }
        }
    }

    static void ShowMenu()
    {
        Console.WriteLine("\nChoose an option:");
        Console.WriteLine("1. Add Income");
        Console.WriteLine("2. Add Expense");
        Console.WriteLine("3. Show Summary");
        Console.WriteLine("4. Save & Exit");
        Console.Write("Your choice: ");
    }

    static void AddIncome()
    {
        Console.Write("Enter income amount: ");
        if (decimal.TryParse(Console.ReadLine(), out decimal amount) && amount > 0)
        {
            incomes.Add(amount);
            Console.WriteLine("Income added.\n");
        }
        else
        {
            Console.WriteLine("Invalid input. Must be a positive number.\n");
        }
    }

    static void AddExpense()
    {
        Console.Write("Enter expense amount: ");
        if (decimal.TryParse(Console.ReadLine(), out decimal amount) && amount > 0)
        {
            expenses.Add(amount);
            Console.WriteLine("Expense added.\n");
        }
        else
        {
            Console.WriteLine("Invalid input. Must be a positive number.\n");
        }
    }

    static void ShowSummary()
    {
        decimal totalIncome = 0, totalExpense = 0;
        foreach (var i in incomes) totalIncome += i;
        foreach (var e in expenses) totalExpense += e;
        decimal balance = totalIncome - totalExpense;

        Console.WriteLine("\n==== Budget Summary ====");
        Console.WriteLine($"Total Income:     {totalIncome:C}");
        Console.WriteLine($"Total Expenses:   {totalExpense:C}");
        Console.WriteLine($"Current Balance:  {balance:C}\n");
    }

    static void SaveToFile()
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine("=== Budget Report ===");
            writer.WriteLine("Incomes:");
            foreach (var income in incomes)
                writer.WriteLine($"+ {income:C}");

            writer.WriteLine("\nExpenses:");
            foreach (var expense in expenses)
                writer.WriteLine($"- {expense:C}");

            decimal totalIncome = 0, totalExpense = 0;
            foreach (var i in incomes) totalIncome += i;
            foreach (var e in expenses) totalExpense += e;
            decimal balance = totalIncome - totalExpense;

            writer.WriteLine("\nSummary:");
            writer.WriteLine($"Total Income:    {totalIncome:C}");
            writer.WriteLine($"Total Expenses:  {totalExpense:C}");
            writer.WriteLine($"Balance:         {balance:C}");
        }
    }
}

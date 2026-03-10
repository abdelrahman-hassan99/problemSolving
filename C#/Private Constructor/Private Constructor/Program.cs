using System;

public class DatabaseConnection
{
    private static DatabaseConnection instance = null;
    private static readonly object padlock = new object();

    // Private Constructor
    private DatabaseConnection()
    {
        Console.WriteLine("Database connection initialized.");
    }

    // Static Method to Get Instance
    public static DatabaseConnection GetInstance()
    {
        if (instance == null)
        {
            lock (padlock)
            {
                if (instance == null)
                {
                    instance = new DatabaseConnection();
                }
            }
        }
        return instance;
    }

    public void ExecuteQuery(string query)
    {
        Console.WriteLine($"Executing query: {query}");
    }
}

public class SqlQuery
{
    public string? Query { get; set; }

    public void Execute()
    {
        Console.WriteLine($"Executing SQL: {Query}");
        // In a real app, this would execute the query using a database connection
    }
}

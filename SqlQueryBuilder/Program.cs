var builder = new SqlQueryBuilder();

// Without Director (Flexible)
var customQuery = new SqlQueryBuilder()
    .Select("*")
    .From("Orders")
    .Where("Status = 'Shipped'")
    .Build();

customQuery.Execute();
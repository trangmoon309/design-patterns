public class SqlQueryBuilder : ISqlQueryBuilder
{
    private string? _select;
    private string? _from;
    private string? _where;
    private string? _orderBy;

    public ISqlQueryBuilder Select(string columns)
    {
        _select = $"SELECT {columns}";
        return this;
    }

    public ISqlQueryBuilder From(string table)
    {
        _from = $"FROM {table}";
        return this;
    }

    public ISqlQueryBuilder Where(string condition)
    {
        _where = $"WHERE {condition}";
        return this;
    }

    public ISqlQueryBuilder OrderBy(string column, string order)
    {
        _orderBy = $"ORDER BY {column} {order}";
        return this;
    }

    public SqlQuery Build()
    {
        var query = $"{_select} {_from} {_where} {_orderBy}".Trim();
        return new SqlQuery { Query = query };
    }
}

public interface ISqlQueryBuilder
{
    ISqlQueryBuilder Select(string columns);
    ISqlQueryBuilder From(string table);
    ISqlQueryBuilder Where(string condition);
    ISqlQueryBuilder OrderBy(string column, string order);
    SqlQuery Build();
}

using DbUp.Builder;
using DbUp.SqlServer;

public static class SqlServerLogExtensions
{
    public static LogApplicationUpgradeBuilder SqlDatabase(this SupportedDatabaseForLog database, string connectionString)
    {
        var builder = new LogApplicationUpgradeBuilder();
        builder.Configure(c => c.ConnectionManager = new SqlConnectionManager(connectionString));
        return builder;
    }
}

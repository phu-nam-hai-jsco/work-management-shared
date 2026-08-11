namespace QuanLyCongViec.Shared;

public static class Services
{
    /// <summary>
    /// The name of the Web Frontend service.
    /// This service is responsible for hosting the frontend application.
    /// </summary>
    public const string Frontend = "frontend";

    /// <summary>
    /// The name of the Web API service (Aspire resource id).
    /// This service is responsible for hosting the Web API application.
    /// </summary>
    public const string Api = "api";

    /// <summary>
    /// The name of the Database Server service.
    /// This service is responsible for hosting the database server (e.g., PostgreSQL, SQL Server, or SQLite).
    /// </summary>
    public const string DatabaseServer = "dbserver";

    /// <summary>
    /// The name of the Database.
    /// This is the name of the database that will be created and used by the application.
    /// </summary>
    public const string Database = "QuanLyCongViecDb";
}

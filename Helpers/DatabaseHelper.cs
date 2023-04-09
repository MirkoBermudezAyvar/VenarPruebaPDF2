using Microsoft.Data.SqlClient;
public static class DatabaseHelper
{
    private static readonly string connectionString = "Data Source=myServerAddress;Initial Catalog=myDataBase;User Id=myUsername;Password=myPassword;";

    public static SqlConnection GetConnection()
    {
        return new SqlConnection(connectionString);
    }

    public static SqlDataReader ExecuteQuery(string query, SqlParameter[] parameters)
    {
        SqlConnection connection = GetConnection();
        SqlCommand command = new SqlCommand(query, connection);
        command.Parameters.AddRange(parameters);
        connection.Open();
        SqlDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
        return reader;
    }
}
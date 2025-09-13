using MySql.Data.MySqlClient;
namespace OOP_System_Project;

public class DatabaseConnection
{
    private static readonly string server = "localhost";
    private static readonly string database = "OOP_System_Project";
    private static readonly string user_id = "root";
    private static readonly string password = "root";
    private static readonly string Cs = $"server={server};database={database};uid={user_id};pwd={password}";
    protected MySqlConnection connection = new (Cs);

    protected DatabaseConnection()
    {
        connection.Open();
    }
}

public class Crud : DatabaseConnection
{
    void checkUsername()
    {
        var stm = "SELECT VERSION()";
        var cmd = new MySqlCommand(stm, connection);

        var version = cmd.ExecuteScalar().ToString();
        Console.WriteLine($"MySQL version: {version}");
        
        connection.Close();
        Console.WriteLine(connection.State.ToString());
    }

    void registerAccount()
    {
        
    }
    void loginAccount()
    {
        
    }
    void logoutAccount()
    {
        
    }
    void updateAccount()
    {
        
    }
    void e()
    {
        
    }

    void f()
    {
        
    }
    
}


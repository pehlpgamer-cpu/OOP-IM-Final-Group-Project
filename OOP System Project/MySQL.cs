using MySql.Data.MySqlClient;
namespace OOP_System_Project;

public class DatabaseConnection
{
    //
    //
    //
    private static readonly string server = "localhost";
    private static readonly string userid = "root";
    private static readonly string password = "root";
    private static readonly string database = "oop_finalproject";
    private static readonly string Cs = $"server={server};userid={userid};password={password};database={database}";
    protected MySqlConnection connection = new (Cs);
}

public class mySqlCrud : DatabaseConnection
{
    public void checkUsername()
    {
        connection.Open();
        Console.WriteLine(connection.State.ToString());
        var stm = "SELECT VERSION()";
        var cmd = new MySqlCommand(stm, connection);

        var version = cmd.ExecuteScalar().ToString();
        Console.WriteLine($"MySQL version: {version}");
        
        connection.Close();
        Console.WriteLine(connection.State.ToString());
    }

    public void registerAccount()
    {
        connection.Open();
        
        connection.Close();
    }
    public void loginAccount()
    {
        connection.Open();
        
        connection.Close();
    }
    public void logoutAccount()
    {
        connection.Open();
        
        connection.Close();
    }
    public void updateAccount()
    {
        connection.Open();
        
        connection.Close();
    }
    
}


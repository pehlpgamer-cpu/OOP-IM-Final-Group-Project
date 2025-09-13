using MySql.Data.MySqlClient;
namespace OOP_System_Project;

public class DatabaseConnection
{
    private static readonly string server = "localhost";
    private static readonly string database = "oop_finalproject";
    private static readonly string userid = "root";
    private static readonly string password = "root";
    private static readonly string Cs = $@"server={server};database={database};userid={userid};password={password}";
    //@"server=localhost;userid=dbuser;password=s$cret;database=testdb";
    protected MySqlConnection connection = new (Cs);

    protected DatabaseConnection()
    {
        connection.Open();
    }
}

public class mySqlCrud : DatabaseConnection
{
    public void checkUsername()
    {
        Console.WriteLine(connection.State.ToString());
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


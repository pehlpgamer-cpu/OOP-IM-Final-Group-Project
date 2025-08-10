namespace OOP_System_Project;
using MySql.Data.MySqlClient;
public class Global
{
    public static string sessionId;
    public static string cs = @"server=localhost;userid=member;password=s$cret;database=testdb";
    
}

public class theme
{
    public static string button;
    public static string textbox;
    
}

public class accountRoles
{
    const string ADMIN_ROLE = "admin";
    const string USER_ROLE = "user";
}
namespace OOP_System_Project;
using MySql.Data.MySqlClient;
public partial class Auth_login : Form
{
    public Auth_login()
    {
        InitializeComponent();
        /*string cs = "server=localhost;userid=root;password=root;database=oop_finalproject";

        try
        {
            using var con = new MySqlConnection(cs);
            con.Open();
            Console.WriteLine("Connected!!!");
        }
        catch (MySqlException e)
        {
            Console.WriteLine("⚠ ERROR: " + e);
        }*/

        

    }

    private void LoginValidationFeedback()
    {
        if (txtBox_username.Text == string.Empty || txtBox_password.Text == string.Empty) btn_login.BackColor = Color.WhiteSmoke;
        else btn_login.BackColor = Color.LightGreen;
        
        
    }

    private void txtBox_password_TextChanged(object sender, EventArgs e)
    {
        LoginValidationFeedback();
    }

    private void txtBox_username_TextChanged(object sender, EventArgs e)
    {
        LoginValidationFeedback();
    }

    private void btn_login_Click(object sender, EventArgs e)
    {
        mySqlCrud crud = new mySqlCrud();
        crud.checkUsername();
        crud.checkUsername();
        if (txtBox_username.Text == string.Empty && txtBox_password.Text == string.Empty) {
            MessageBox.Show("Please enter username and password");
            return; 
        }
        MessageBox.Show("Login Successful");
    }

    void login()
    {
        var hasher = new PasswordHasher();

        // Hash a password
        string password = "MySecurePassword123!";
        string hashedPassword = hasher.HashPassword(password);
        
        //get pass from db
        string hashedPassFromDb = "dsf";
        string hashedPassword2 = hasher.HashPassword(hashedPassword);
        
        // Verify the password
        
    }

    private void btn_signupForm_Click(object sender, EventArgs e)
    {
        Hide();
        Auth_registration x = new Auth_registration();
        x.ShowDialog();
    }

    private void btn_passwordVisibility_Click(object sender, EventArgs e)
    {
        if (txtBox_password.PasswordChar == '*') {
            txtBox_password.PasswordChar = '\0';
            btn_passwordVisibility.Text = "hide";
        }
        else {
            txtBox_password.PasswordChar = '*';
            btn_passwordVisibility.Text = "view";
        }
    }
}
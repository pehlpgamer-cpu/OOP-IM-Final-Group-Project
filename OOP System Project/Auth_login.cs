using MySqlX.XDevAPI;

namespace OOP_System_Project;
using MySql.Data.MySqlClient;
public partial class Auth_login : Form
{
    
    public Auth_login()
    {
        InitializeComponent();
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
        if (txtBox_username.Text == string.Empty && txtBox_password.Text == string.Empty) {
            MessageBox.Show("Please enter username and password");
            return; 
        }
        MessageBox.Show("Login Successful");
    }

    void login()
    {
        // TODO - if user input -> email/username && password = exists in DB 
        
        // TODO - get password_salt_fromDB
        
        // TODO - bcrypt hash -> password_salt_fromDB + user input password
        
        // TODO - get hashed_passwordFromDB 
        
        // TODO - if ClientSide_hashedPassword == hashed_passwordFromDB
        
        // TODO - store valid session id & open transaction form
        Global.SessionId = "valid_ID";
        
        // TODO - if there's no valid session id
        // TODO - generate new session id and
        Global.SessionId = "New_valid_ID";
        // TODO - send to new session id -> DB
        // TODO - and transaction form
        
        
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

    private void txtBox_username_KeyPress(object sender, KeyPressEventArgs e)
    {
        login();
    }

    private void txtBox_password_KeyPress(object sender, KeyPressEventArgs e)
    {
        login();
    }
}
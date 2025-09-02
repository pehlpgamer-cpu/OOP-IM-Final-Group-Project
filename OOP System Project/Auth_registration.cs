using System.Security.Policy;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;
using System;
using System.Security.Cryptography;
using System.Text;
using Konscious.Security.Cryptography;
namespace OOP_System_Project;

public partial class Auth_registration : Form
{
    
    const int MINIMUM_PASSWORD_LENGTH = 18;
    const int MAXIMUM_PASSWORD_LENGTH = 64;
    const int MINIMUM_USERNAME_LENGTH = 8;
    const int MAXIMUM_USERNAME_LENGTH = 20;
    //const string VALID_USERNAME_CHARS = @"^[a-zA-Z0-9_]+$";
    const string VALID_EMAIL_FORMAT = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
    //const string VALID_PASSWORD_CHARS = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";
    private bool validUsername;
    private bool validEmail;
    private bool validPassword;
    private bool validConfirmPassword;

    private Regex rg_emailFormat = new Regex(VALID_EMAIL_FORMAT);
        
    void validateInput()
    {
        label_usernameInvalidInput.Visible = false;
        label_emailInvalidInput.Visible = false;
        label_passwordInvalidInput.Visible = false;
        label_confirmPasswordInvalidInput.Visible = false;
        
        //Username
        if (string.IsNullOrWhiteSpace(txtBox_username.Text))
        {
            validUsername = false;
            label_usernameInvalidInput.Visible = true;
            label_usernameInvalidInput.Text = "This field is required.";
        }
        else if (txtBox_username.Text.Trim().Length > MAXIMUM_USERNAME_LENGTH)
        {
            validUsername = false;
            label_usernameInvalidInput.Visible = true;
            label_usernameInvalidInput.Text = $"Username can only be a maximum of {MAXIMUM_USERNAME_LENGTH} characters.";
        }

        else if (txtBox_username.Text.Trim().Length < MINIMUM_USERNAME_LENGTH)
        {
            validUsername = false;
            label_usernameInvalidInput.Visible = true;
            label_usernameInvalidInput.Text = $"Username can only be a minimum of {MINIMUM_USERNAME_LENGTH} characters.";
        }
        /*else if (usernameExist)
        {
            validUsername = false;
            label_usernameInvalidInput.Visible = true;
            label_usernameInvalidInput.Text = $"{txtBox_username.Text} already exists.";
        }*/
        else { validUsername = true; }
        
        //email
        if (string.IsNullOrWhiteSpace(txtBox_email.Text))
        {
            validEmail = false;
            label_emailInvalidInput.Visible = true;
            label_emailInvalidInput.Text = "This field is required.";
        }
        else if (!rg_emailFormat.IsMatch(txtBox_email.Text))
        {
            validEmail = false;
            label_emailInvalidInput.Visible = true;
            label_emailInvalidInput.Text = "Invalid email format.";
        }
        else { validEmail = true; }
        
        //password
        if (string.IsNullOrWhiteSpace(txtBox_password.Text))
        {
            validPassword = false;
            label_passwordInvalidInput.Visible = true;
            label_passwordInvalidInput.Text = "This field is required.";
        }
        else if (txtBox_password.Text.Trim().Length > MAXIMUM_PASSWORD_LENGTH)
        {
            validPassword = false;
            label_passwordInvalidInput.Visible = true;
            label_passwordInvalidInput.Text = $"Password can only be a maximum of {MAXIMUM_PASSWORD_LENGTH} characters.";
        }
        else if (txtBox_password.Text.Trim().Length < MINIMUM_PASSWORD_LENGTH)
        {
            validPassword = false;
            label_passwordInvalidInput.Visible = true;
            label_passwordInvalidInput.Text = $"Password can only be a minimum of {MINIMUM_PASSWORD_LENGTH} characters.";
        }
        else { validPassword = true; }
        
        //Confirm Password
        if (string.IsNullOrWhiteSpace(txtBox_confirmPassword.Text))
        {
            validConfirmPassword = false;
            label_confirmPasswordInvalidInput.Visible = true;
            label_confirmPasswordInvalidInput.Text = "This field is required.";
        }
        else if (txtBox_password.Text.Trim() != txtBox_confirmPassword.Text.Trim())
        {
            validConfirmPassword = false;
            label_confirmPasswordInvalidInput.Visible = true;
            label_confirmPasswordInvalidInput.Text = $"Passwords do not match.";
        }
        else { validConfirmPassword = true; }

        //BTN
        if (validUsername && validEmail && validPassword &&
            validConfirmPassword && checkBox_termsAndAgreements.Checked)
        {
            btn_signup.BackColor = Color.LightGreen;
            btn_signup.Enabled = true;
        }
        else
        {
            btn_signup.BackColor = SystemColors.Control;
            btn_signup.Enabled = false;
        }
    }

    void signup()
    {
        var hasher = new PasswordHasher();

        // Hash a password
        string password = txtBox_password.Text;
        string hashedPassword = hasher.HashPassword(password);
        Console.WriteLine($"Hashed Password: {hashedPassword}");
        

    }
    
    
    public Auth_registration()
    {
        InitializeComponent();
        //using var con = new MySqlConnection(Global.cs);
        //con.Open();
        
        
    }
    
    
    private void btn_signup_Click(object sender, EventArgs e)
    {
        
    }
    private void txtBox_username_TextChanged(object sender, EventArgs e) { validateInput(); }
    private void txtBox_email_TextChanged(object sender, EventArgs e) { validateInput(); }
    private void txtBox_password_TextChanged(object sender, EventArgs e) { validateInput(); }
    private void txtBox_confirmPassword_TextChanged(object sender, EventArgs e) { validateInput(); }
    
    //Trim() textboxes
    private void txtBox_username_Leave(object sender, EventArgs e) { txtBox_username.Text = txtBox_username.Text.Trim(); }
    private void txtBox_email_Leave(object sender, EventArgs e) { txtBox_email.Text = txtBox_email.Text.Trim(); }
    private void txtBox_password_Leave(object sender, EventArgs e) { txtBox_password.Text = txtBox_password.Text.Trim(); }
    private void txtBox_confirmPassword_Leave(object sender, EventArgs e) { txtBox_confirmPassword.Text = txtBox_confirmPassword.Text.Trim(); }

    //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    private void btn_termsAndConditionsForm_Click(object sender, EventArgs e) { TermsAndConditions x = new TermsAndConditions(); x.Show(); }
    private void btn_loginForm_Click(object sender, EventArgs e) { Hide(); Auth_login x = new Auth_login(); x.Show(); }
    private void btn_forgotPassword_Click(object sender, EventArgs e) { ResetPassword x = new ResetPassword(); x.Show(); }
    private void btn_passwordVisibility_Click(object sender, EventArgs e) { 
        if (txtBox_password.PasswordChar == '*') { txtBox_password.PasswordChar = '\0'; btn_passwordVisibility.Text = "hide"; }
        else { txtBox_password.PasswordChar = '*'; btn_passwordVisibility.Text = "view"; } }
    private void btn_confirmPasswordVisibility_Click(object sender, EventArgs e) {
        if (txtBox_confirmPassword.PasswordChar == '*') { txtBox_confirmPassword.PasswordChar = '\0'; btn_confirmPasswordVisibility.Text = "hide"; }
        else { txtBox_confirmPassword.PasswordChar = '*'; btn_confirmPasswordVisibility.Text = "view"; } }

    private void btn_generatePassword_Click(object sender, EventArgs e)
    {
        string[] chars = {"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z",
                          "A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z",
                          "1","2","3","4","5","6","7","8","9","0","_","-",".",",","!","&","*"};
        Random rnd = new Random();
        
        string generatedPassword = string.Empty;
        for (int i  = 0; i < MAXIMUM_PASSWORD_LENGTH; i++) 
            generatedPassword += chars[rnd.Next(0, chars.Length)];
        
        txtBox_password.Text = generatedPassword;
        txtBox_confirmPassword.Text = generatedPassword;
        Clipboard.SetText(generatedPassword);
        validateInput();
        //Console.WriteLine(generatedPassword);

    }
//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


private void txtBox_username_KeyPress(object sender, KeyPressEventArgs e)
{
    if (e.KeyChar == (char)Keys.Enter) signup();
}

private void txtBox_email_KeyPress(object sender, KeyPressEventArgs e)
{
    if (e.KeyChar == (char)Keys.Enter) signup();
}

private void txtBox_password_KeyPress(object sender, KeyPressEventArgs e)
{
    if (e.KeyChar == (char)Keys.Enter) signup();
}

private void txtBox_confirmPassword_KeyPress(object sender, KeyPressEventArgs e)
{
    if (e.KeyChar == (char)Keys.Enter) signup();
}
}
using System.Security.Policy;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;
namespace OOP_System_Project;

public partial class Auth_registration : Form
{
    const int MINIMUM_PASSWORD_LENGTH = 18;
    const int MAXIMUM_PASSWORD_LENGTH = 64;
    const int MINIMUM_USERNAME_LENGTH = 8;
    const int MAXIMUM_USERNAME_LENGTH = 20;
    const string VALID_USERNAME_CHARS = @"^[a-zA-Z0-9_]+$";
    const string VALID_EMAIL_FORMAT = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
    const string VALID_PASSWORD_CHARS = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";

    private bool validUsername;
    private bool validEmail;
    private bool validPassword;
    private bool validConfirmPassword;

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
        else { validUsername = true; }
        
        //email
        if (string.IsNullOrWhiteSpace(txtBox_email.Text))
        {
            validEmail = false;
            label_emailInvalidInput.Visible = true;
            label_emailInvalidInput.Text = "This field is required.";
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

        if (validUsername && validEmail && validPassword &&
            validConfirmPassword && checkBox_termsAndAgreements.Checked)
        {
            btn_signup.BackColor = Color.LightGreen;
        }
        else
        {
            btn_signup.Enabled = false;
        }
    }
    public Auth_registration()
    {
        InitializeComponent();
        //using var con = new MySqlConnection(Global.cs);
        //con.Open();
    }
    
    
    private void btn_signup_Click(object sender, EventArgs e)
    {
        
        //username input
        //fetch from DB - username
        //if exist it or not
        
        //email input
        //fetch from DB - email
        //if exist it or not
        
        
    }
    
    private void txtBox_username_TextChanged(object sender, EventArgs e)
    { 
        validateInput();
    }
    

    private void txtBox_email_TextChanged(object sender, EventArgs e)
    {
        validateInput();
    }

    private void txtBox_password_TextChanged(object sender, EventArgs e)
    {
        validateInput();
    }

    private void txtBox_confirmPassword_TextChanged(object sender, EventArgs e)
    {
        if (txtBox_password.Text.Trim() != txtBox_confirmPassword.Text.Trim())
        {
            label_confirmPasswordInvalidInput.Text = "Passwords do not match";
        }
    }
    //Trim() textboxes
    private void txtBox_username_Leave(object sender, EventArgs e) { txtBox_username.Text = txtBox_username.Text.Trim(); }
    private void txtBox_email_Leave(object sender, EventArgs e) { txtBox_email.Text = txtBox_email.Text.Trim(); }
    private void txtBox_password_Leave(object sender, EventArgs e) { txtBox_password.Text = txtBox_password.Text.Trim(); }
    private void txtBox_confirmPassword_Leave(object sender, EventArgs e) { txtBox_confirmPassword.Text = txtBox_confirmPassword.Text.Trim(); }
    
    

    private void checkBox_termsAndAgreements_CheckedChanged(object sender, EventArgs e)
    {
        
    } 
//-------------------------------------------------------------------------------------------------------------------------------------------------------------
    private void btn_termsAndConditionsForm_Click(object sender, EventArgs e) { TermsAndConditions x = new TermsAndConditions(); x.Show(); }
    private void btn_loginForm_Click(object sender, EventArgs e) { Hide(); Auth_login x = new Auth_login(); x.Show(); }
    private void btn_forgotPassword_Click(object sender, EventArgs e) { ResetPassword x = new ResetPassword(); x.Show(); }
    private void btn_passwordVisibility_Click(object sender, EventArgs e) 
    { if (txtBox_password.PasswordChar == '*') { txtBox_password.PasswordChar = '\0'; btn_passwordVisibility.Text = "hide"; }
        else { txtBox_password.PasswordChar = '*'; btn_passwordVisibility.Text = "view"; } }
    private void btn_confirmPasswordVisibility_Click(object sender, EventArgs e) 
    { if (txtBox_confirmPassword.PasswordChar == '*') { txtBox_confirmPassword.PasswordChar = '\0'; btn_confirmPasswordVisibility.Text = "hide"; }
        else { txtBox_confirmPassword.PasswordChar = '*'; btn_confirmPasswordVisibility.Text = "view"; } }

    private void btn_generatePassword_Click(object sender, EventArgs e)
    {
        Random rnd = new Random();
        

    }


    
}
using System.Security.Policy;

namespace OOP_System_Project;

public partial class Auth_registration : Form
{
    public static bool agreedToTermsAndConditions = false;
    public Auth_registration()
    {
        InitializeComponent();
    }
    
    
    private void btn_signup_Click(object sender, EventArgs e)
    {
        
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

    private void btn_confirmPasswordVisibility_Click(object sender, EventArgs e)
    {
        if (txtBox_confirmPassword.PasswordChar == '*') {
            txtBox_confirmPassword.PasswordChar = '\0';
            btn_confirmPasswordVisibility.Text = "hide";
        }
        else {
            txtBox_confirmPassword.PasswordChar = '*';
            btn_confirmPasswordVisibility.Text = "view";
        }
    }
    
    private void SignupValidationFeedback() {
        if (txtBox_username.Text == string.Empty
            || txtBox_email.Text == string.Empty
            || txtBox_password.Text == string.Empty
            || txtBox_confirmPassword.Text == String.Empty
            || checkBox_termsAndAgreements.Checked == false
            || agreedToTermsAndConditions == false) 
            btn_signup.BackColor = Color.WhiteSmoke;
        else btn_signup.BackColor = Color.LightGreen;
    }
    private void txtBox_username_TextChanged(object sender, EventArgs e) { SignupValidationFeedback();}
    private void txtBox_email_TextChanged(object sender, EventArgs e) { SignupValidationFeedback();}
    private void txtBox_password_TextChanged(object sender, EventArgs e) { SignupValidationFeedback();}
    private void txtBox_confirmPassword_TextChanged(object sender, EventArgs e) { SignupValidationFeedback();}

    private void checkBox_termsAndAgreements_CheckedChanged(object sender, EventArgs e)
    {
        if (agreedToTermsAndConditions) {
            agreedToTermsAndConditions = false;
            checkBox_termsAndAgreements.Checked = false;
        }
        else {
            agreedToTermsAndConditions = true;
            checkBox_termsAndAgreements.Checked = true;
        }
        SignupValidationFeedback();
    }

    private void btn_termsAndConditionsForm_Click(object sender, EventArgs e)
    {
        TermsAndConditions x = new TermsAndConditions();
        x.Show();
    }

    private void btn_loginForm_Click(object sender, EventArgs e)
    {
        Hide();
        Auth_login x = new Auth_login();
        x.Show();
    }

    private void btn_forgotPassword_Click(object sender, EventArgs e)
    {
        TermsAndConditions x = new TermsAndConditions();
        x.Show();
    }

    private void btn_generatePassword_Click(object sender, EventArgs e)
    {
        Random rnd = new Random();

    }
}
namespace OOP_System_Project;

public partial class Auth_login : Form
{
    public Auth_login()
    {
        InitializeComponent();
    }

    private void txtBox_password_TextChanged(object sender, EventArgs e)
    {
        
    }

    private void txtBox_username_TextChanged(object sender, EventArgs e)
    {
        
    }

    private void btn_login_Click(object sender, EventArgs e)
    {
        if (txtBox_username.Text == string.Empty && txtBox_password.Text == string.Empty) {
            MessageBox.Show("Please enter username and password");
            return;
        }
        MessageBox.Show("Login Successfull");
    }
}
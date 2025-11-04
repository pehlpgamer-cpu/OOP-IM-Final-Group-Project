namespace OOP_System_Project;

public partial class TermsAndConditions : Form
{
    public TermsAndConditions()
    {
        InitializeComponent();
    }

    private void btn_agree_Click(object sender, EventArgs e)
    {
        Auth_registration.IAgreeToTermsAndConditions();
        Close();
    }
}
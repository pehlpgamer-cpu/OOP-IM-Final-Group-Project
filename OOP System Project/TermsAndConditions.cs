namespace OOP_System_Project;

public partial class TermsAndConditions : Form
{
    public TermsAndConditions()
    {
        InitializeComponent();
    }

    private void btn_agree_Click(object sender, EventArgs e)
    {
        Auth_registration.IAgreeToTermsAndConditions(true);
        Close();
    }

    private void btn_IDontAgree_Click(object sender, EventArgs e)
    {
        Auth_registration.IAgreeToTermsAndConditions(false);
        Close();
    }
}
using System.ComponentModel;

namespace OOP_System_Project;

partial class Auth_registration
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        txtBox_username = new System.Windows.Forms.TextBox();
        btn_signup = new System.Windows.Forms.Button();
        txtBox_email = new System.Windows.Forms.TextBox();
        txtBox_password = new System.Windows.Forms.TextBox();
        txtBox_confirmPassword = new System.Windows.Forms.TextBox();
        btn_generatePassword = new System.Windows.Forms.Button();
        btn_confirmPasswordVisibility = new System.Windows.Forms.Button();
        btn_passwordVisibility = new System.Windows.Forms.Button();
        checkBox_termsAndAgreements = new System.Windows.Forms.CheckBox();
        btn_termsAndConditionsForm = new System.Windows.Forms.Button();
        btn_loginForm = new System.Windows.Forms.Button();
        btn_forgotPassword = new System.Windows.Forms.Button();
        label_usernameInvalidInput = new System.Windows.Forms.Label();
        label_emailInvalidInput = new System.Windows.Forms.Label();
        label_passwordInvalidInput = new System.Windows.Forms.Label();
        label_confirmPasswordInvalidInput = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // txtBox_username
        // 
        txtBox_username.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtBox_username.Location = new System.Drawing.Point(34, 36);
        txtBox_username.Name = "txtBox_username";
        txtBox_username.PlaceholderText = "username";
        txtBox_username.Size = new System.Drawing.Size(418, 34);
        txtBox_username.TabIndex = 0;
        txtBox_username.TextChanged += txtBox_username_TextChanged;
        txtBox_username.KeyPress += txtBox_username_KeyPress;
        txtBox_username.Leave += txtBox_username_Leave;
        // 
        // btn_signup
        // 
        btn_signup.Enabled = false;
        btn_signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btn_signup.Font = new System.Drawing.Font("Segoe UI", 10F);
        btn_signup.ForeColor = System.Drawing.SystemColors.ControlText;
        btn_signup.Location = new System.Drawing.Point(146, 522);
        btn_signup.Name = "btn_signup";
        btn_signup.Size = new System.Drawing.Size(191, 49);
        btn_signup.TabIndex = 1;
        btn_signup.Text = "Signup";
        btn_signup.UseVisualStyleBackColor = true;
        btn_signup.Click += btn_signup_Click;
        // 
        // txtBox_email
        // 
        txtBox_email.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtBox_email.Location = new System.Drawing.Point(34, 99);
        txtBox_email.Name = "txtBox_email";
        txtBox_email.PlaceholderText = "email";
        txtBox_email.Size = new System.Drawing.Size(418, 34);
        txtBox_email.TabIndex = 2;
        txtBox_email.TextChanged += txtBox_email_TextChanged;
        txtBox_email.KeyPress += txtBox_email_KeyPress;
        txtBox_email.Leave += txtBox_email_Leave;
        // 
        // txtBox_password
        // 
        txtBox_password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtBox_password.Location = new System.Drawing.Point(34, 162);
        txtBox_password.MaxLength = 64;
        txtBox_password.Name = "txtBox_password";
        txtBox_password.PasswordChar = '*';
        txtBox_password.PlaceholderText = "password";
        txtBox_password.Size = new System.Drawing.Size(303, 34);
        txtBox_password.TabIndex = 3;
        txtBox_password.TextChanged += txtBox_password_TextChanged;
        txtBox_password.KeyPress += txtBox_password_KeyPress;
        txtBox_password.Leave += txtBox_password_Leave;
        // 
        // txtBox_confirmPassword
        // 
        txtBox_confirmPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtBox_confirmPassword.Location = new System.Drawing.Point(34, 225);
        txtBox_confirmPassword.Name = "txtBox_confirmPassword";
        txtBox_confirmPassword.PasswordChar = '*';
        txtBox_confirmPassword.PlaceholderText = "confirm password";
        txtBox_confirmPassword.Size = new System.Drawing.Size(352, 34);
        txtBox_confirmPassword.TabIndex = 4;
        txtBox_confirmPassword.TextChanged += txtBox_confirmPassword_TextChanged;
        txtBox_confirmPassword.KeyPress += txtBox_confirmPassword_KeyPress;
        txtBox_confirmPassword.Leave += txtBox_confirmPassword_Leave;
        // 
        // btn_generatePassword
        // 
        btn_generatePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btn_generatePassword.Font = new System.Drawing.Font("Segoe UI", 10F);
        btn_generatePassword.ForeColor = System.Drawing.SystemColors.ControlText;
        btn_generatePassword.Location = new System.Drawing.Point(343, 162);
        btn_generatePassword.Name = "btn_generatePassword";
        btn_generatePassword.Size = new System.Drawing.Size(43, 34);
        btn_generatePassword.TabIndex = 5;
        btn_generatePassword.Text = "🎲";
        btn_generatePassword.UseVisualStyleBackColor = true;
        btn_generatePassword.Click += btn_generatePassword_Click;
        // 
        // btn_confirmPasswordVisibility
        // 
        btn_confirmPasswordVisibility.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btn_confirmPasswordVisibility.Font = new System.Drawing.Font("Segoe UI", 10F);
        btn_confirmPasswordVisibility.ForeColor = System.Drawing.SystemColors.ControlText;
        btn_confirmPasswordVisibility.Location = new System.Drawing.Point(392, 225);
        btn_confirmPasswordVisibility.Name = "btn_confirmPasswordVisibility";
        btn_confirmPasswordVisibility.Size = new System.Drawing.Size(60, 34);
        btn_confirmPasswordVisibility.TabIndex = 7;
        btn_confirmPasswordVisibility.Text = "view";
        btn_confirmPasswordVisibility.UseVisualStyleBackColor = true;
        btn_confirmPasswordVisibility.Click += btn_confirmPasswordVisibility_Click;
        // 
        // btn_passwordVisibility
        // 
        btn_passwordVisibility.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btn_passwordVisibility.Font = new System.Drawing.Font("Segoe UI", 10F);
        btn_passwordVisibility.ForeColor = System.Drawing.SystemColors.ControlText;
        btn_passwordVisibility.Location = new System.Drawing.Point(392, 162);
        btn_passwordVisibility.Name = "btn_passwordVisibility";
        btn_passwordVisibility.Size = new System.Drawing.Size(60, 34);
        btn_passwordVisibility.TabIndex = 8;
        btn_passwordVisibility.Text = "view";
        btn_passwordVisibility.UseVisualStyleBackColor = true;
        btn_passwordVisibility.Click += btn_passwordVisibility_Click;
        // 
        // checkBox_termsAndAgreements
        // 
        checkBox_termsAndAgreements.Font = new System.Drawing.Font("Segoe UI", 10F);
        checkBox_termsAndAgreements.Location = new System.Drawing.Point(34, 288);
        checkBox_termsAndAgreements.Name = "checkBox_termsAndAgreements";
        checkBox_termsAndAgreements.Size = new System.Drawing.Size(382, 54);
        checkBox_termsAndAgreements.TabIndex = 9;
        checkBox_termsAndAgreements.Text = "Do you agree with the terms and conditions?";
        checkBox_termsAndAgreements.UseVisualStyleBackColor = true;
        // 
        // btn_termsAndConditionsForm
        // 
        btn_termsAndConditionsForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btn_termsAndConditionsForm.Font = new System.Drawing.Font("Segoe UI", 10F);
        btn_termsAndConditionsForm.ForeColor = System.Drawing.SystemColors.ControlText;
        btn_termsAndConditionsForm.Location = new System.Drawing.Point(422, 297);
        btn_termsAndConditionsForm.Name = "btn_termsAndConditionsForm";
        btn_termsAndConditionsForm.Size = new System.Drawing.Size(30, 35);
        btn_termsAndConditionsForm.TabIndex = 10;
        btn_termsAndConditionsForm.Text = "❓";
        btn_termsAndConditionsForm.UseVisualStyleBackColor = true;
        btn_termsAndConditionsForm.Click += btn_termsAndConditionsForm_Click;
        // 
        // btn_loginForm
        // 
        btn_loginForm.FlatAppearance.BorderSize = 0;
        btn_loginForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btn_loginForm.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btn_loginForm.ForeColor = System.Drawing.SystemColors.ControlText;
        btn_loginForm.Location = new System.Drawing.Point(206, 616);
        btn_loginForm.Name = "btn_loginForm";
        btn_loginForm.Size = new System.Drawing.Size(81, 33);
        btn_loginForm.TabIndex = 11;
        btn_loginForm.Text = "Login?";
        btn_loginForm.UseVisualStyleBackColor = true;
        btn_loginForm.Click += btn_loginForm_Click;
        // 
        // btn_forgotPassword
        // 
        btn_forgotPassword.FlatAppearance.BorderSize = 0;
        btn_forgotPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btn_forgotPassword.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btn_forgotPassword.ForeColor = System.Drawing.SystemColors.ControlText;
        btn_forgotPassword.Location = new System.Drawing.Point(169, 577);
        btn_forgotPassword.Name = "btn_forgotPassword";
        btn_forgotPassword.Size = new System.Drawing.Size(153, 33);
        btn_forgotPassword.TabIndex = 12;
        btn_forgotPassword.Text = "forgot password?";
        btn_forgotPassword.UseVisualStyleBackColor = true;
        btn_forgotPassword.Click += btn_forgotPassword_Click;
        // 
        // label_usernameInvalidInput
        // 
        label_usernameInvalidInput.AutoSize = true;
        label_usernameInvalidInput.BackColor = System.Drawing.SystemColors.Control;
        label_usernameInvalidInput.Font = new System.Drawing.Font("Segoe UI", 10F);
        label_usernameInvalidInput.ForeColor = System.Drawing.Color.Red;
        label_usernameInvalidInput.Location = new System.Drawing.Point(34, 73);
        label_usernameInvalidInput.Name = "label_usernameInvalidInput";
        label_usernameInvalidInput.Size = new System.Drawing.Size(55, 23);
        label_usernameInvalidInput.TabIndex = 13;
        label_usernameInvalidInput.Text = "label1";
        label_usernameInvalidInput.Visible = false;
        // 
        // label_emailInvalidInput
        // 
        label_emailInvalidInput.AutoSize = true;
        label_emailInvalidInput.BackColor = System.Drawing.SystemColors.Control;
        label_emailInvalidInput.Font = new System.Drawing.Font("Segoe UI", 10F);
        label_emailInvalidInput.ForeColor = System.Drawing.Color.Red;
        label_emailInvalidInput.Location = new System.Drawing.Point(34, 136);
        label_emailInvalidInput.Name = "label_emailInvalidInput";
        label_emailInvalidInput.Size = new System.Drawing.Size(55, 23);
        label_emailInvalidInput.TabIndex = 14;
        label_emailInvalidInput.Text = "label2";
        label_emailInvalidInput.Visible = false;
        // 
        // label_passwordInvalidInput
        // 
        label_passwordInvalidInput.AutoSize = true;
        label_passwordInvalidInput.BackColor = System.Drawing.SystemColors.Control;
        label_passwordInvalidInput.Font = new System.Drawing.Font("Segoe UI", 10F);
        label_passwordInvalidInput.ForeColor = System.Drawing.Color.Red;
        label_passwordInvalidInput.Location = new System.Drawing.Point(34, 199);
        label_passwordInvalidInput.Name = "label_passwordInvalidInput";
        label_passwordInvalidInput.Size = new System.Drawing.Size(55, 23);
        label_passwordInvalidInput.TabIndex = 15;
        label_passwordInvalidInput.Text = "label3";
        label_passwordInvalidInput.Visible = false;
        // 
        // label_confirmPasswordInvalidInput
        // 
        label_confirmPasswordInvalidInput.AutoSize = true;
        label_confirmPasswordInvalidInput.BackColor = System.Drawing.SystemColors.Control;
        label_confirmPasswordInvalidInput.Font = new System.Drawing.Font("Segoe UI", 10F);
        label_confirmPasswordInvalidInput.ForeColor = System.Drawing.Color.Red;
        label_confirmPasswordInvalidInput.Location = new System.Drawing.Point(34, 262);
        label_confirmPasswordInvalidInput.Name = "label_confirmPasswordInvalidInput";
        label_confirmPasswordInvalidInput.Size = new System.Drawing.Size(55, 23);
        label_confirmPasswordInvalidInput.TabIndex = 16;
        label_confirmPasswordInvalidInput.Text = "label4";
        label_confirmPasswordInvalidInput.Visible = false;
        // 
        // Auth_registration
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(490, 673);
        Controls.Add(label_confirmPasswordInvalidInput);
        Controls.Add(label_passwordInvalidInput);
        Controls.Add(label_emailInvalidInput);
        Controls.Add(label_usernameInvalidInput);
        Controls.Add(btn_forgotPassword);
        Controls.Add(btn_loginForm);
        Controls.Add(btn_termsAndConditionsForm);
        Controls.Add(checkBox_termsAndAgreements);
        Controls.Add(btn_passwordVisibility);
        Controls.Add(btn_confirmPasswordVisibility);
        Controls.Add(btn_generatePassword);
        Controls.Add(txtBox_confirmPassword);
        Controls.Add(txtBox_password);
        Controls.Add(txtBox_email);
        Controls.Add(btn_signup);
        Controls.Add(txtBox_username);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Auth_registration";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label label_emailInvalidInput;
    private System.Windows.Forms.Label label_passwordInvalidInput;
    private System.Windows.Forms.Label label_confirmPasswordInvalidInput;

    private System.Windows.Forms.Label label_usernameInvalidInput;

    private System.Windows.Forms.Button btn_forgotPassword;

    private System.Windows.Forms.Button btn_loginForm;

    private System.Windows.Forms.Button btn_termsAndConditionsForm;

    private System.Windows.Forms.CheckBox checkBox_termsAndAgreements;

    private System.Windows.Forms.Button btn_generatePassword;
    private System.Windows.Forms.Button btn_confirmPasswordVisibility;
    private System.Windows.Forms.Button btn_passwordVisibility;

    private System.Windows.Forms.TextBox txtBox_email;
    private System.Windows.Forms.TextBox txtBox_password;
    private System.Windows.Forms.TextBox txtBox_confirmPassword;

    private System.Windows.Forms.Button btn_signup;

    private System.Windows.Forms.TextBox txtBox_username;

    #endregion
}
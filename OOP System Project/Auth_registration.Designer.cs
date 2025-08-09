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
        checkBox1 = new System.Windows.Forms.CheckBox();
        SuspendLayout();
        // 
        // txtBox_username
        // 
        txtBox_username.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtBox_username.Location = new System.Drawing.Point(271, 28);
        txtBox_username.Name = "txtBox_username";
        txtBox_username.PlaceholderText = "username";
        txtBox_username.Size = new System.Drawing.Size(187, 34);
        txtBox_username.TabIndex = 0;
        txtBox_username.TextChanged += txtBox_username_TextChanged;
        // 
        // btn_signup
        // 
        btn_signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btn_signup.Font = new System.Drawing.Font("Segoe UI", 10F);
        btn_signup.ForeColor = System.Drawing.SystemColors.ControlText;
        btn_signup.Location = new System.Drawing.Point(304, 302);
        btn_signup.Name = "btn_signup";
        btn_signup.Size = new System.Drawing.Size(122, 49);
        btn_signup.TabIndex = 1;
        btn_signup.Text = "Signup";
        btn_signup.UseVisualStyleBackColor = true;
        btn_signup.Click += btn_signup_Click;
        // 
        // txtBox_email
        // 
        txtBox_email.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtBox_email.Location = new System.Drawing.Point(271, 68);
        txtBox_email.Name = "txtBox_email";
        txtBox_email.PlaceholderText = "email";
        txtBox_email.Size = new System.Drawing.Size(187, 34);
        txtBox_email.TabIndex = 2;
        txtBox_email.TextChanged += txtBox_email_TextChanged;
        // 
        // txtBox_password
        // 
        txtBox_password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtBox_password.Location = new System.Drawing.Point(271, 108);
        txtBox_password.Name = "txtBox_password";
        txtBox_password.PlaceholderText = "password";
        txtBox_password.Size = new System.Drawing.Size(187, 34);
        txtBox_password.TabIndex = 3;
        txtBox_password.TextChanged += txtBox_password_TextChanged;
        // 
        // txtBox_confirmPassword
        // 
        txtBox_confirmPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtBox_confirmPassword.Location = new System.Drawing.Point(271, 153);
        txtBox_confirmPassword.Name = "txtBox_confirmPassword";
        txtBox_confirmPassword.PlaceholderText = "confirm password";
        txtBox_confirmPassword.Size = new System.Drawing.Size(187, 34);
        txtBox_confirmPassword.TabIndex = 4;
        txtBox_confirmPassword.TextChanged += txtBox_confirmPassword_TextChanged;
        // 
        // btn_generatePassword
        // 
        btn_generatePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btn_generatePassword.Font = new System.Drawing.Font("Segoe UI", 10F);
        btn_generatePassword.ForeColor = System.Drawing.SystemColors.ControlText;
        btn_generatePassword.Location = new System.Drawing.Point(530, 153);
        btn_generatePassword.Name = "btn_generatePassword";
        btn_generatePassword.Size = new System.Drawing.Size(43, 34);
        btn_generatePassword.TabIndex = 5;
        btn_generatePassword.Text = "🎲";
        btn_generatePassword.UseVisualStyleBackColor = true;
        // 
        // btn_confirmPasswordVisibility
        // 
        btn_confirmPasswordVisibility.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btn_confirmPasswordVisibility.Font = new System.Drawing.Font("Segoe UI", 10F);
        btn_confirmPasswordVisibility.ForeColor = System.Drawing.SystemColors.ControlText;
        btn_confirmPasswordVisibility.Location = new System.Drawing.Point(464, 153);
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
        btn_passwordVisibility.Location = new System.Drawing.Point(464, 108);
        btn_passwordVisibility.Name = "btn_passwordVisibility";
        btn_passwordVisibility.Size = new System.Drawing.Size(60, 34);
        btn_passwordVisibility.TabIndex = 8;
        btn_passwordVisibility.Text = "view";
        btn_passwordVisibility.UseVisualStyleBackColor = true;
        btn_passwordVisibility.Click += btn_passwordVisibility_Click;
        // 
        // checkBox1
        // 
        checkBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
        checkBox1.Location = new System.Drawing.Point(271, 205);
        checkBox1.Name = "checkBox1";
        checkBox1.Size = new System.Drawing.Size(144, 34);
        checkBox1.TabIndex = 9;
        checkBox1.Text = "checkBox1";
        checkBox1.UseVisualStyleBackColor = true;
        // 
        // Auth_registration
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(checkBox1);
        Controls.Add(btn_passwordVisibility);
        Controls.Add(btn_confirmPasswordVisibility);
        Controls.Add(btn_generatePassword);
        Controls.Add(txtBox_confirmPassword);
        Controls.Add(txtBox_password);
        Controls.Add(txtBox_email);
        Controls.Add(btn_signup);
        Controls.Add(txtBox_username);
        Text = "Auth_registration";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.CheckBox checkBox1;

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
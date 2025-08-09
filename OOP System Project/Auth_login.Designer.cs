namespace OOP_System_Project;

partial class Auth_login
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
        txtBox_password = new System.Windows.Forms.TextBox();
        txtBox_username = new System.Windows.Forms.TextBox();
        btn_login = new System.Windows.Forms.Button();
        btn_passwordVisibility = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // txtBox_password
        // 
        txtBox_password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtBox_password.Location = new System.Drawing.Point(280, 150);
        txtBox_password.Name = "txtBox_password";
        txtBox_password.Size = new System.Drawing.Size(171, 34);
        txtBox_password.TabIndex = 1;
        txtBox_password.TextChanged += txtBox_password_TextChanged;
        // 
        // txtBox_username
        // 
        txtBox_username.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtBox_username.Location = new System.Drawing.Point(280, 94);
        txtBox_username.Name = "txtBox_username";
        txtBox_username.Size = new System.Drawing.Size(171, 34);
        txtBox_username.TabIndex = 0;
        txtBox_username.TextChanged += txtBox_username_TextChanged;
        // 
        // btn_login
        // 
        btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btn_login.Font = new System.Drawing.Font("Segoe UI", 10F);
        btn_login.Location = new System.Drawing.Point(336, 212);
        btn_login.Name = "btn_login";
        btn_login.Size = new System.Drawing.Size(75, 36);
        btn_login.TabIndex = 4;
        btn_login.Text = "Login";
        btn_login.UseVisualStyleBackColor = true;
        btn_login.Click += btn_login_Click;
        // 
        // btn_passwordVisibility
        // 
        btn_passwordVisibility.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btn_passwordVisibility.Font = new System.Drawing.Font("Segoe UI", 10F);
        btn_passwordVisibility.Location = new System.Drawing.Point(457, 150);
        btn_passwordVisibility.Name = "btn_passwordVisibility";
        btn_passwordVisibility.Size = new System.Drawing.Size(75, 34);
        btn_passwordVisibility.TabIndex = 5;
        btn_passwordVisibility.Text = "view";
        btn_passwordVisibility.UseVisualStyleBackColor = true;
        // 
        // Auth_login
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.Control;
        ClientSize = new System.Drawing.Size(754, 450);
        Controls.Add(btn_passwordVisibility);
        Controls.Add(btn_login);
        Controls.Add(txtBox_password);
        Controls.Add(txtBox_username);
        Location = new System.Drawing.Point(19, 19);
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button btn_passwordVisibility;

    private System.Windows.Forms.Button btn_login;

    private System.Windows.Forms.TextBox txtBox_password;
    private System.Windows.Forms.TextBox txtBox_username;

    #endregion
}
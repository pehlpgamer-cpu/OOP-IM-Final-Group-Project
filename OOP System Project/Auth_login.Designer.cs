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
        txtBox_username = new System.Windows.Forms.TextBox();
        txtBox_password = new System.Windows.Forms.TextBox();
        SuspendLayout();
        // 
        // txtBox_username
        // 
        txtBox_username.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtBox_username.Location = new System.Drawing.Point(127, 32);
        txtBox_username.Name = "txtBox_username";
        txtBox_username.Size = new System.Drawing.Size(171, 34);
        txtBox_username.TabIndex = 0;
        // 
        // txtBox_password
        // 
        txtBox_password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtBox_password.Location = new System.Drawing.Point(127, 109);
        txtBox_password.Name = "txtBox_password";
        txtBox_password.Size = new System.Drawing.Size(171, 34);
        txtBox_password.TabIndex = 1;
        // 
        // Auth_login
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(754, 450);
        Controls.Add(txtBox_password);
        Controls.Add(txtBox_username);
        Text = "Login";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox txtBox_password;

    private System.Windows.Forms.TextBox txtBox_username;

    #endregion
}
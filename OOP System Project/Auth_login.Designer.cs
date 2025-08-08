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
        SuspendLayout();
        // 
        // txtBox_username
        // 
        txtBox_username.Location = new System.Drawing.Point(235, 48);
        txtBox_username.Name = "txtBox_username";
        txtBox_username.Size = new System.Drawing.Size(100, 27);
        txtBox_username.TabIndex = 0;
        // 
        // Auth_login
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(754, 450);
        Controls.Add(txtBox_username);
        Text = "Login";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox txtBox_username;

    #endregion
}
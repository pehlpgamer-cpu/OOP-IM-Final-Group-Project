using System.ComponentModel;

namespace OOP_System_Project;

partial class ResetPassword
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
        txtBox_passwordResetCode = new System.Windows.Forms.TextBox();
        btn_resetPassword = new System.Windows.Forms.Button();
        button1 = new System.Windows.Forms.Button();
        txtBox_ConfirmNewPassword = new System.Windows.Forms.TextBox();
        txtBox_newPassword = new System.Windows.Forms.TextBox();
        SuspendLayout();
        // 
        // txtBox_passwordResetCode
        // 
        txtBox_passwordResetCode.Font = new System.Drawing.Font("Segoe UI", 12F);
        txtBox_passwordResetCode.Location = new System.Drawing.Point(12, 12);
        txtBox_passwordResetCode.Name = "txtBox_passwordResetCode";
        txtBox_passwordResetCode.PlaceholderText = "reset code";
        txtBox_passwordResetCode.Size = new System.Drawing.Size(213, 34);
        txtBox_passwordResetCode.TabIndex = 0;
        // 
        // btn_resetPassword
        // 
        btn_resetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btn_resetPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
        btn_resetPassword.Location = new System.Drawing.Point(12, 161);
        btn_resetPassword.Name = "btn_resetPassword";
        btn_resetPassword.Size = new System.Drawing.Size(213, 53);
        btn_resetPassword.TabIndex = 1;
        btn_resetPassword.Text = "Submit";
        btn_resetPassword.UseVisualStyleBackColor = true;
        // 
        // button1
        // 
        button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        button1.Font = new System.Drawing.Font("Segoe UI", 10F);
        button1.Location = new System.Drawing.Point(12, 220);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(213, 33);
        button1.TabIndex = 2;
        button1.Text = "Resend Code";
        button1.UseVisualStyleBackColor = true;
        // 
        // txtBox_ConfirmNewPassword
        // 
        txtBox_ConfirmNewPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
        txtBox_ConfirmNewPassword.Location = new System.Drawing.Point(12, 99);
        txtBox_ConfirmNewPassword.Name = "txtBox_ConfirmNewPassword";
        txtBox_ConfirmNewPassword.PlaceholderText = "confirm new pass";
        txtBox_ConfirmNewPassword.Size = new System.Drawing.Size(213, 34);
        txtBox_ConfirmNewPassword.TabIndex = 3;
        // 
        // txtBox_newPassword
        // 
        txtBox_newPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
        txtBox_newPassword.Location = new System.Drawing.Point(12, 52);
        txtBox_newPassword.Name = "txtBox_newPassword";
        txtBox_newPassword.PlaceholderText = "new pass";
        txtBox_newPassword.Size = new System.Drawing.Size(213, 34);
        txtBox_newPassword.TabIndex = 4;
        // 
        // ResetPassword
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(258, 268);
        Controls.Add(txtBox_newPassword);
        Controls.Add(txtBox_ConfirmNewPassword);
        Controls.Add(button1);
        Controls.Add(btn_resetPassword);
        Controls.Add(txtBox_passwordResetCode);
        Text = "ResetPassword";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TextBox txtBox_ConfirmNewPassword;
    private System.Windows.Forms.TextBox txtBox_newPassword;

    private System.Windows.Forms.TextBox txtBox_passwordResetCode;
    private System.Windows.Forms.Button btn_resetPassword;

    #endregion
}
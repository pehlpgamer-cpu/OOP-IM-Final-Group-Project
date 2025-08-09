using System.ComponentModel;

namespace OOP_System_Project;

partial class VerifyAccount
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
        txtBox_ActivationCode = new System.Windows.Forms.TextBox();
        btn_resendCode = new System.Windows.Forms.Button();
        btn_submit = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // txtBox_ActivationCode
        // 
        txtBox_ActivationCode.Font = new System.Drawing.Font("Segoe UI", 12F);
        txtBox_ActivationCode.Location = new System.Drawing.Point(12, 12);
        txtBox_ActivationCode.Name = "txtBox_ActivationCode";
        txtBox_ActivationCode.Size = new System.Drawing.Size(256, 34);
        txtBox_ActivationCode.TabIndex = 0;
        // 
        // btn_resendCode
        // 
        btn_resendCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btn_resendCode.Font = new System.Drawing.Font("Segoe UI", 10F);
        btn_resendCode.Location = new System.Drawing.Point(12, 133);
        btn_resendCode.Name = "btn_resendCode";
        btn_resendCode.Size = new System.Drawing.Size(256, 34);
        btn_resendCode.TabIndex = 1;
        btn_resendCode.Text = "Resend Code";
        btn_resendCode.UseVisualStyleBackColor = true;
        // 
        // btn_submit
        // 
        btn_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btn_submit.Font = new System.Drawing.Font("Segoe UI", 10F);
        btn_submit.Location = new System.Drawing.Point(12, 64);
        btn_submit.Name = "btn_submit";
        btn_submit.Size = new System.Drawing.Size(256, 52);
        btn_submit.TabIndex = 2;
        btn_submit.Text = "Submit";
        btn_submit.UseVisualStyleBackColor = true;
        // 
        // VerifyAccount
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(280, 192);
        Controls.Add(btn_submit);
        Controls.Add(btn_resendCode);
        Controls.Add(txtBox_ActivationCode);
        Text = "VerifyAccount";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button btn_submit;

    private System.Windows.Forms.Button btn_resendCode;

    private System.Windows.Forms.TextBox txtBox_ActivationCode;

    #endregion
}
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
        textBox1 = new System.Windows.Forms.TextBox();
        button1 = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // textBox1
        // 
        textBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
        textBox1.Location = new System.Drawing.Point(108, 90);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(213, 34);
        textBox1.TabIndex = 0;
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(371, 132);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(75, 33);
        button1.TabIndex = 1;
        button1.Text = "button1";
        button1.UseVisualStyleBackColor = true;
        // 
        // ResetPassword
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(button1);
        Controls.Add(textBox1);
        Text = "ResetPassword";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Button button1;

    #endregion
}
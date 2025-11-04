using System.ComponentModel;

namespace OOP_System_Project;

partial class TermsAndConditions
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
        btn_agree = new System.Windows.Forms.Button();
        btn_IDontAgree = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // btn_agree
        // 
        btn_agree.Location = new System.Drawing.Point(391, 390);
        btn_agree.Name = "btn_agree";
        btn_agree.Size = new System.Drawing.Size(82, 38);
        btn_agree.TabIndex = 0;
        btn_agree.Text = "agree!";
        btn_agree.UseVisualStyleBackColor = true;
        btn_agree.Click += btn_agree_Click;
        // 
        // btn_IDontAgree
        // 
        btn_IDontAgree.Location = new System.Drawing.Point(275, 390);
        btn_IDontAgree.Name = "btn_IDontAgree";
        btn_IDontAgree.Size = new System.Drawing.Size(82, 38);
        btn_IDontAgree.TabIndex = 1;
        btn_IDontAgree.Text = "cancel";
        btn_IDontAgree.UseVisualStyleBackColor = true;
        btn_IDontAgree.Click += btn_IDontAgree_Click;
        // 
        // TermsAndConditions
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(btn_IDontAgree);
        Controls.Add(btn_agree);
        Text = "TermsAndConditions";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button btn_agree;
    private System.Windows.Forms.Button btn_IDontAgree;

    #endregion
}
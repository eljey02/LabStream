namespace LabStream;

partial class FrmLab1
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        txtInput = new TextBox();
        btnCreate = new Button();
        SuspendLayout();
        // 
        // txtInput
        // 
        txtInput.Location = new Point(48, 40);
        txtInput.Multiline = true;
        txtInput.Name = "txtInput";
        txtInput.ScrollBars = ScrollBars.Vertical;
        txtInput.Size = new Size(220, 66);
        txtInput.TabIndex = 0;
        // 
        // btnCreate
        // 
        btnCreate.Font = new Font("Segoe UI", 12F);
        btnCreate.Location = new Point(105, 140);
        btnCreate.Name = "btnCreate";
        btnCreate.Size = new Size(110, 45);
        btnCreate.TabIndex = 1;
        btnCreate.Text = "Create";
        btnCreate.UseVisualStyleBackColor = true;
        btnCreate.Click += btnCreate_Click;
        // 
        // FrmLab1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(316, 220);
        Controls.Add(btnCreate);
        Controls.Add(txtInput);
        Name = "FrmLab1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "FrmLab1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox txtInput;
    private Button btnCreate;
}

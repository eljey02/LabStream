namespace LabStream;

partial class FrmFileName
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
        lblFileName = new Label();
        txtFileName = new TextBox();
        btnOkay = new Button();
        SuspendLayout();
        // 
        // lblFileName
        // 
        lblFileName.AutoSize = true;
        lblFileName.Font = new Font("Segoe UI", 12F);
        lblFileName.Location = new Point(18, 20);
        lblFileName.Name = "lblFileName";
        lblFileName.Size = new Size(104, 21);
        lblFileName.TabIndex = 0;
        lblFileName.Text = "Enter File Name";
        // 
        // txtFileName
        // 
        txtFileName.Location = new Point(18, 55);
        txtFileName.Name = "txtFileName";
        txtFileName.Size = new Size(290, 23);
        txtFileName.TabIndex = 1;
        // 
        // btnOkay
        // 
        btnOkay.Location = new Point(124, 95);
        btnOkay.Name = "btnOkay";
        btnOkay.Size = new Size(80, 27);
        btnOkay.TabIndex = 2;
        btnOkay.Text = "Okay";
        btnOkay.UseVisualStyleBackColor = true;
        btnOkay.Click += btnOkay_Click;
        // 
        // FrmFileName
        // 
        AcceptButton = btnOkay;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(326, 140);
        Controls.Add(btnOkay);
        Controls.Add(txtFileName);
        Controls.Add(lblFileName);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "FrmFileName";
        StartPosition = FormStartPosition.CenterParent;
        Text = "frmFileName";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblFileName;
    private TextBox txtFileName;
    private Button btnOkay;
}

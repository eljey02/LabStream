namespace LabStream;

partial class FrmRegistration
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
        lblTitle = new Label();
        lblStudentNo = new Label();
        txtStudentNo = new TextBox();
        lblProgram = new Label();
        cboProgram = new ComboBox();
        lblLastName = new Label();
        txtLastName = new TextBox();
        lblFirstName = new Label();
        txtFirstName = new TextBox();
        lblMI = new Label();
        txtMI = new TextBox();
        lblAge = new Label();
        txtAge = new TextBox();
        lblGender = new Label();
        cboGender = new ComboBox();
        lblBirthday = new Label();
        dtpBirthday = new DateTimePicker();
        lblContactNo = new Label();
        txtContactNo = new TextBox();
        btnRegister = new Button();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 20F);
        lblTitle.Location = new Point(14, 10);
        lblTitle.Name = "lblTitle";
        lblTitle.Text = "Registration";
        // 
        // lblStudentNo
        // 
        lblStudentNo.AutoSize = true;
        lblStudentNo.Location = new Point(20, 66);
        lblStudentNo.Name = "lblStudentNo";
        lblStudentNo.Text = "Student No.";
        // 
        // txtStudentNo
        // 
        txtStudentNo.Location = new Point(105, 62);
        txtStudentNo.MaxLength = 15;
        txtStudentNo.Name = "txtStudentNo";
        txtStudentNo.Size = new Size(140, 23);
        txtStudentNo.TabIndex = 0;
        // 
        // lblProgram
        // 
        lblProgram.AutoSize = true;
        lblProgram.Location = new Point(290, 66);
        lblProgram.Name = "lblProgram";
        lblProgram.Text = "Program";
        // 
        // cboProgram
        // 
        cboProgram.DropDownStyle = ComboBoxStyle.DropDownList;
        cboProgram.Location = new Point(350, 62);
        cboProgram.Name = "cboProgram";
        cboProgram.Size = new Size(240, 23);
        cboProgram.TabIndex = 1;
        // 
        // lblLastName
        // 
        lblLastName.AutoSize = true;
        lblLastName.Location = new Point(20, 101);
        lblLastName.Name = "lblLastName";
        lblLastName.Text = "Last Name";
        // 
        // txtLastName
        // 
        txtLastName.Location = new Point(105, 97);
        txtLastName.Name = "txtLastName";
        txtLastName.Size = new Size(140, 23);
        txtLastName.TabIndex = 2;
        // 
        // lblFirstName
        // 
        lblFirstName.AutoSize = true;
        lblFirstName.Location = new Point(275, 101);
        lblFirstName.Name = "lblFirstName";
        lblFirstName.Text = "First Name";
        // 
        // txtFirstName
        // 
        txtFirstName.Location = new Point(350, 97);
        txtFirstName.Name = "txtFirstName";
        txtFirstName.Size = new Size(160, 23);
        txtFirstName.TabIndex = 3;
        // 
        // lblMI
        // 
        lblMI.AutoSize = true;
        lblMI.Location = new Point(520, 101);
        lblMI.Name = "lblMI";
        lblMI.Text = "M.I.";
        // 
        // txtMI
        // 
        txtMI.Location = new Point(550, 97);
        txtMI.MaxLength = 2;
        txtMI.Name = "txtMI";
        txtMI.Size = new Size(40, 23);
        txtMI.TabIndex = 4;
        // 
        // lblAge
        // 
        lblAge.AutoSize = true;
        lblAge.Location = new Point(66, 138);
        lblAge.Name = "lblAge";
        lblAge.Text = "Age";
        // 
        // txtAge
        // 
        txtAge.Location = new Point(105, 134);
        txtAge.MaxLength = 3;
        txtAge.Name = "txtAge";
        txtAge.Size = new Size(60, 23);
        txtAge.TabIndex = 5;
        // 
        // lblGender
        // 
        lblGender.AutoSize = true;
        lblGender.Location = new Point(290, 138);
        lblGender.Name = "lblGender";
        lblGender.Text = "Gender:";
        // 
        // cboGender
        // 
        cboGender.DropDownStyle = ComboBoxStyle.DropDownList;
        cboGender.Location = new Point(350, 134);
        cboGender.Name = "cboGender";
        cboGender.Size = new Size(120, 23);
        cboGender.TabIndex = 6;
        // 
        // lblBirthday
        // 
        lblBirthday.AutoSize = true;
        lblBirthday.Location = new Point(40, 178);
        lblBirthday.Name = "lblBirthday";
        lblBirthday.Text = "Birthday";
        // 
        // dtpBirthday
        // 
        dtpBirthday.CustomFormat = "dddd , d  MMMM  yyyy";
        dtpBirthday.Format = DateTimePickerFormat.Custom;
        dtpBirthday.Location = new Point(105, 174);
        dtpBirthday.MaxDate = new DateTime(2100, 12, 31);
        dtpBirthday.MinDate = new DateTime(1900, 1, 1);
        dtpBirthday.Name = "dtpBirthday";
        dtpBirthday.Size = new Size(190, 23);
        dtpBirthday.TabIndex = 7;
        dtpBirthday.ValueChanged += dtpBirthday_ValueChanged;
        // 
        // lblContactNo
        // 
        lblContactNo.AutoSize = true;
        lblContactNo.Location = new Point(315, 178);
        lblContactNo.Name = "lblContactNo";
        lblContactNo.Text = "Contact No.";
        // 
        // txtContactNo
        // 
        txtContactNo.Location = new Point(395, 174);
        txtContactNo.MaxLength = 15;
        txtContactNo.Name = "txtContactNo";
        txtContactNo.Size = new Size(195, 23);
        txtContactNo.TabIndex = 8;
        // 
        // btnRegister
        // 
        btnRegister.Location = new Point(240, 225);
        btnRegister.Name = "btnRegister";
        btnRegister.Size = new Size(120, 32);
        btnRegister.TabIndex = 9;
        btnRegister.Text = "Register";
        btnRegister.UseVisualStyleBackColor = true;
        btnRegister.Click += btnRegister_Click;
        // 
        // FrmRegistration
        // 
        AcceptButton = btnRegister;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(610, 280);
        Controls.Add(lblTitle);
        Controls.Add(lblStudentNo);
        Controls.Add(txtStudentNo);
        Controls.Add(lblProgram);
        Controls.Add(cboProgram);
        Controls.Add(lblLastName);
        Controls.Add(txtLastName);
        Controls.Add(lblFirstName);
        Controls.Add(txtFirstName);
        Controls.Add(lblMI);
        Controls.Add(txtMI);
        Controls.Add(lblAge);
        Controls.Add(txtAge);
        Controls.Add(lblGender);
        Controls.Add(cboGender);
        Controls.Add(lblBirthday);
        Controls.Add(dtpBirthday);
        Controls.Add(lblContactNo);
        Controls.Add(txtContactNo);
        Controls.Add(btnRegister);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "FrmRegistration";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "FrmRegistration";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblTitle;
    private Label lblStudentNo;
    private TextBox txtStudentNo;
    private Label lblProgram;
    private ComboBox cboProgram;
    private Label lblLastName;
    private TextBox txtLastName;
    private Label lblFirstName;
    private TextBox txtFirstName;
    private Label lblMI;
    private TextBox txtMI;
    private Label lblAge;
    private TextBox txtAge;
    private Label lblGender;
    private ComboBox cboGender;
    private Label lblBirthday;
    private DateTimePicker dtpBirthday;
    private Label lblContactNo;
    private TextBox txtContactNo;
    private Button btnRegister;
}

namespace LabStream;

public partial class FrmRegistration : Form
{
    public FrmRegistration()
    {
        InitializeComponent();

        cboProgram.Items.AddRange(new object[]
        {
            "BS Information Technology",
            "BS Computer Science",
            "BS Computer Engineering",
            "BS Business Administration",
            "BS Tourism Management"
        });
        cboGender.Items.AddRange(new object[] { "Male", "Female" });
        cboProgram.SelectedIndex = 0;
        cboGender.SelectedIndex = 0;

        dtpBirthday.Value = new DateTime(2000, 1, 1);
        UpdateAge();
    }

    // Auto-fills the Age box from the selected birthday (can still be edited)
    private void dtpBirthday_ValueChanged(object sender, EventArgs e) => UpdateAge();

    private void UpdateAge()
    {
        DateTime today = DateTime.Today;
        DateTime bday = dtpBirthday.Value.Date;
        int age = today.Year - bday.Year;
        if (bday > today.AddYears(-age)) age--;
        txtAge.Text = Math.Max(age, 0).ToString();
    }

    private void btnRegister_Click(object sender, EventArgs e)
    {
        string studentNo = txtStudentNo.Text.Trim();
        string lastName = txtLastName.Text.Trim();
        string firstName = txtFirstName.Text.Trim();
        string middleInitial = txtMI.Text.Trim();
        string contactNo = txtContactNo.Text.Trim();

        // Validation
        if (studentNo.Length == 0 || !studentNo.All(char.IsDigit))
        {
            Warn("Student No. is required and must contain digits only.", txtStudentNo);
            return;
        }
        if (lastName.Length == 0 || firstName.Length == 0)
        {
            Warn("Please enter the Last Name and First Name.", lastName.Length == 0 ? txtLastName : txtFirstName);
            return;
        }
        if (!int.TryParse(txtAge.Text.Trim(), out int age) || age < 0)
        {
            Warn("Please enter a valid Age.", txtAge);
            return;
        }
        if (contactNo.Length == 0)
        {
            Warn("Please enter the Contact No.", txtContactNo);
            return;
        }

        if (middleInitial.Length > 0 && !middleInitial.EndsWith("."))
            middleInitial += ".";

        string fullName = middleInitial.Length > 0
            ? $"{lastName}, {firstName}, {middleInitial}"
            : $"{lastName}, {firstName}";

        // Array of strings, written line by line with foreach (see hint)
        string[] details =
        {
            "Student No.:" + studentNo,
            "Full Name:" + fullName,
            "Program: " + cboProgram.Text,
            "Gender: " + cboGender.Text,
            "Age: " + age,
            "Birthday: " + dtpBirthday.Value.ToString("yyyy-MM-dd"),
            "Contact No." + contactNo
        };

        string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        string filePath = Path.Combine(docPath, studentNo + ".txt");   // file name = student number

        using (StreamWriter outputFile = new StreamWriter(filePath))
        {
            foreach (string line in details)
            {
                outputFile.WriteLine(line);
            }
        }

        MessageBox.Show("Registration saved:\n" + filePath, "Success",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private static void Warn(string message, Control focus)
    {
        MessageBox.Show(message, "Registration", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        focus.Focus();
    }
}

namespace LabStream;

public partial class FrmFileName : Form
{
    public static string SetFileName = "";

    public FrmFileName()
    {
        InitializeComponent();
    }

    private void btnOkay_Click(object sender, EventArgs e)
    {
        string name = txtFileName.Text.Trim();

        if (name.Length == 0 || name.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0)
        {
            MessageBox.Show("Please enter a valid file name.", "Invalid File Name",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtFileName.Focus();
            return;
        }

        // Set the static string using txtFileName and concatenate ".txt"
        SetFileName = name + ".txt";

        Close();
    }
}

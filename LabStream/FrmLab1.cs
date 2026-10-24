namespace LabStream;

public partial class FrmLab1 : Form
{
    public FrmLab1()
    {
        InitializeComponent();
    }

    private void btnCreate_Click(object sender, EventArgs e)
    {
        FrmFileName frmFileName = new FrmFileName();
        FrmFileName.SetFileName = "";        
        frmFileName.ShowDialog();

   
        if (string.IsNullOrWhiteSpace(FrmFileName.SetFileName))
            return;

        // b. Declare a string variable named getInput and get the value of txtInput
        string getInput = txtInput.Text;

        string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, FrmFileName.SetFileName)))
        {
            outputFile.WriteLine(getInput);
            Console.WriteLine(getInput);
        }

        MessageBox.Show("File created:\n" + Path.Combine(docPath, FrmFileName.SetFileName),
            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}

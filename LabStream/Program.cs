namespace LabStream;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        // Yes = Laboratory Exercise (FrmLab1), No = Challenge Exercise (FrmRegistration)
        DialogResult choice = MessageBox.Show(
            "Run the Laboratory Exercise (FrmLab1)?\n\nYes = Laboratory Exercise\nNo = Challenge Exercise (FrmRegistration)",
            "LabStream", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (choice == DialogResult.Yes)
            Application.Run(new FrmLab1());
        else
            Application.Run(new FrmRegistration());
    }
}

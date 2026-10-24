namespace TextFileProject
{
    public partial class FrmLab : Form
    {

        public FrmLab()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                InputValidator.Required(txtInput.Text, "Text");

                FrmFileName.SetFileName = null; // reset so an old name isn't reused
                FrmFileName frmFileName = new FrmFileName();
                frmFileName.ShowDialog();

                // Catches closing the dialog with the X
                InputValidator.Required(FrmFileName.SetFileName, "File name");

                string getInput = txtInput.Text;
                string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string fullPath = Path.Combine(docPath, FrmFileName.SetFileName);

                using (StreamWriter outputFile = new StreamWriter(fullPath))
                {
                    outputFile.WriteLine(getInput);
                    Console.WriteLine(getInput);
                }

                MessageBox.Show("File created!\n\nSaved at:\n" + fullPath, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("No permission to save in the Documents folder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException ex)
            {
                MessageBox.Show("File error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmRegistration reg = new FrmRegistration();
            reg.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Versioning;

namespace TextFileProject
{
    public partial class FrmStudentRecords : Form
    {
        public FrmStudentRecords()
        {
            InitializeComponent();

            lvRecords.View = View.Details;
            lvRecords.HeaderStyle = ColumnHeaderStyle.None;
            lvRecords.Columns.Clear();
            lvRecords.Columns.Add("Record", lvRecords.ClientSize.Width - 4);
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Close(); // goes back to FrmRegistration
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                ofd.Title = "Find Student Record";
                ofd.Filter = "txt files (*.txt)|*.txt";

                if (ofd.ShowDialog() != DialogResult.OK)
                    return;

                lvRecords.Items.Clear();

                using (StreamReader sr = File.OpenText(ofd.FileName))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        lvRecords.Items.Add(line);
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("File error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("No permission to open that file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully Uploaded!", "Upload", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lvRecords.Items.Clear();
        }
    }
}

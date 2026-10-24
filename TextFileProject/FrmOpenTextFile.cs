using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TextFileProject
{
    public partial class FrmOpenTextFile : Form
    {
        public FrmOpenTextFile()
        {
            InitializeComponent();

            lvShowText.View = View.Details;
            lvShowText.HeaderStyle = ColumnHeaderStyle.None;
            lvShowText.Columns.Clear();
            lvShowText.Columns.Add("Record", lvShowText.ClientSize.Width - 4);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }
        private void DisplayToList()
        {
            try
            {
                openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                openFileDialog1.Title = "Browse Text Files";
                openFileDialog1.DefaultExt = "txt";
                openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

                if (openFileDialog1.ShowDialog() != DialogResult.OK)
                    return; // user cancelled

                string path = openFileDialog1.FileName;
                lvShowText.Items.Clear();

                using (StreamReader streamReader = File.OpenText(path))
                {
                    string _getText = "";
                    while ((_getText = streamReader.ReadLine()) != null)
                    {
                        Console.WriteLine(_getText);
                        lvShowText.Items.Add(_getText);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("File not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("No permission to open that file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException ex)
            {
                MessageBox.Show("File error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            DisplayToList();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Versioning;

namespace TextFileProject
{
    public partial class FrmFileName : Form
    {
        public static string SetFileName;
        public FrmFileName()
        {
            InitializeComponent();
        }

        [SupportedOSPlatform("windows6.1")]
        private void btnOkay_Click(object sender, EventArgs e)
        {
            try
            {
                InputValidator.FileName(txtFileName.Text.Trim());
                SetFileName = txtFileName.Text.Trim() + ".txt";
                this.Close();
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFileName.Focus();
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TextFileProject
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();

            cmbProgram.Items.AddRange(new string[]
                {
                    "BS Information Technology",
                    "BS Computer Science",
                    "BS Information Systems",
                    "BS Computer Engineering"
                });
            cmbGender.Items.AddRange(new string[] { "Male", "Female" });

            cmbProgram.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProgram.SelectedIndex = 0;
            cmbGender.SelectedIndex = 0;

            txtMI.MaxLength = 1;
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            try
            {
                InputValidator.DigitsOnly(txtStudentNo.Text, "Student No.");
                InputValidator.LettersOnly(txtLastName.Text, "Last Name");
                InputValidator.LettersOnly(txtFirstName.Text, "First Name");
                InputValidator.LettersOnly(txtMI.Text, "M.I.");
                int age = InputValidator.Age(txtAge.Text);
                InputValidator.DigitsOnly(txtContactNo.Text, "Contact No.", 10, 11);
                InputValidator.Birthday(dtpBirthday.Value);
                InputValidator.Selected(cmbProgram, "Program");
                InputValidator.Selected(cmbGender, "Gender");

                string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string fullPath = Path.Combine(docPath, txtStudentNo.Text + ".txt");

                string[] lines = new string[]
                {
            "Student No.: " + txtStudentNo.Text,
            "Full Name: " + txtLastName.Text + ", " + txtFirstName.Text + " " + txtMI.Text + ".",
            "Program: " + cmbProgram.Text,
            "Gender: " + cmbGender.Text,
            "Age: " + age,
            "Birthday: " + dtpBirthday.Value.ToString("yyyy-MM-dd"),
            "Contact No.: " + txtContactNo.Text.TrimStart('0')
                };

                using (StreamWriter outputFile = new StreamWriter(fullPath))
                {
                    foreach (string line in lines)
                        outputFile.WriteLine(line);
                }

                MessageBox.Show("Registered!\n\nSaved at:\n" + fullPath, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void FrmRegistration_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmStudentRecords records = new FrmStudentRecords();
            records.ShowDialog();
        }
    }
}

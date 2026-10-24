namespace TextFileProject
{
    partial class FrmLab
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtInput = new TextBox();
            btnCreate = new Button();
            button1 = new Button();
            button2 = new Button();
            btnOpenFile = new Button();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(50, 31);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(366, 142);
            txtInput.TabIndex = 0;
            txtInput.Text = " ";
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.Maroon;
            btnCreate.Cursor = Cursors.Hand;
            btnCreate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(12, 179);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(137, 41);
            btnCreate.TabIndex = 1;
            btnCreate.Text = "CREATE";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Maroon;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(165, 179);
            button1.Name = "button1";
            button1.Size = new Size(137, 41);
            button1.TabIndex = 2;
            button1.Text = "REGISTRATION";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Maroon;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(318, 179);
            button2.Name = "button2";
            button2.Size = new Size(137, 41);
            button2.TabIndex = 3;
            button2.Text = "RECORDS";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnOpenFile
            // 
            btnOpenFile.BackColor = Color.Maroon;
            btnOpenFile.Cursor = Cursors.Hand;
            btnOpenFile.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOpenFile.ForeColor = Color.White;
            btnOpenFile.Location = new Point(165, 229);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(137, 41);
            btnOpenFile.TabIndex = 4;
            btnOpenFile.Text = "OPEN FILE";
            btnOpenFile.UseVisualStyleBackColor = false;
            btnOpenFile.Click += btnOpenFile_Click;
            // 
            // FrmLab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 282);
            Controls.Add(btnOpenFile);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnCreate);
            Controls.Add(txtInput);
            Name = "FrmLab";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLab";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private Button btnCreate;
        private Button button1;
        private Button button2;
        private Button btnOpenFile;
    }
}

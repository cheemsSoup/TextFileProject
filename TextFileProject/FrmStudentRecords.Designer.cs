namespace TextFileProject
{
    partial class FrmStudentRecords
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lvRecords = new ListView();
            label1 = new Label();
            btnRegister = new Button();
            btnFind = new Button();
            btnUpload = new Button();
            SuspendLayout();
            // 
            // lvRecords
            // 
            lvRecords.Location = new Point(12, 52);
            lvRecords.Name = "lvRecords";
            lvRecords.Size = new Size(536, 265);
            lvRecords.TabIndex = 0;
            lvRecords.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(145, 40);
            label1.TabIndex = 3;
            label1.Text = "RECORDS";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Maroon;
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(554, 61);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(137, 41);
            btnRegister.TabIndex = 24;
            btnRegister.Text = "REGISTER";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnFind
            // 
            btnFind.BackColor = Color.Maroon;
            btnFind.Cursor = Cursors.Hand;
            btnFind.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFind.ForeColor = Color.White;
            btnFind.Location = new Point(554, 108);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(137, 41);
            btnFind.TabIndex = 25;
            btnFind.Text = "FIND";
            btnFind.UseVisualStyleBackColor = false;
            btnFind.Click += btnFind_Click;
            // 
            // btnUpload
            // 
            btnUpload.BackColor = Color.Maroon;
            btnUpload.Cursor = Cursors.Hand;
            btnUpload.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpload.ForeColor = Color.White;
            btnUpload.Location = new Point(554, 155);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(137, 41);
            btnUpload.TabIndex = 26;
            btnUpload.Text = "UPLOAD";
            btnUpload.UseVisualStyleBackColor = false;
            btnUpload.Click += btnUpload_Click;
            // 
            // FrmStudentRecords
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 333);
            Controls.Add(btnUpload);
            Controls.Add(btnFind);
            Controls.Add(btnRegister);
            Controls.Add(label1);
            Controls.Add(lvRecords);
            Name = "FrmStudentRecords";
            Text = "StudentRecords";
            Load += this.FrmStudentRecords_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvRecords;
        private Label label1;
        private Button btnRegister;
        private Button btnFind;
        private Button btnUpload;
    }
}
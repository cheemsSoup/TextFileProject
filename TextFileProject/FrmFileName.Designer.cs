namespace TextFileProject
{
    partial class FrmFileName
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
            txtFileName = new TextBox();
            label1 = new Label();
            btnOkay = new Button();
            SuspendLayout();
            // 
            // txtFileName
            // 
            txtFileName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFileName.Location = new Point(40, 88);
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(393, 27);
            txtFileName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(254, 40);
            label1.TabIndex = 1;
            label1.Text = "ENTER FILE NAME";
            // 
            // btnOkay
            // 
            btnOkay.BackColor = Color.Maroon;
            btnOkay.Cursor = Cursors.Hand;
            btnOkay.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOkay.ForeColor = Color.White;
            btnOkay.Location = new Point(168, 133);
            btnOkay.Name = "btnOkay";
            btnOkay.Size = new Size(137, 41);
            btnOkay.TabIndex = 2;
            btnOkay.Text = "OKAY";
            btnOkay.UseVisualStyleBackColor = false;
            btnOkay.Click += btnOkay_Click;
            // 
            // FrmFileName
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 210);
            Controls.Add(btnOkay);
            Controls.Add(label1);
            Controls.Add(txtFileName);
            Name = "FrmFileName";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmFileName";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFileName;
        private Label label1;
        private Button btnOkay;
    }
}
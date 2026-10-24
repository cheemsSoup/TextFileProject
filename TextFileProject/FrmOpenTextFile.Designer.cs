namespace TextFileProject
{
    partial class FrmOpenTextFile
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
            btnOpen = new Button();
            lvShowText = new ListView();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // btnOpen
            // 
            btnOpen.BackColor = Color.Maroon;
            btnOpen.Cursor = Cursors.Hand;
            btnOpen.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOpen.ForeColor = Color.White;
            btnOpen.Location = new Point(178, 273);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(137, 41);
            btnOpen.TabIndex = 23;
            btnOpen.Text = "OPEN";
            btnOpen.UseVisualStyleBackColor = false;
            btnOpen.Click += btnOpen_Click;
            // 
            // lvShowText
            // 
            lvShowText.Location = new Point(12, 12);
            lvShowText.Name = "lvShowText";
            lvShowText.Size = new Size(464, 246);
            lvShowText.TabIndex = 24;
            lvShowText.UseCompatibleStateImageBehavior = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // FrmOpenTextFile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 326);
            Controls.Add(lvShowText);
            Controls.Add(btnOpen);
            Name = "FrmOpenTextFile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmOpenTextFile";
            ResumeLayout(false);
        }

        #endregion

        private Button btnOpen;
        private ListView lvShowText;
        private OpenFileDialog openFileDialog1;
    }
}
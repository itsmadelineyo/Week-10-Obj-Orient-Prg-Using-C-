namespace CollectionLab_Project
{
    partial class FrmCollections
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
            btnAdd = new Button();
            btnStatistics = new Button();
            btnReset = new Button();
            btnExit = new Button();
            lblPrompt = new Label();
            txtNumber = new TextBox();
            rtbCollection = new RichTextBox();
            rtbStats = new RichTextBox();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(24, 166);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(141, 34);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "&Add Number";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnStatistics
            // 
            btnStatistics.Location = new Point(220, 166);
            btnStatistics.Name = "btnStatistics";
            btnStatistics.Size = new Size(141, 34);
            btnStatistics.TabIndex = 2;
            btnStatistics.Text = "&Statistics";
            btnStatistics.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(24, 228);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(141, 34);
            btnReset.TabIndex = 3;
            btnReset.Text = "&Reset";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(220, 228);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(141, 34);
            btnExit.TabIndex = 4;
            btnExit.Text = "&Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // lblPrompt
            // 
            lblPrompt.AutoSize = true;
            lblPrompt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrompt.ForeColor = SystemColors.ButtonFace;
            lblPrompt.Location = new Point(24, 34);
            lblPrompt.Name = "lblPrompt";
            lblPrompt.Size = new Size(355, 25);
            lblPrompt.TabIndex = 5;
            lblPrompt.Text = "Enter a number between -1217 and 1217";
            // 
            // txtNumber
            // 
            txtNumber.BackColor = SystemColors.Info;
            txtNumber.Location = new Point(34, 101);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(327, 31);
            txtNumber.TabIndex = 0;
            txtNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // rtbCollection
            // 
            rtbCollection.BackColor = SystemColors.Info;
            rtbCollection.Location = new Point(24, 296);
            rtbCollection.Name = "rtbCollection";
            rtbCollection.ReadOnly = true;
            rtbCollection.Size = new Size(400, 250);
            rtbCollection.TabIndex = 5;
            rtbCollection.Text = "";
            // 
            // rtbStats
            // 
            rtbStats.BackColor = SystemColors.Info;
            rtbStats.Location = new Point(24, 552);
            rtbStats.Name = "rtbStats";
            rtbStats.ReadOnly = true;
            rtbStats.Size = new Size(400, 200);
            rtbStats.TabIndex = 6;
            rtbStats.Text = "Stats and messages will appear here.";
            rtbStats.TextChanged += this.rtbStats_TextChanged_1;
            // 
            // FrmCollections
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(455, 780);
            Controls.Add(rtbStats);
            Controls.Add(rtbCollection);
            Controls.Add(txtNumber);
            Controls.Add(lblPrompt);
            Controls.Add(btnExit);
            Controls.Add(btnReset);
            Controls.Add(btnStatistics);
            Controls.Add(btnAdd);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmCollections";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Collection Lab";
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btnAdd;
        private Button btnStatistics;
        private Button btnReset;
        private Button btnExit;
        private Label lblPrompt;
        private TextBox txtNumber;
        private RichTextBox rtbCollection;
        private RichTextBox rtbStats;
    }
    #endregion
}
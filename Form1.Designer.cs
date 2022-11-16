namespace Replicate
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.btnBrowseSource = new System.Windows.Forms.Button();
            this.btnBrowseDest = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnViewLog = new System.Windows.Forms.Button();
            this.cbIncludeSubDir = new System.Windows.Forms.CheckBox();
            this.btnReplicate = new System.Windows.Forms.Button();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Destination:";
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(141, 45);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(218, 23);
            this.txtSource.TabIndex = 2;
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(141, 87);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(218, 23);
            this.txtDestination.TabIndex = 3;
            // 
            // btnBrowseSource
            // 
            this.btnBrowseSource.Location = new System.Drawing.Point(394, 49);
            this.btnBrowseSource.Name = "btnBrowseSource";
            this.btnBrowseSource.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseSource.TabIndex = 4;
            this.btnBrowseSource.Text = "Browse";
            this.btnBrowseSource.UseVisualStyleBackColor = true;
            this.btnBrowseSource.Click += new System.EventHandler(this.btnBrowseSource_Click);
            // 
            // btnBrowseDest
            // 
            this.btnBrowseDest.Location = new System.Drawing.Point(394, 90);
            this.btnBrowseDest.Name = "btnBrowseDest";
            this.btnBrowseDest.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseDest.TabIndex = 5;
            this.btnBrowseDest.Text = "Browse";
            this.btnBrowseDest.UseVisualStyleBackColor = true;
            this.btnBrowseDest.Click += new System.EventHandler(this.btnBrowseDest_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(29, 201);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(440, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(394, 243);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnViewLog
            // 
            this.btnViewLog.Location = new System.Drawing.Point(29, 243);
            this.btnViewLog.Name = "btnViewLog";
            this.btnViewLog.Size = new System.Drawing.Size(75, 23);
            this.btnViewLog.TabIndex = 8;
            this.btnViewLog.Text = "View Log";
            this.btnViewLog.UseVisualStyleBackColor = true;
            // 
            // cbIncludeSubDir
            // 
            this.cbIncludeSubDir.AutoSize = true;
            this.cbIncludeSubDir.Location = new System.Drawing.Point(29, 136);
            this.cbIncludeSubDir.Name = "cbIncludeSubDir";
            this.cbIncludeSubDir.Size = new System.Drawing.Size(147, 19);
            this.cbIncludeSubDir.TabIndex = 9;
            this.cbIncludeSubDir.Text = "Include Sub Directories";
            this.cbIncludeSubDir.UseVisualStyleBackColor = true;
            // 
            // btnReplicate
            // 
            this.btnReplicate.Location = new System.Drawing.Point(394, 132);
            this.btnReplicate.Name = "btnReplicate";
            this.btnReplicate.Size = new System.Drawing.Size(75, 23);
            this.btnReplicate.TabIndex = 10;
            this.btnReplicate.Text = "Replicate";
            this.btnReplicate.UseVisualStyleBackColor = true;
            this.btnReplicate.Click += new System.EventHandler(this.btnReplicate_Click);
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Location = new System.Drawing.Point(446, 183);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(23, 15);
            this.lblPercentage.TabIndex = 11;
            this.lblPercentage.Text = "0%";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(204, 243);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 288);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.btnReplicate);
            this.Controls.Add(this.cbIncludeSubDir);
            this.Controls.Add(this.btnViewLog);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnBrowseDest);
            this.Controls.Add(this.btnBrowseSource);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Replicate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtSource;
        private TextBox txtDestination;
        private Button btnBrowseSource;
        private Button btnBrowseDest;
        private ProgressBar progressBar1;
        private Button btnExit;
        private Button btnViewLog;
        private CheckBox cbIncludeSubDir;
        private Button btnReplicate;
        private Label lblPercentage;
        private Button btnDelete;
    }
}
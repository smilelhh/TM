namespace TM
{
    partial class Process
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
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelShow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 45);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(245, 19);
            this.progressBar.TabIndex = 0;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(12, 104);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(60, 23);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "开 始";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(107, 104);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(58, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "取 消";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(200, 104);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(57, 23);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "退 出";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelShow
            // 
            this.labelShow.AutoSize = true;
            this.labelShow.Location = new System.Drawing.Point(12, 79);
            this.labelShow.Name = "labelShow";
            this.labelShow.Size = new System.Drawing.Size(53, 12);
            this.labelShow.TabIndex = 5;
            this.labelShow.Text = "当前值是";
            // 
            // Process
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 144);
            this.Controls.Add(this.labelShow);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.progressBar);
            this.Name = "Process";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "导入进度";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelShow;
    }
}
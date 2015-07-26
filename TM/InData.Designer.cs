namespace TM
{
    partial class InData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InData));
            this.labelChose = new System.Windows.Forms.Label();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.buttonChose = new System.Windows.Forms.Button();
            this.buttonYes = new System.Windows.Forms.Button();
            this.buttonNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelChose
            // 
            this.labelChose.AutoSize = true;
            this.labelChose.BackColor = System.Drawing.Color.Transparent;
            this.labelChose.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelChose.Location = new System.Drawing.Point(51, 92);
            this.labelChose.Name = "labelChose";
            this.labelChose.Size = new System.Drawing.Size(135, 12);
            this.labelChose.TabIndex = 0;
            this.labelChose.Text = "导入数据进行初始化：";
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxFilePath.Enabled = false;
            this.textBoxFilePath.ForeColor = System.Drawing.Color.Transparent;
            this.textBoxFilePath.Location = new System.Drawing.Point(180, 89);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.ReadOnly = true;
            this.textBoxFilePath.Size = new System.Drawing.Size(184, 21);
            this.textBoxFilePath.TabIndex = 1;
            // 
            // buttonChose
            // 
            this.buttonChose.Location = new System.Drawing.Point(370, 82);
            this.buttonChose.Name = "buttonChose";
            this.buttonChose.Size = new System.Drawing.Size(75, 32);
            this.buttonChose.TabIndex = 2;
            this.buttonChose.Text = "浏 览...";
            this.buttonChose.UseVisualStyleBackColor = true;
            this.buttonChose.Click += new System.EventHandler(this.buttonChose_Click);
            // 
            // buttonYes
            // 
            this.buttonYes.Location = new System.Drawing.Point(120, 155);
            this.buttonYes.Name = "buttonYes";
            this.buttonYes.Size = new System.Drawing.Size(75, 32);
            this.buttonYes.TabIndex = 3;
            this.buttonYes.Text = "确 定";
            this.buttonYes.UseVisualStyleBackColor = true;
            this.buttonYes.Click += new System.EventHandler(this.buttonYes_Click);
            // 
            // buttonNo
            // 
            this.buttonNo.Location = new System.Drawing.Point(289, 155);
            this.buttonNo.Name = "buttonNo";
            this.buttonNo.Size = new System.Drawing.Size(75, 32);
            this.buttonNo.TabIndex = 4;
            this.buttonNo.Text = "退 出";
            this.buttonNo.UseVisualStyleBackColor = true;
            this.buttonNo.Click += new System.EventHandler(this.buttonNo_Click);
            // 
            // InData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(500, 260);
            this.Controls.Add(this.buttonNo);
            this.Controls.Add(this.buttonYes);
            this.Controls.Add(this.buttonChose);
            this.Controls.Add(this.textBoxFilePath);
            this.Controls.Add(this.labelChose);
            this.Name = "InData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据导入";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelChose;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.Button buttonChose;
        private System.Windows.Forms.Button buttonYes;
        private System.Windows.Forms.Button buttonNo;
    }
}
namespace TM
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemInData = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemZFLR = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemDataModify = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSearchCount = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSearchCountRM = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSearchCountRF = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSearchCountCH = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemExitSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxBackground = new System.Windows.Forms.PictureBox();
            this.labelLinkUs = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemInData,
            this.ToolStripMenuItemZFLR,
            this.ToolStripMenuItemDataModify,
            this.ToolStripMenuItemSearchCount,
            this.ToolStripMenuItemExitSystem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(745, 28);
            this.menuStrip.TabIndex = 0;
            // 
            // ToolStripMenuItemInData
            // 
            this.ToolStripMenuItemInData.ForeColor = System.Drawing.Color.Blue;
            this.ToolStripMenuItemInData.Name = "ToolStripMenuItemInData";
            this.ToolStripMenuItemInData.Size = new System.Drawing.Size(91, 24);
            this.ToolStripMenuItemInData.Text = "系统初始化";
            this.ToolStripMenuItemInData.Click += new System.EventHandler(this.toolStripMenuItemInData_Click);
            // 
            // ToolStripMenuItemZFLR
            // 
            this.ToolStripMenuItemZFLR.ForeColor = System.Drawing.Color.Blue;
            this.ToolStripMenuItemZFLR.Name = "ToolStripMenuItemZFLR";
            this.ToolStripMenuItemZFLR.Size = new System.Drawing.Size(77, 24);
            this.ToolStripMenuItemZFLR.Text = "执法录入";
            this.ToolStripMenuItemZFLR.Click += new System.EventHandler(this.ToolStripMenuItemZFLR_Click);
            // 
            // ToolStripMenuItemDataModify
            // 
            this.ToolStripMenuItemDataModify.ForeColor = System.Drawing.Color.Blue;
            this.ToolStripMenuItemDataModify.Name = "ToolStripMenuItemDataModify";
            this.ToolStripMenuItemDataModify.Size = new System.Drawing.Size(77, 24);
            this.ToolStripMenuItemDataModify.Text = "数据修改";
            this.ToolStripMenuItemDataModify.Click += new System.EventHandler(this.ToolStripMenuItemDataModify_Click);
            // 
            // ToolStripMenuItemSearchCount
            // 
            this.ToolStripMenuItemSearchCount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemSearchCountRM,
            this.ToolStripMenuItemSearchCountRF,
            this.ToolStripMenuItemSearchCountCH});
            this.ToolStripMenuItemSearchCount.ForeColor = System.Drawing.Color.Blue;
            this.ToolStripMenuItemSearchCount.Name = "ToolStripMenuItemSearchCount";
            this.ToolStripMenuItemSearchCount.Size = new System.Drawing.Size(77, 24);
            this.ToolStripMenuItemSearchCount.Text = "查询统计";
            // 
            // ToolStripMenuItemSearchCountRM
            // 
            this.ToolStripMenuItemSearchCountRM.ForeColor = System.Drawing.Color.Blue;
            this.ToolStripMenuItemSearchCountRM.Name = "ToolStripMenuItemSearchCountRM";
            this.ToolStripMenuItemSearchCountRM.Size = new System.Drawing.Size(190, 24);
            this.ToolStripMenuItemSearchCountRM.Text = "查询统计责令整改";
            this.ToolStripMenuItemSearchCountRM.Click += new System.EventHandler(this.ToolStripMenuItemSearchCountRM_Click);
            // 
            // ToolStripMenuItemSearchCountRF
            // 
            this.ToolStripMenuItemSearchCountRF.ForeColor = System.Drawing.Color.Blue;
            this.ToolStripMenuItemSearchCountRF.Name = "ToolStripMenuItemSearchCountRF";
            this.ToolStripMenuItemSearchCountRF.Size = new System.Drawing.Size(190, 24);
            this.ToolStripMenuItemSearchCountRF.Text = "查询统计当场处罚";
            this.ToolStripMenuItemSearchCountRF.Click += new System.EventHandler(this.ToolStripMenuItemSearchCountRF_Click);
            // 
            // ToolStripMenuItemSearchCountCH
            // 
            this.ToolStripMenuItemSearchCountCH.ForeColor = System.Drawing.Color.Blue;
            this.ToolStripMenuItemSearchCountCH.Name = "ToolStripMenuItemSearchCountCH";
            this.ToolStripMenuItemSearchCountCH.Size = new System.Drawing.Size(190, 24);
            this.ToolStripMenuItemSearchCountCH.Text = "查询统计历史比对";
            this.ToolStripMenuItemSearchCountCH.Click += new System.EventHandler(this.ToolStripMenuItemSearchCountCH_Click);
            // 
            // ToolStripMenuItemExitSystem
            // 
            this.ToolStripMenuItemExitSystem.ForeColor = System.Drawing.Color.Blue;
            this.ToolStripMenuItemExitSystem.Name = "ToolStripMenuItemExitSystem";
            this.ToolStripMenuItemExitSystem.Size = new System.Drawing.Size(77, 24);
            this.ToolStripMenuItemExitSystem.Text = "退出系统";
            this.ToolStripMenuItemExitSystem.Click += new System.EventHandler(this.ToolStripMenuItemExitSystem_Click);
            // 
            // pictureBoxBackground
            // 
            this.pictureBoxBackground.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBackground.Image")));
            this.pictureBoxBackground.Location = new System.Drawing.Point(0, 28);
            this.pictureBoxBackground.Name = "pictureBoxBackground";
            this.pictureBoxBackground.Size = new System.Drawing.Size(745, 382);
            this.pictureBoxBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBackground.TabIndex = 1;
            this.pictureBoxBackground.TabStop = false;
            // 
            // labelLinkUs
            // 
            this.labelLinkUs.AutoSize = true;
            this.labelLinkUs.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelLinkUs.Location = new System.Drawing.Point(177, 418);
            this.labelLinkUs.Name = "labelLinkUs";
            this.labelLinkUs.Size = new System.Drawing.Size(461, 12);
            this.labelLinkUs.TabIndex = 2;
            this.labelLinkUs.Text = "©2015 本系统由北京交通大学软件学院： 刘红华、严帅 出品，版权所有，翻版必究！";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 439);
            this.Controls.Add(this.labelLinkUs);
            this.Controls.Add(this.pictureBoxBackground);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "执法管理系统";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.PictureBox pictureBoxBackground;
        public System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemInData;
        public System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemZFLR;
        public System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDataModify;
        public System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSearchCount;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemExitSystem;
        private System.Windows.Forms.Label labelLinkUs;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSearchCountRM;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSearchCountRF;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSearchCountCH;
    }
}
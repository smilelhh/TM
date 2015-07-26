namespace TM
{
    partial class DataModify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataModify));
            this.labelHandledCode = new System.Windows.Forms.Label();
            this.textBoxHandledCode = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelInstituteName = new System.Windows.Forms.Label();
            this.textBoxInstituteName = new System.Windows.Forms.TextBox();
            this.labelDeadline = new System.Windows.Forms.Label();
            this.textBoxDeadline = new System.Windows.Forms.TextBox();
            this.labelHandleContent = new System.Windows.Forms.Label();
            this.textBoxHandleContent = new System.Windows.Forms.TextBox();
            this.labelFineMoney = new System.Windows.Forms.Label();
            this.textBoxFineMoney = new System.Windows.Forms.TextBox();
            this.labelHandleDate = new System.Windows.Forms.Label();
            this.textBoxHandleDate = new System.Windows.Forms.TextBox();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelHandledCode
            // 
            this.labelHandledCode.AutoSize = true;
            this.labelHandledCode.BackColor = System.Drawing.Color.Transparent;
            this.labelHandledCode.Location = new System.Drawing.Point(58, 35);
            this.labelHandledCode.Name = "labelHandledCode";
            this.labelHandledCode.Size = new System.Drawing.Size(98, 14);
            this.labelHandledCode.TabIndex = 0;
            this.labelHandledCode.Text = "已处理代码号:";
            // 
            // textBoxHandledCode
            // 
            this.textBoxHandledCode.Location = new System.Drawing.Point(187, 32);
            this.textBoxHandledCode.Name = "textBoxHandledCode";
            this.textBoxHandledCode.Size = new System.Drawing.Size(128, 23);
            this.textBoxHandledCode.TabIndex = 1;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(366, 26);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 32);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "查 找";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelInstituteName
            // 
            this.labelInstituteName.AutoSize = true;
            this.labelInstituteName.BackColor = System.Drawing.Color.Transparent;
            this.labelInstituteName.Location = new System.Drawing.Point(58, 80);
            this.labelInstituteName.Name = "labelInstituteName";
            this.labelInstituteName.Size = new System.Drawing.Size(70, 14);
            this.labelInstituteName.TabIndex = 3;
            this.labelInstituteName.Text = "机构名称:";
            // 
            // textBoxInstituteName
            // 
            this.textBoxInstituteName.Enabled = false;
            this.textBoxInstituteName.Location = new System.Drawing.Point(187, 77);
            this.textBoxInstituteName.Name = "textBoxInstituteName";
            this.textBoxInstituteName.Size = new System.Drawing.Size(275, 23);
            this.textBoxInstituteName.TabIndex = 4;
            // 
            // labelDeadline
            // 
            this.labelDeadline.AutoSize = true;
            this.labelDeadline.BackColor = System.Drawing.Color.Transparent;
            this.labelDeadline.Location = new System.Drawing.Point(58, 122);
            this.labelDeadline.Name = "labelDeadline";
            this.labelDeadline.Size = new System.Drawing.Size(70, 14);
            this.labelDeadline.TabIndex = 5;
            this.labelDeadline.Text = "作废日期:";
            // 
            // textBoxDeadline
            // 
            this.textBoxDeadline.Enabled = false;
            this.textBoxDeadline.Location = new System.Drawing.Point(187, 119);
            this.textBoxDeadline.Name = "textBoxDeadline";
            this.textBoxDeadline.Size = new System.Drawing.Size(153, 23);
            this.textBoxDeadline.TabIndex = 6;
            // 
            // labelHandleContent
            // 
            this.labelHandleContent.AutoSize = true;
            this.labelHandleContent.BackColor = System.Drawing.Color.Transparent;
            this.labelHandleContent.Location = new System.Drawing.Point(58, 166);
            this.labelHandleContent.Name = "labelHandleContent";
            this.labelHandleContent.Size = new System.Drawing.Size(70, 14);
            this.labelHandleContent.TabIndex = 7;
            this.labelHandleContent.Text = "处理情况:";
            // 
            // textBoxHandleContent
            // 
            this.textBoxHandleContent.Location = new System.Drawing.Point(187, 163);
            this.textBoxHandleContent.Name = "textBoxHandleContent";
            this.textBoxHandleContent.Size = new System.Drawing.Size(275, 23);
            this.textBoxHandleContent.TabIndex = 8;
            // 
            // labelFineMoney
            // 
            this.labelFineMoney.AutoSize = true;
            this.labelFineMoney.BackColor = System.Drawing.Color.Transparent;
            this.labelFineMoney.Location = new System.Drawing.Point(61, 213);
            this.labelFineMoney.Name = "labelFineMoney";
            this.labelFineMoney.Size = new System.Drawing.Size(70, 14);
            this.labelFineMoney.TabIndex = 9;
            this.labelFineMoney.Text = "罚款金额:";
            // 
            // textBoxFineMoney
            // 
            this.textBoxFineMoney.Location = new System.Drawing.Point(187, 210);
            this.textBoxFineMoney.Name = "textBoxFineMoney";
            this.textBoxFineMoney.Size = new System.Drawing.Size(128, 23);
            this.textBoxFineMoney.TabIndex = 10;
            // 
            // labelHandleDate
            // 
            this.labelHandleDate.AutoSize = true;
            this.labelHandleDate.BackColor = System.Drawing.Color.Transparent;
            this.labelHandleDate.Location = new System.Drawing.Point(58, 259);
            this.labelHandleDate.Name = "labelHandleDate";
            this.labelHandleDate.Size = new System.Drawing.Size(70, 14);
            this.labelHandleDate.TabIndex = 11;
            this.labelHandleDate.Text = "处理日期:";
            // 
            // textBoxHandleDate
            // 
            this.textBoxHandleDate.Location = new System.Drawing.Point(187, 256);
            this.textBoxHandleDate.Name = "textBoxHandleDate";
            this.textBoxHandleDate.Size = new System.Drawing.Size(153, 23);
            this.textBoxHandleDate.TabIndex = 12;
            // 
            // buttonModify
            // 
            this.buttonModify.Location = new System.Drawing.Point(157, 331);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(75, 32);
            this.buttonModify.TabIndex = 13;
            this.buttonModify.Text = "修 改";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(340, 331);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 32);
            this.buttonExit.TabIndex = 14;
            this.buttonExit.Text = "退 出";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // DataModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(549, 384);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.textBoxHandleDate);
            this.Controls.Add(this.labelHandleDate);
            this.Controls.Add(this.textBoxFineMoney);
            this.Controls.Add(this.labelFineMoney);
            this.Controls.Add(this.textBoxHandleContent);
            this.Controls.Add(this.labelHandleContent);
            this.Controls.Add(this.textBoxDeadline);
            this.Controls.Add(this.labelDeadline);
            this.Controls.Add(this.textBoxInstituteName);
            this.Controls.Add(this.labelInstituteName);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxHandledCode);
            this.Controls.Add(this.labelHandledCode);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "DataModify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据修改";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHandledCode;
        private System.Windows.Forms.TextBox textBoxHandledCode;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelInstituteName;
        private System.Windows.Forms.TextBox textBoxInstituteName;
        private System.Windows.Forms.Label labelDeadline;
        private System.Windows.Forms.TextBox textBoxDeadline;
        private System.Windows.Forms.Label labelHandleContent;
        private System.Windows.Forms.TextBox textBoxHandleContent;
        private System.Windows.Forms.Label labelFineMoney;
        private System.Windows.Forms.TextBox textBoxFineMoney;
        private System.Windows.Forms.Label labelHandleDate;
        private System.Windows.Forms.TextBox textBoxHandleDate;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Button buttonExit;
    }
}
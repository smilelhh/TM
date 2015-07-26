namespace TM
{
    partial class ZFLR
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZFLR));
            this.labelCode = new System.Windows.Forms.Label();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.buttonSearchCode = new System.Windows.Forms.Button();
            this.labelrelay = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labeldateName = new System.Windows.Forms.Label();
            this.radioButtonModify = new System.Windows.Forms.RadioButton();
            this.radioButtonFine = new System.Windows.Forms.RadioButton();
            this.labelHeadM = new System.Windows.Forms.Label();
            this.textBoxYearM = new System.Windows.Forms.TextBox();
            this.labelLinkM = new System.Windows.Forms.Label();
            this.textBoxNoM = new System.Windows.Forms.TextBox();
            this.labelTailM = new System.Windows.Forms.Label();
            this.labelHeadF = new System.Windows.Forms.Label();
            this.textBoxYearF = new System.Windows.Forms.TextBox();
            this.labelLinkF = new System.Windows.Forms.Label();
            this.textBoxNoF = new System.Windows.Forms.TextBox();
            this.labelTailF = new System.Windows.Forms.Label();
            this.labelFMH = new System.Windows.Forms.Label();
            this.textBoxFM = new System.Windows.Forms.TextBox();
            this.labelFMT = new System.Windows.Forms.Label();
            this.labelHandleDate = new System.Windows.Forms.Label();
            this.textBoxHandleDate = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.tLeftInstituteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ZFLRData = new TM.zflrData();
            this.t_LeftInstituteTableAdapter = new TM.zfkDataSet1TableAdapters.T_LeftInstituteTableAdapter();
            this.buttonExit = new System.Windows.Forms.Button();
            this.dGInstituteInf = new System.Windows.Forms.DataGridView();
            this.leftInstituteCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftInstituteNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftDeadlineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tLeftInstituteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZFLRData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGInstituteInf)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.BackColor = System.Drawing.Color.Transparent;
            this.labelCode.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCode.Location = new System.Drawing.Point(31, 38);
            this.labelCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(63, 14);
            this.labelCode.TabIndex = 0;
            this.labelCode.Text = "代码号：";
            // 
            // textBoxCode
            // 
            this.textBoxCode.Location = new System.Drawing.Point(95, 35);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(130, 23);
            this.textBoxCode.TabIndex = 1;
            // 
            // buttonSearchCode
            // 
            this.buttonSearchCode.Location = new System.Drawing.Point(274, 29);
            this.buttonSearchCode.Name = "buttonSearchCode";
            this.buttonSearchCode.Size = new System.Drawing.Size(75, 32);
            this.buttonSearchCode.TabIndex = 2;
            this.buttonSearchCode.Text = "查 找";
            this.buttonSearchCode.UseVisualStyleBackColor = true;
            this.buttonSearchCode.Click += new System.EventHandler(this.buttonSearchCode_Click);
            // 
            // labelrelay
            // 
            this.labelrelay.AutoSize = true;
            this.labelrelay.BackColor = System.Drawing.Color.Transparent;
            this.labelrelay.Location = new System.Drawing.Point(378, 38);
            this.labelrelay.Name = "labelrelay";
            this.labelrelay.Size = new System.Drawing.Size(42, 14);
            this.labelrelay.TabIndex = 3;
            this.labelrelay.Text = "拖延:";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.SystemColors.Control;
            this.labelDate.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelDate.ForeColor = System.Drawing.Color.Red;
            this.labelDate.Location = new System.Drawing.Point(426, 38);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(0, 14);
            this.labelDate.TabIndex = 4;
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labeldateName
            // 
            this.labeldateName.AutoSize = true;
            this.labeldateName.BackColor = System.Drawing.Color.Transparent;
            this.labeldateName.Location = new System.Drawing.Point(471, 38);
            this.labeldateName.Name = "labeldateName";
            this.labeldateName.Size = new System.Drawing.Size(21, 14);
            this.labeldateName.TabIndex = 5;
            this.labeldateName.Text = "天";
            // 
            // radioButtonModify
            // 
            this.radioButtonModify.AutoSize = true;
            this.radioButtonModify.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonModify.Location = new System.Drawing.Point(34, 206);
            this.radioButtonModify.Name = "radioButtonModify";
            this.radioButtonModify.Size = new System.Drawing.Size(81, 18);
            this.radioButtonModify.TabIndex = 7;
            this.radioButtonModify.TabStop = true;
            this.radioButtonModify.Text = "责令整改";
            this.radioButtonModify.UseVisualStyleBackColor = false;
            // 
            // radioButtonFine
            // 
            this.radioButtonFine.AutoSize = true;
            this.radioButtonFine.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonFine.Location = new System.Drawing.Point(34, 250);
            this.radioButtonFine.Name = "radioButtonFine";
            this.radioButtonFine.Size = new System.Drawing.Size(81, 18);
            this.radioButtonFine.TabIndex = 8;
            this.radioButtonFine.TabStop = true;
            this.radioButtonFine.Text = "当场处罚";
            this.radioButtonFine.UseVisualStyleBackColor = false;
            // 
            // labelHeadM
            // 
            this.labelHeadM.AutoSize = true;
            this.labelHeadM.BackColor = System.Drawing.Color.Transparent;
            this.labelHeadM.Location = new System.Drawing.Point(133, 208);
            this.labelHeadM.Name = "labelHeadM";
            this.labelHeadM.Size = new System.Drawing.Size(140, 14);
            this.labelHeadM.TabIndex = 9;
            this.labelHeadM.Text = "( 内 ) 质监责改字〔";
            // 
            // textBoxYearM
            // 
            this.textBoxYearM.Location = new System.Drawing.Point(274, 205);
            this.textBoxYearM.Name = "textBoxYearM";
            this.textBoxYearM.Size = new System.Drawing.Size(34, 23);
            this.textBoxYearM.TabIndex = 10;
            // 
            // labelLinkM
            // 
            this.labelLinkM.AutoSize = true;
            this.labelLinkM.BackColor = System.Drawing.Color.Transparent;
            this.labelLinkM.Location = new System.Drawing.Point(314, 209);
            this.labelLinkM.Name = "labelLinkM";
            this.labelLinkM.Size = new System.Drawing.Size(35, 14);
            this.labelLinkM.TabIndex = 11;
            this.labelLinkM.Text = "〕DM";
            // 
            // textBoxNoM
            // 
            this.textBoxNoM.Location = new System.Drawing.Point(348, 206);
            this.textBoxNoM.Name = "textBoxNoM";
            this.textBoxNoM.Size = new System.Drawing.Size(86, 23);
            this.textBoxNoM.TabIndex = 12;
            // 
            // labelTailM
            // 
            this.labelTailM.AutoSize = true;
            this.labelTailM.BackColor = System.Drawing.Color.Transparent;
            this.labelTailM.Location = new System.Drawing.Point(440, 208);
            this.labelTailM.Name = "labelTailM";
            this.labelTailM.Size = new System.Drawing.Size(21, 14);
            this.labelTailM.TabIndex = 13;
            this.labelTailM.Text = "号";
            // 
            // labelHeadF
            // 
            this.labelHeadF.AutoSize = true;
            this.labelHeadF.BackColor = System.Drawing.Color.Transparent;
            this.labelHeadF.Location = new System.Drawing.Point(133, 250);
            this.labelHeadF.Name = "labelHeadF";
            this.labelHeadF.Size = new System.Drawing.Size(140, 14);
            this.labelHeadF.TabIndex = 14;
            this.labelHeadF.Text = "( 内 ) 质监当罚字〔";
            // 
            // textBoxYearF
            // 
            this.textBoxYearF.Location = new System.Drawing.Point(274, 242);
            this.textBoxYearF.Name = "textBoxYearF";
            this.textBoxYearF.Size = new System.Drawing.Size(34, 23);
            this.textBoxYearF.TabIndex = 15;
            // 
            // labelLinkF
            // 
            this.labelLinkF.AutoSize = true;
            this.labelLinkF.BackColor = System.Drawing.Color.Transparent;
            this.labelLinkF.Location = new System.Drawing.Point(314, 251);
            this.labelLinkF.Name = "labelLinkF";
            this.labelLinkF.Size = new System.Drawing.Size(35, 14);
            this.labelLinkF.TabIndex = 16;
            this.labelLinkF.Text = "〕DM";
            // 
            // textBoxNoF
            // 
            this.textBoxNoF.Location = new System.Drawing.Point(348, 246);
            this.textBoxNoF.Name = "textBoxNoF";
            this.textBoxNoF.Size = new System.Drawing.Size(86, 23);
            this.textBoxNoF.TabIndex = 17;
            // 
            // labelTailF
            // 
            this.labelTailF.AutoSize = true;
            this.labelTailF.BackColor = System.Drawing.Color.Transparent;
            this.labelTailF.Location = new System.Drawing.Point(440, 250);
            this.labelTailF.Name = "labelTailF";
            this.labelTailF.Size = new System.Drawing.Size(21, 14);
            this.labelTailF.TabIndex = 18;
            this.labelTailF.Text = "号";
            // 
            // labelFMH
            // 
            this.labelFMH.AutoSize = true;
            this.labelFMH.BackColor = System.Drawing.Color.Transparent;
            this.labelFMH.Location = new System.Drawing.Point(282, 289);
            this.labelFMH.Name = "labelFMH";
            this.labelFMH.Size = new System.Drawing.Size(77, 14);
            this.labelFMH.TabIndex = 19;
            this.labelFMH.Text = "罚款金额：";
            // 
            // textBoxFM
            // 
            this.textBoxFM.Location = new System.Drawing.Point(348, 286);
            this.textBoxFM.Name = "textBoxFM";
            this.textBoxFM.Size = new System.Drawing.Size(86, 23);
            this.textBoxFM.TabIndex = 20;
            // 
            // labelFMT
            // 
            this.labelFMT.AutoSize = true;
            this.labelFMT.BackColor = System.Drawing.Color.Transparent;
            this.labelFMT.Location = new System.Drawing.Point(440, 289);
            this.labelFMT.Name = "labelFMT";
            this.labelFMT.Size = new System.Drawing.Size(21, 14);
            this.labelFMT.TabIndex = 21;
            this.labelFMT.Text = "元";
            // 
            // labelHandleDate
            // 
            this.labelHandleDate.AutoSize = true;
            this.labelHandleDate.BackColor = System.Drawing.Color.Transparent;
            this.labelHandleDate.Location = new System.Drawing.Point(31, 340);
            this.labelHandleDate.Name = "labelHandleDate";
            this.labelHandleDate.Size = new System.Drawing.Size(77, 14);
            this.labelHandleDate.TabIndex = 22;
            this.labelHandleDate.Text = "处理日期：";
            // 
            // textBoxHandleDate
            // 
            this.textBoxHandleDate.Location = new System.Drawing.Point(127, 337);
            this.textBoxHandleDate.Name = "textBoxHandleDate";
            this.textBoxHandleDate.Size = new System.Drawing.Size(133, 23);
            this.textBoxHandleDate.TabIndex = 23;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(308, 331);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 32);
            this.buttonSubmit.TabIndex = 24;
            this.buttonSubmit.Text = "提 交";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // tLeftInstituteBindingSource
            // 
            this.tLeftInstituteBindingSource.DataMember = "T_LeftInstitute";
            this.tLeftInstituteBindingSource.DataSource = this.ZFLRData;
            // 
            // ZFLRData
            // 
            this.ZFLRData.DataSetName = "ZFLRData";
            this.ZFLRData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_LeftInstituteTableAdapter
            // 
            this.t_LeftInstituteTableAdapter.ClearBeforeFill = true;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(417, 331);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 32);
            this.buttonExit.TabIndex = 26;
            this.buttonExit.Text = "退 出";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // dGInstituteInf
            // 
            this.dGInstituteInf.AutoGenerateColumns = false;
            this.dGInstituteInf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGInstituteInf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.leftInstituteCodeDataGridViewTextBoxColumn,
            this.leftInstituteNameDataGridViewTextBoxColumn,
            this.leftDeadlineDataGridViewTextBoxColumn});
            this.dGInstituteInf.DataSource = this.tLeftInstituteBindingSource;
            this.dGInstituteInf.Location = new System.Drawing.Point(34, 66);
            this.dGInstituteInf.Name = "dGInstituteInf";
            this.dGInstituteInf.RowTemplate.Height = 23;
            this.dGInstituteInf.Size = new System.Drawing.Size(458, 131);
            this.dGInstituteInf.TabIndex = 27;
            // 
            // leftInstituteCodeDataGridViewTextBoxColumn
            // 
            this.leftInstituteCodeDataGridViewTextBoxColumn.DataPropertyName = "LeftInstituteCode";
            this.leftInstituteCodeDataGridViewTextBoxColumn.HeaderText = "机构代码";
            this.leftInstituteCodeDataGridViewTextBoxColumn.Name = "leftInstituteCodeDataGridViewTextBoxColumn";
            // 
            // leftInstituteNameDataGridViewTextBoxColumn
            // 
            this.leftInstituteNameDataGridViewTextBoxColumn.DataPropertyName = "LeftInstituteName";
            this.leftInstituteNameDataGridViewTextBoxColumn.HeaderText = "机构名称";
            this.leftInstituteNameDataGridViewTextBoxColumn.Name = "leftInstituteNameDataGridViewTextBoxColumn";
            this.leftInstituteNameDataGridViewTextBoxColumn.Width = 195;
            // 
            // leftDeadlineDataGridViewTextBoxColumn
            // 
            this.leftDeadlineDataGridViewTextBoxColumn.DataPropertyName = "LeftDeadline";
            this.leftDeadlineDataGridViewTextBoxColumn.HeaderText = "作废日期";
            this.leftDeadlineDataGridViewTextBoxColumn.Name = "leftDeadlineDataGridViewTextBoxColumn";
            this.leftDeadlineDataGridViewTextBoxColumn.Width = 120;
            // 
            // ZFLR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(549, 384);
            this.Controls.Add(this.dGInstituteInf);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBoxHandleDate);
            this.Controls.Add(this.labelHandleDate);
            this.Controls.Add(this.labelFMT);
            this.Controls.Add(this.textBoxFM);
            this.Controls.Add(this.labelFMH);
            this.Controls.Add(this.labelTailF);
            this.Controls.Add(this.textBoxNoF);
            this.Controls.Add(this.labelLinkF);
            this.Controls.Add(this.textBoxYearF);
            this.Controls.Add(this.labelHeadF);
            this.Controls.Add(this.labelTailM);
            this.Controls.Add(this.textBoxNoM);
            this.Controls.Add(this.labelLinkM);
            this.Controls.Add(this.textBoxYearM);
            this.Controls.Add(this.labelHeadM);
            this.Controls.Add(this.radioButtonFine);
            this.Controls.Add(this.radioButtonModify);
            this.Controls.Add(this.labeldateName);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelrelay);
            this.Controls.Add(this.buttonSearchCode);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.labelCode);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ZFLR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "执法录入";
            this.Load += new System.EventHandler(this.zflr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tLeftInstituteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZFLRData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGInstituteInf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.Button buttonSearchCode;
        private System.Windows.Forms.Label labelrelay;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labeldateName;
        private System.Windows.Forms.RadioButton radioButtonModify;
        private System.Windows.Forms.RadioButton radioButtonFine;
        private System.Windows.Forms.Label labelHeadM;
        private System.Windows.Forms.TextBox textBoxYearM;
        private System.Windows.Forms.Label labelLinkM;
        private System.Windows.Forms.TextBox textBoxNoM;
        private System.Windows.Forms.Label labelTailM;
        private System.Windows.Forms.Label labelHeadF;
        private System.Windows.Forms.TextBox textBoxYearF;
        private System.Windows.Forms.Label labelLinkF;
        private System.Windows.Forms.TextBox textBoxNoF;
        private System.Windows.Forms.Label labelTailF;
        private System.Windows.Forms.Label labelFMH;
        private System.Windows.Forms.TextBox textBoxFM;
        private System.Windows.Forms.Label labelFMT;
        private System.Windows.Forms.Label labelHandleDate;
        private System.Windows.Forms.TextBox textBoxHandleDate;
        private System.Windows.Forms.Button buttonSubmit;
        private zflrData ZFLRData;
        private System.Windows.Forms.BindingSource tLeftInstituteBindingSource;
        private zfkDataSet1TableAdapters.T_LeftInstituteTableAdapter t_LeftInstituteTableAdapter;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.DataGridView dGInstituteInf;
        private System.Windows.Forms.DataGridViewTextBoxColumn leftInstituteCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leftInstituteNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leftDeadlineDataGridViewTextBoxColumn;
    }
}
namespace TM
{
    partial class SearchCountCH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchCountCH));
            this.labelChose = new System.Windows.Forms.Label();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.buttonCompare = new System.Windows.Forms.Button();
            this.dataGridViewCH = new System.Windows.Forms.DataGridView();
            this.leftInstituteCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftInstituteNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftDeadlineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCompareHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchCountCHData = new TM.searchCountCHData();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelCountNum = new System.Windows.Forms.Label();
            this.buttonOutput = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.t_CompareHistoryTableAdapter = new TM.searchCountCHDataTableAdapters.T_CompareHistoryTableAdapter();
            this.buttonInputNewData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCompareHistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchCountCHData)).BeginInit();
            this.SuspendLayout();
            // 
            // labelChose
            // 
            this.labelChose.AutoSize = true;
            this.labelChose.BackColor = System.Drawing.Color.Transparent;
            this.labelChose.Location = new System.Drawing.Point(17, 37);
            this.labelChose.Name = "labelChose";
            this.labelChose.Size = new System.Drawing.Size(77, 14);
            this.labelChose.TabIndex = 0;
            this.labelChose.Text = "选择路径：";
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxFilePath.Enabled = false;
            this.textBoxFilePath.ForeColor = System.Drawing.Color.Transparent;
            this.textBoxFilePath.Location = new System.Drawing.Point(93, 34);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.Size = new System.Drawing.Size(213, 23);
            this.textBoxFilePath.TabIndex = 1;
            // 
            // buttonCompare
            // 
            this.buttonCompare.Location = new System.Drawing.Point(438, 28);
            this.buttonCompare.Name = "buttonCompare";
            this.buttonCompare.Size = new System.Drawing.Size(75, 32);
            this.buttonCompare.TabIndex = 2;
            this.buttonCompare.Text = "比 对";
            this.buttonCompare.UseVisualStyleBackColor = true;
            this.buttonCompare.Click += new System.EventHandler(this.buttonCompare_Click);
            // 
            // dataGridViewCH
            // 
            this.dataGridViewCH.AutoGenerateColumns = false;
            this.dataGridViewCH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.leftInstituteCodeDataGridViewTextBoxColumn,
            this.leftInstituteNameDataGridViewTextBoxColumn,
            this.leftDeadlineDataGridViewTextBoxColumn});
            this.dataGridViewCH.DataSource = this.tCompareHistoryBindingSource;
            this.dataGridViewCH.Location = new System.Drawing.Point(20, 79);
            this.dataGridViewCH.Name = "dataGridViewCH";
            this.dataGridViewCH.RowTemplate.Height = 23;
            this.dataGridViewCH.Size = new System.Drawing.Size(493, 211);
            this.dataGridViewCH.TabIndex = 3;
            // 
            // leftInstituteCodeDataGridViewTextBoxColumn
            // 
            this.leftInstituteCodeDataGridViewTextBoxColumn.DataPropertyName = "leftInstituteCode";
            this.leftInstituteCodeDataGridViewTextBoxColumn.HeaderText = "代码号";
            this.leftInstituteCodeDataGridViewTextBoxColumn.Name = "leftInstituteCodeDataGridViewTextBoxColumn";
            this.leftInstituteCodeDataGridViewTextBoxColumn.Width = 120;
            // 
            // leftInstituteNameDataGridViewTextBoxColumn
            // 
            this.leftInstituteNameDataGridViewTextBoxColumn.DataPropertyName = "leftInstituteName";
            this.leftInstituteNameDataGridViewTextBoxColumn.HeaderText = "企业名称";
            this.leftInstituteNameDataGridViewTextBoxColumn.Name = "leftInstituteNameDataGridViewTextBoxColumn";
            this.leftInstituteNameDataGridViewTextBoxColumn.Width = 210;
            // 
            // leftDeadlineDataGridViewTextBoxColumn
            // 
            this.leftDeadlineDataGridViewTextBoxColumn.DataPropertyName = "leftDeadline";
            this.leftDeadlineDataGridViewTextBoxColumn.HeaderText = "历史过期时间";
            this.leftDeadlineDataGridViewTextBoxColumn.Name = "leftDeadlineDataGridViewTextBoxColumn";
            this.leftDeadlineDataGridViewTextBoxColumn.Width = 120;
            // 
            // tCompareHistoryBindingSource
            // 
            this.tCompareHistoryBindingSource.DataMember = "T_CompareHistory";
            this.tCompareHistoryBindingSource.DataSource = this.searchCountCHData;
            // 
            // searchCountCHData
            // 
            this.searchCountCHData.DataSetName = "searchCountCHData";
            this.searchCountCHData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.BackColor = System.Drawing.Color.Transparent;
            this.labelCount.Location = new System.Drawing.Point(17, 315);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(49, 14);
            this.labelCount.TabIndex = 4;
            this.labelCount.Text = "总计：";
            // 
            // labelCountNum
            // 
            this.labelCountNum.AutoSize = true;
            this.labelCountNum.BackColor = System.Drawing.Color.Transparent;
            this.labelCountNum.ForeColor = System.Drawing.Color.Red;
            this.labelCountNum.Location = new System.Drawing.Point(80, 315);
            this.labelCountNum.Name = "labelCountNum";
            this.labelCountNum.Size = new System.Drawing.Size(14, 14);
            this.labelCountNum.TabIndex = 5;
            this.labelCountNum.Text = "0";
            // 
            // buttonOutput
            // 
            this.buttonOutput.Location = new System.Drawing.Point(333, 340);
            this.buttonOutput.Name = "buttonOutput";
            this.buttonOutput.Size = new System.Drawing.Size(75, 32);
            this.buttonOutput.TabIndex = 6;
            this.buttonOutput.Text = "导 出";
            this.buttonOutput.UseVisualStyleBackColor = true;
            this.buttonOutput.Click += new System.EventHandler(this.buttonOutput_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(438, 340);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 32);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "退 出";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // t_CompareHistoryTableAdapter
            // 
            this.t_CompareHistoryTableAdapter.ClearBeforeFill = true;
            // 
            // buttonInputNewData
            // 
            this.buttonInputNewData.Location = new System.Drawing.Point(333, 28);
            this.buttonInputNewData.Name = "buttonInputNewData";
            this.buttonInputNewData.Size = new System.Drawing.Size(75, 32);
            this.buttonInputNewData.TabIndex = 8;
            this.buttonInputNewData.Text = "导入数据";
            this.buttonInputNewData.UseVisualStyleBackColor = true;
            this.buttonInputNewData.Click += new System.EventHandler(this.buttonInputNewData_Click);
            // 
            // SearchCountCH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(549, 384);
            this.Controls.Add(this.buttonInputNewData);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonOutput);
            this.Controls.Add(this.labelCountNum);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.dataGridViewCH);
            this.Controls.Add(this.buttonCompare);
            this.Controls.Add(this.textBoxFilePath);
            this.Controls.Add(this.labelChose);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "SearchCountCH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查询统计历史比对";
            this.Load += new System.EventHandler(this.SearchCountCH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCompareHistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchCountCHData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelChose;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.Button buttonCompare;
        private System.Windows.Forms.DataGridView dataGridViewCH;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelCountNum;
        private System.Windows.Forms.Button buttonOutput;
        private System.Windows.Forms.Button buttonExit;
        private searchCountCHData searchCountCHData;
        private System.Windows.Forms.BindingSource tCompareHistoryBindingSource;
        private searchCountCHDataTableAdapters.T_CompareHistoryTableAdapter t_CompareHistoryTableAdapter;
        private System.Windows.Forms.Button buttonInputNewData;
        private System.Windows.Forms.DataGridViewTextBoxColumn leftInstituteCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leftInstituteNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leftDeadlineDataGridViewTextBoxColumn;
    }
}
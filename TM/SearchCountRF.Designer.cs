namespace TM
{
    partial class SearchCountRF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchCountRF));
            this.labelStartDate = new System.Windows.Forms.Label();
            this.textBoxStartDate = new System.Windows.Forms.TextBox();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.textBoxEndDate = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dataGridViewRF = new System.Windows.Forms.DataGridView();
            this.leftInstituteCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftInstituteNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fineHandleContentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fineMoneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tRequireFineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchCountRFData = new TM.searchCountRFData();
            this.t_RequireFineTableAdapter = new TM.searchCountRFDataTableAdapters.T_RequireFineTableAdapter();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelCountNum = new System.Windows.Forms.Label();
            this.labelMoneyCount = new System.Windows.Forms.Label();
            this.labelMoneyCountShow = new System.Windows.Forms.Label();
            this.buttonOutput = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRequireFineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchCountRFData)).BeginInit();
            this.SuspendLayout();
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.BackColor = System.Drawing.Color.Transparent;
            this.labelStartDate.Location = new System.Drawing.Point(21, 28);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(63, 14);
            this.labelStartDate.TabIndex = 0;
            this.labelStartDate.Text = "起始日期";
            // 
            // textBoxStartDate
            // 
            this.textBoxStartDate.Location = new System.Drawing.Point(90, 25);
            this.textBoxStartDate.Name = "textBoxStartDate";
            this.textBoxStartDate.Size = new System.Drawing.Size(100, 23);
            this.textBoxStartDate.TabIndex = 1;
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.BackColor = System.Drawing.Color.Transparent;
            this.labelEndDate.Location = new System.Drawing.Point(216, 28);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(63, 14);
            this.labelEndDate.TabIndex = 2;
            this.labelEndDate.Text = "结束日期";
            // 
            // textBoxEndDate
            // 
            this.textBoxEndDate.Location = new System.Drawing.Point(285, 25);
            this.textBoxEndDate.Name = "textBoxEndDate";
            this.textBoxEndDate.Size = new System.Drawing.Size(100, 23);
            this.textBoxEndDate.TabIndex = 3;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(422, 19);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 32);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "查 询";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // dataGridViewRF
            // 
            this.dataGridViewRF.AutoGenerateColumns = false;
            this.dataGridViewRF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRF.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.leftInstituteCodeDataGridViewTextBoxColumn,
            this.leftInstituteNameDataGridViewTextBoxColumn,
            this.fineHandleContentDataGridViewTextBoxColumn,
            this.fineMoneyDataGridViewTextBoxColumn});
            this.dataGridViewRF.DataSource = this.tRequireFineBindingSource;
            this.dataGridViewRF.Location = new System.Drawing.Point(24, 69);
            this.dataGridViewRF.Name = "dataGridViewRF";
            this.dataGridViewRF.RowTemplate.Height = 23;
            this.dataGridViewRF.Size = new System.Drawing.Size(473, 210);
            this.dataGridViewRF.TabIndex = 5;
            // 
            // leftInstituteCodeDataGridViewTextBoxColumn
            // 
            this.leftInstituteCodeDataGridViewTextBoxColumn.DataPropertyName = "leftInstituteCode";
            this.leftInstituteCodeDataGridViewTextBoxColumn.HeaderText = "代码号";
            this.leftInstituteCodeDataGridViewTextBoxColumn.Name = "leftInstituteCodeDataGridViewTextBoxColumn";
            // 
            // leftInstituteNameDataGridViewTextBoxColumn
            // 
            this.leftInstituteNameDataGridViewTextBoxColumn.DataPropertyName = "leftInstituteName";
            this.leftInstituteNameDataGridViewTextBoxColumn.HeaderText = "企业名称";
            this.leftInstituteNameDataGridViewTextBoxColumn.Name = "leftInstituteNameDataGridViewTextBoxColumn";
            this.leftInstituteNameDataGridViewTextBoxColumn.Width = 115;
            // 
            // fineHandleContentDataGridViewTextBoxColumn
            // 
            this.fineHandleContentDataGridViewTextBoxColumn.DataPropertyName = "fineHandleContent";
            this.fineHandleContentDataGridViewTextBoxColumn.HeaderText = "文书字号";
            this.fineHandleContentDataGridViewTextBoxColumn.Name = "fineHandleContentDataGridViewTextBoxColumn";
            this.fineHandleContentDataGridViewTextBoxColumn.Width = 115;
            // 
            // fineMoneyDataGridViewTextBoxColumn
            // 
            this.fineMoneyDataGridViewTextBoxColumn.DataPropertyName = "fineMoney";
            this.fineMoneyDataGridViewTextBoxColumn.HeaderText = "金额";
            this.fineMoneyDataGridViewTextBoxColumn.Name = "fineMoneyDataGridViewTextBoxColumn";
            // 
            // tRequireFineBindingSource
            // 
            this.tRequireFineBindingSource.DataMember = "T_RequireFine";
            this.tRequireFineBindingSource.DataSource = this.searchCountRFData;
            // 
            // searchCountRFData
            // 
            this.searchCountRFData.DataSetName = "searchCountRFData";
            this.searchCountRFData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_RequireFineTableAdapter
            // 
            this.t_RequireFineTableAdapter.ClearBeforeFill = true;
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.BackColor = System.Drawing.Color.Transparent;
            this.labelCount.Location = new System.Drawing.Point(21, 293);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(49, 14);
            this.labelCount.TabIndex = 6;
            this.labelCount.Text = "总计：";
            // 
            // labelCountNum
            // 
            this.labelCountNum.AutoSize = true;
            this.labelCountNum.BackColor = System.Drawing.Color.Transparent;
            this.labelCountNum.ForeColor = System.Drawing.Color.Red;
            this.labelCountNum.Location = new System.Drawing.Point(70, 293);
            this.labelCountNum.Name = "labelCountNum";
            this.labelCountNum.Size = new System.Drawing.Size(14, 14);
            this.labelCountNum.TabIndex = 7;
            this.labelCountNum.Text = "0";
            // 
            // labelMoneyCount
            // 
            this.labelMoneyCount.AutoSize = true;
            this.labelMoneyCount.BackColor = System.Drawing.Color.Transparent;
            this.labelMoneyCount.Location = new System.Drawing.Point(216, 293);
            this.labelMoneyCount.Name = "labelMoneyCount";
            this.labelMoneyCount.Size = new System.Drawing.Size(77, 14);
            this.labelMoneyCount.TabIndex = 8;
            this.labelMoneyCount.Text = "金额总计：";
            // 
            // labelMoneyCountShow
            // 
            this.labelMoneyCountShow.AutoSize = true;
            this.labelMoneyCountShow.BackColor = System.Drawing.Color.Transparent;
            this.labelMoneyCountShow.ForeColor = System.Drawing.Color.Red;
            this.labelMoneyCountShow.Location = new System.Drawing.Point(299, 293);
            this.labelMoneyCountShow.Name = "labelMoneyCountShow";
            this.labelMoneyCountShow.Size = new System.Drawing.Size(14, 14);
            this.labelMoneyCountShow.TabIndex = 9;
            this.labelMoneyCountShow.Text = "0";
            // 
            // buttonOutput
            // 
            this.buttonOutput.Location = new System.Drawing.Point(285, 331);
            this.buttonOutput.Name = "buttonOutput";
            this.buttonOutput.Size = new System.Drawing.Size(75, 32);
            this.buttonOutput.TabIndex = 10;
            this.buttonOutput.Text = "导 出";
            this.buttonOutput.UseVisualStyleBackColor = true;
            this.buttonOutput.Click += new System.EventHandler(this.buttonOutput_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(422, 331);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 32);
            this.buttonExit.TabIndex = 11;
            this.buttonExit.Text = "退 出";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // SearchCountRF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(549, 384);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonOutput);
            this.Controls.Add(this.labelMoneyCountShow);
            this.Controls.Add(this.labelMoneyCount);
            this.Controls.Add(this.labelCountNum);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.dataGridViewRF);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxEndDate);
            this.Controls.Add(this.labelEndDate);
            this.Controls.Add(this.textBoxStartDate);
            this.Controls.Add(this.labelStartDate);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "SearchCountRF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查询统计当场处罚";
            this.Load += new System.EventHandler(this.SearchCountRF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRequireFineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchCountRFData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.TextBox textBoxStartDate;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.TextBox textBoxEndDate;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridView dataGridViewRF;
        private searchCountRFData searchCountRFData;
        private System.Windows.Forms.BindingSource tRequireFineBindingSource;
        private searchCountRFDataTableAdapters.T_RequireFineTableAdapter t_RequireFineTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn leftInstituteCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leftInstituteNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fineHandleContentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fineMoneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelCountNum;
        private System.Windows.Forms.Label labelMoneyCount;
        private System.Windows.Forms.Label labelMoneyCountShow;
        private System.Windows.Forms.Button buttonOutput;
        private System.Windows.Forms.Button buttonExit;
    }
}
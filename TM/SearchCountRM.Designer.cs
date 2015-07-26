namespace TM
{
    partial class SearchCountRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchCountRM));
            this.labelStartDate = new System.Windows.Forms.Label();
            this.textBoxStartDate = new System.Windows.Forms.TextBox();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.textBoxEndDate = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dataGridViewRM = new System.Windows.Forms.DataGridView();
            this.leftInstituteCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftInstituteNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifyHandleContentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tRequireModifyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchCountRMData = new TM.searchCountRMData();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelCountNum = new System.Windows.Forms.Label();
            this.buttonOutput = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.t_RequireModifyTableAdapter = new TM.searchCountRMDataTableAdapters.T_RequireModifyTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRequireModifyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchCountRMData)).BeginInit();
            this.SuspendLayout();
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.BackColor = System.Drawing.Color.Transparent;
            this.labelStartDate.Location = new System.Drawing.Point(22, 25);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(63, 14);
            this.labelStartDate.TabIndex = 0;
            this.labelStartDate.Text = "起始日期";
            // 
            // textBoxStartDate
            // 
            this.textBoxStartDate.Location = new System.Drawing.Point(91, 22);
            this.textBoxStartDate.Name = "textBoxStartDate";
            this.textBoxStartDate.Size = new System.Drawing.Size(100, 23);
            this.textBoxStartDate.TabIndex = 1;
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.BackColor = System.Drawing.Color.Transparent;
            this.labelEndDate.Location = new System.Drawing.Point(219, 25);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(63, 14);
            this.labelEndDate.TabIndex = 2;
            this.labelEndDate.Text = "结束日期";
            // 
            // textBoxEndDate
            // 
            this.textBoxEndDate.Location = new System.Drawing.Point(288, 22);
            this.textBoxEndDate.Name = "textBoxEndDate";
            this.textBoxEndDate.Size = new System.Drawing.Size(100, 23);
            this.textBoxEndDate.TabIndex = 3;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(415, 16);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 32);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "查 询";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // dataGridViewRM
            // 
            this.dataGridViewRM.AutoGenerateColumns = false;
            this.dataGridViewRM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.leftInstituteCodeDataGridViewTextBoxColumn,
            this.leftInstituteNameDataGridViewTextBoxColumn,
            this.modifyHandleContentDataGridViewTextBoxColumn});
            this.dataGridViewRM.DataSource = this.tRequireModifyBindingSource;
            this.dataGridViewRM.Location = new System.Drawing.Point(25, 70);
            this.dataGridViewRM.Name = "dataGridViewRM";
            this.dataGridViewRM.RowTemplate.Height = 23;
            this.dataGridViewRM.Size = new System.Drawing.Size(465, 211);
            this.dataGridViewRM.TabIndex = 5;
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
            this.leftInstituteNameDataGridViewTextBoxColumn.Width = 142;
            // 
            // modifyHandleContentDataGridViewTextBoxColumn
            // 
            this.modifyHandleContentDataGridViewTextBoxColumn.DataPropertyName = "modifyHandleContent";
            this.modifyHandleContentDataGridViewTextBoxColumn.HeaderText = "文书字号";
            this.modifyHandleContentDataGridViewTextBoxColumn.Name = "modifyHandleContentDataGridViewTextBoxColumn";
            this.modifyHandleContentDataGridViewTextBoxColumn.Width = 180;
            // 
            // tRequireModifyBindingSource
            // 
            this.tRequireModifyBindingSource.DataMember = "T_RequireModify";
            this.tRequireModifyBindingSource.DataSource = this.searchCountRMData;
            // 
            // searchCountRMData
            // 
            this.searchCountRMData.DataSetName = "searchCountRMData";
            this.searchCountRMData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.BackColor = System.Drawing.Color.Transparent;
            this.labelCount.Location = new System.Drawing.Point(25, 309);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(42, 14);
            this.labelCount.TabIndex = 6;
            this.labelCount.Text = "总计:";
            // 
            // labelCountNum
            // 
            this.labelCountNum.AutoSize = true;
            this.labelCountNum.BackColor = System.Drawing.Color.Transparent;
            this.labelCountNum.ForeColor = System.Drawing.Color.Red;
            this.labelCountNum.Location = new System.Drawing.Point(73, 309);
            this.labelCountNum.Name = "labelCountNum";
            this.labelCountNum.Size = new System.Drawing.Size(14, 14);
            this.labelCountNum.TabIndex = 7;
            this.labelCountNum.Text = "0";
            // 
            // buttonOutput
            // 
            this.buttonOutput.Location = new System.Drawing.Point(288, 331);
            this.buttonOutput.Name = "buttonOutput";
            this.buttonOutput.Size = new System.Drawing.Size(75, 32);
            this.buttonOutput.TabIndex = 8;
            this.buttonOutput.Text = "导 出";
            this.buttonOutput.UseVisualStyleBackColor = true;
            this.buttonOutput.Click += new System.EventHandler(this.buttonOutput_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(415, 331);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 32);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.Text = "退 出";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // t_RequireModifyTableAdapter
            // 
            this.t_RequireModifyTableAdapter.ClearBeforeFill = true;
            // 
            // SearchCountRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(549, 384);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonOutput);
            this.Controls.Add(this.labelCountNum);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.dataGridViewRM);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxEndDate);
            this.Controls.Add(this.labelEndDate);
            this.Controls.Add(this.textBoxStartDate);
            this.Controls.Add(this.labelStartDate);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "SearchCountRM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查询统计责令整改";
            this.Load += new System.EventHandler(this.SearchCountRM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRequireModifyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchCountRMData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.TextBox textBoxStartDate;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.TextBox textBoxEndDate;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridView dataGridViewRM;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelCountNum;
        private System.Windows.Forms.Button buttonOutput;
        private System.Windows.Forms.Button buttonExit;
        private searchCountRMData searchCountRMData;
        private System.Windows.Forms.BindingSource tRequireModifyBindingSource;
        private searchCountRMDataTableAdapters.T_RequireModifyTableAdapter t_RequireModifyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn leftInstituteCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leftInstituteNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifyHandleContentDataGridViewTextBoxColumn;
    }
}
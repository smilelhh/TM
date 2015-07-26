using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TM
{
    public partial class SearchCountRM : Form
    {
        public DateTime startDate;
        public DateTime endDate;
        public SearchCountRM()
        {
            InitializeComponent();
        }

        private void SearchCountRM_Load(object sender, EventArgs e)
        {
            this.t_RequireModifyTableAdapter.Fill(this.searchCountRMData.T_RequireModify);
            textBoxStartDate.Text = DateTime.Now.Date.ToShortDateString().Trim();
            textBoxEndDate.Text = DateTime.Now.Date.ToShortDateString().Trim();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int rowNum = 0;
            startDate = Convert.ToDateTime(textBoxStartDate.Text.Trim());
            endDate = Convert.ToDateTime(textBoxEndDate.Text.Trim());
            string connString = "Data Source=.;Initial Catalog=zfk;Integrated Security=True;Pooling=False";
            string sql = "select * from T_RequireModify where handleDate between '" + startDate + "'and '" + endDate + "'";
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dataGridViewRM.DataSource = ds.Tables[0].DefaultView;
                rowNum = dataGridViewRM.Rows.Count-1;
                labelCountNum.Text = rowNum.ToString();
              /*  dataGridView1.Rows.Count返回的是dataGridView1的行数
                dataGridView1.Rows[0]就是dataGridView1的第1行,
                可以通过dataGridView1.Rows[0].Cells[i]或
                dataGridView1.Rows[0].Column[j]对第1行的第i个单元格或第1行的第j列进行操作  */

            }
            catch (Exception)
            {
                MessageBox.Show("！查询责令整改信息失败", "友情提示");
            }
            finally
            {
                conn.Close();
            }
        }

        private void buttonOutput_Click(object sender, EventArgs e)
        {
            OutputExcel oe = new OutputExcel();
            oe.coutExcel(dataGridViewRM);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

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
    public partial class SearchCountRF : Form
    {
        public DateTime startDate;
        public DateTime endDate;
        public SearchCountRF()
        {
            InitializeComponent();
        }

        private void SearchCountRF_Load(object sender, EventArgs e)
        {
            this.t_RequireFineTableAdapter.Fill(this.searchCountRFData.T_RequireFine);
            textBoxStartDate.Text = DateTime.Now.Date.ToShortDateString().Trim();
            textBoxEndDate.Text = DateTime.Now.Date.ToShortDateString().Trim();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int rowNum = 0;
            int moneyNum = 0;
            startDate = Convert.ToDateTime(textBoxStartDate.Text.Trim());
            endDate = Convert.ToDateTime(textBoxEndDate.Text.Trim());
            string connString = "Data Source=.;Initial Catalog=zfk;Integrated Security=True;Pooling=False";
            string sql = "select * from T_RequireFine where handleDate between '" + startDate + "'and '" + endDate + "'";
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dataGridViewRF.DataSource = ds.Tables[0].DefaultView;
                rowNum = dataGridViewRF.Rows.Count - 1;
                labelCountNum.Text = rowNum.ToString();
                try
                {
                    for (int i = 0; i < rowNum; i++)
                    {
                        //Console.WriteLine(dataGridViewRF.Rows[i].Cells[3].Value);
                        moneyNum += Convert.ToInt32(dataGridViewRF.Rows[i].Cells[3].Value);
                    }
                    labelMoneyCountShow.Text = moneyNum.ToString();
                }
                catch 
                {
                    MessageBox.Show("！处理金额信息失败", "友情提示");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("！查询当场处罚信息失败", "友情提示");
            }
            finally
            {
                conn.Close();
            }
        }

        private void buttonOutput_Click(object sender, EventArgs e)
        {
            OutputExcel oe = new OutputExcel();
            oe.coutExcel(dataGridViewRF);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

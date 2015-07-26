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
    public partial class SearchCountCH : Form
    {
        public string leftInstituteCode;
        public string leftInstituteName;
        public DateTime leftDeadline;
        public string filePath;
        
        public SearchCountCH()
        {
            InitializeComponent();
        }

        private void SearchCountCH_Load(object sender, EventArgs e)
        {
            this.t_CompareHistoryTableAdapter.Fill(this.searchCountCHData.T_CompareHistory);
        }

        private void buttonInputNewData_Click(object sender, EventArgs e)
        {
           string connString = "Data Source=.;Initial Catalog=zfk;Integrated Security=True;Pooling=False";
            SqlConnection conn1 = new SqlConnection(connString);
            try
            {
                conn1.Open();
                string sql = "delete FROM T_TempStore";
                SqlCommand cmd = new SqlCommand(sql, conn1);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("!删除T_TempStore表失败", "友情提示");
            }
            finally
            {
                conn1.Close();
            }

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            textBoxFilePath.Text = ofd.FileName;
            filePath = textBoxFilePath.Text.Trim();
            if (MessageBox.Show("大量数据导入耗时较长，请耐心等待，是否导入？", "友情提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    ExcelOutputSql es = new ExcelOutputSql();

                    DataSet ds = es.ImportFromExcel(filePath);
                    DataTable dt = ds.Tables[0];

                    SqlConnection conn2 = new SqlConnection(connString);
                    try
                    {
                        conn2.Open();
                        string strInsertComm;
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            strInsertComm = "";
                            strInsertComm = "Insert INTO T_TempStore([leftInstituteCode],[leftInstituteName],[leftDeadline])";
                            strInsertComm += " values(";
                            for (int j = 0; j < dt.Columns.Count; j++)
                            {
                                if (j > 0)
                                {
                                    strInsertComm += ",'" + dt.Rows[i][j].ToString().Trim() + "'";
                                }
                                else
                                {
                                    strInsertComm += "'" + dt.Rows[i][j].ToString().Trim() + "'";
                                }
                            }
                            strInsertComm += ")";
                            SqlCommand cmd = new SqlCommand(strInsertComm, conn2);
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("导入数据成功", "友情提示");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("！插入数据库失败", "友情提示");
                    }
                    finally
                    {
                        conn2.Close();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("！导入数据失败", "友情提示");
                }  
            }
            else
            {
                MessageBox.Show("!本月数据导入没有完成", "友情提示");
            }
        }

        private void buttonCompare_Click(object sender, EventArgs e)
        {
           // if (MessageBox.Show("是否已经导入本月数据？", "每月只能使用一次，切勿多次点击“比对”按钮！！", MessageBoxButtons.YesNo) == DialogResult.Yes)
           // {
                string connString = "Data Source=.;Initial Catalog=zfk;Integrated Security=True;Pooling=False";
                SqlConnection conn1 = new SqlConnection(connString);
                string sql1 = "insert into T_LeftInstitute select * from T_TempStore b where not exists(select 1 from T_LeftInstitute a where a.leftInstituteCode = b.leftInstituteCode)";
                try
                {
                    conn1.Open();
                    SqlCommand cmd1 = new SqlCommand(sql1, conn1);
                    cmd1.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    MessageBox.Show("！新数据插入历史遗留表失败", "友情提示");
                }
                finally
                {
                    conn1.Close();
                }
                SqlConnection conn2 = new SqlConnection(connString);
                string sql2 = "insert into T_CompareHistory select * from T_LeftInstitute except select * from T_TempStore";
                try
                {
                    conn2.Open();
                    SqlCommand cmd2 = new SqlCommand(sql2, conn2);
                    cmd2.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    MessageBox.Show("！对比数据插入对比表失败", "友情提示");
                }
                finally
                {
                    conn2.Close();
                }
                SqlConnection conn3 = new SqlConnection(connString);
                string sql3 = "delete from T_LeftInstitute where leftInstituteCode not in (select distinct leftInstituteCode from T_TempStore)";
                try
                {
                    conn3.Open();
                    SqlCommand cmd3 = new SqlCommand(sql3, conn3);
                    cmd3.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    MessageBox.Show("！从历史遗留表删除对比数据失败", "友情提示");
                }
                finally
                {
                    conn3.Close();
                }
                int rowNum = 0;
                string sql4 = "select * from T_CompareHistory";
                SqlConnection conn4 = new SqlConnection(connString);
                try
                {
                    conn4.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(sql4, conn4);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    dataGridViewCH.DataSource = ds.Tables[0].DefaultView;
                    rowNum = dataGridViewCH.Rows.Count - 1;
                    labelCountNum.Text = rowNum.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("！查询比对历史信息表失败", "友情提示");
                }
                finally
                {
                    conn4.Close();
                }               
           // }
          /*  else
            {
                MessageBox.Show("!请先导入本月数据", "友情提示");
            }*/
        }

        private void buttonOutput_Click(object sender, EventArgs e)
        {
            OutputExcel oe = new OutputExcel();
            oe.coutExcel(dataGridViewCH);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.OleDb;
using System.Data.SqlClient;

namespace TM
{
    public partial class InData : Form
    {
        public string filePath;
        public InData()
        {
            InitializeComponent();
        }

        private void buttonChose_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            textBoxFilePath.Text = ofd.FileName;
            filePath = textBoxFilePath.Text.Trim();
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("大量数据导入耗时较长，是否导入？", "友情提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    ExcelOutputSql es = new ExcelOutputSql();

                    DataSet ds = es.ImportFromExcel(filePath);
                    DataTable dt = ds.Tables[0];
                    string connString = "Data Source=.;Initial Catalog=zfk;Integrated Security=True;Pooling=False";
                    SqlConnection conn = new SqlConnection(connString);
                    try
                    {
                        conn.Open();
                        string strInsertComm;
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            strInsertComm = "";
                            strInsertComm = "Insert INTO T_LeftInstitute([leftInstituteCode],[leftInstituteName],[leftDeadline])";
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
                            SqlCommand cmd = new SqlCommand(strInsertComm, conn);
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("导入数据成功", "友情提示");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("！导入数据库失败", "友情提示");
                }  
            }
            else
            {
                MessageBox.Show("!系统初始化没有完成", "友情提示");
            }            
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

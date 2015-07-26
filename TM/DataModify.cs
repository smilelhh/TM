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
    public partial class DataModify : Form
    {
        public string instituteCode;

        public DataModify()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            Boolean f = false;
            instituteCode = textBoxHandledCode.Text.Trim();
            string connString = "Data Source=.;Initial Catalog=zfk;Integrated Security=True;Pooling=False";
            SqlConnection conn = new SqlConnection(connString); 

            string sqlone = "SELECT * FROM T_RequireModify where leftInstituteCode='" + instituteCode + "'";
            string sqltwo = "SELECT * FROM T_RequireFine where leftInstituteCode='" + instituteCode + "'"; 
           
            try
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(sqlone, conn);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                textBoxInstituteName.Text = ds.Tables[0].Rows[0][1].ToString();
                textBoxDeadline.Text = ds.Tables[0].Rows[0][2].ToString();
                textBoxHandleContent.Text = ds.Tables[0].Rows[0][3].ToString();
                textBoxFineMoney.Enabled = false;
                textBoxHandleDate.Text = ds.Tables[0].Rows[0][4].ToString();
                f = true;
            }
            catch (Exception)
            {
                f = false;
                //MessageBox.Show("！责令整改表没有此代码号，有可能在当场处罚表或者代码号输入有误", "友情提示");
            }
            finally
            {
                conn.Close();
            }
            if (!f)
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(sqltwo, conn);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    textBoxInstituteName.Text = ds.Tables[0].Rows[0][1].ToString();
                    textBoxDeadline.Text = ds.Tables[0].Rows[0][2].ToString();
                    textBoxHandleContent.Text = ds.Tables[0].Rows[0][3].ToString();
                    textBoxFineMoney.Text = ds.Tables[0].Rows[0][4].ToString();
                    textBoxHandleDate.Text = ds.Tables[0].Rows[0][5].ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("！输入的代码号错误，请重新输入", "友情提示");
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            DateTime deadline = new DateTime();
            deadline = Convert.ToDateTime(textBoxDeadline.Text.Trim());
            DateTime handleDate = new DateTime();
            handleDate = Convert.ToDateTime(textBoxHandleDate.Text.Trim());
            int fineMoney = 0;
            if (textBoxFineMoney.Text.Trim() != String.Empty)
            {
                fineMoney = System.Int32.Parse(textBoxFineMoney.Text.Trim());
            }
            string connString = "Data Source=.;Initial Catalog=zfk;Integrated Security=True;Pooling=False";
            SqlConnection conn = new SqlConnection(connString);
            string sqlRM = "update T_RequireModify set leftInstituteCode='" + textBoxHandledCode.Text.Trim() + "',leftInstituteName='" + textBoxInstituteName.Text.Trim() + "',leftDeadline='" + deadline + "',modifyHandleContent='" + textBoxHandleContent.Text.Trim() + "',handleDate='" + handleDate + "' where leftInstituteCode='" + textBoxHandledCode.Text.Trim() + "'";
            string sqlRF = "update T_RequireFine set leftInstituteCode='" + textBoxHandledCode.Text.Trim() + "',leftInstituteName='" + textBoxInstituteName.Text.Trim() + "',leftDeadline='" + deadline + "',fineHandleContent='" + textBoxHandleContent.Text.Trim() + "',fineMoney=" + fineMoney + ",handleDate='" + handleDate + "' where leftInstituteCode='" + textBoxHandledCode.Text.Trim() + "'";
            if (textBoxFineMoney.Text.Trim() == String.Empty)
            {
                try
                {
                    conn.Open();
                    SqlCommand cmdRM = new SqlCommand(sqlRM, conn);
                    cmdRM.ExecuteNonQuery();
                    MessageBox.Show("修改责令整改信息成功", "友情提示");
                }
                catch (Exception)
                {
                    MessageBox.Show("！修改责令整改信息失败", "友情提示");
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                try
                {
                    conn.Open();
                    SqlCommand cmdRF = new SqlCommand(sqlRF, conn);
                    cmdRF.ExecuteNonQuery();
                    MessageBox.Show("修改当场处罚信息成功", "友情提示");
                }
                catch (Exception)
                {
                    MessageBox.Show("！修改当场处罚信息失败", "友情提示");
                }
                finally
                {
                    conn.Close();
                }
            }                
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

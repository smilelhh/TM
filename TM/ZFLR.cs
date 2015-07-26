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
    public partial class ZFLR : Form
    {
        public string leftInstituteCode;
        public string leftInstituteName;
        public DateTime leftDeadline;
        public string instituteCode;
        public ZFLR()
        {
            InitializeComponent();
        }


        private void zflr_Load(object sender, EventArgs e)
        {
            this.t_LeftInstituteTableAdapter.Fill(this.ZFLRData.T_LeftInstitute);
            textBoxHandleDate.Text = DateTime.Now.Date.ToShortDateString().Trim();
        }

        private void buttonSearchCode_Click(object sender, EventArgs e)
        {
            instituteCode = textBoxCode.Text.Trim();
            string connString = "Data Source=.;Initial Catalog=zfk;Integrated Security=True;Pooling=False";
            string sql = "SELECT * FROM T_LeftInstitute where LeftInstituteCode='" + instituteCode + "'";
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dGInstituteInf.DataSource = ds.Tables[0].DefaultView;

                leftInstituteCode = ds.Tables[0].Rows[0][0].ToString();
                leftInstituteName = ds.Tables[0].Rows[0][1].ToString();
                leftDeadline = Convert.ToDateTime(ds.Tables[0].Rows[0][2].ToString());
                
                String deadline = ds.Tables[0].Rows[0][2].ToString();
                TimeSpan tt = System.DateTime.Now - Convert.ToDateTime(deadline);
                int days = Convert.ToInt32(tt.TotalDays);
                labelDate.Text = days.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("！查询机构信息失败", "友情提示");
            }
            finally
            {
                conn.Close();
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string modifyHandleContent=null;
            string fineHandleContent=null;
            int fineMoney =0;

            DateTime handleDate = new DateTime();
            handleDate = Convert.ToDateTime(textBoxHandleDate.Text.Trim());
            //string shortDate = handleDate.Date.ToShortDateString().Trim();

            string connString = "Data Source=.;Initial Catalog=zfk;Integrated Security=True;Pooling=False";
            SqlConnection conn = new SqlConnection(connString);
            if (radioButtonModify.Checked == true)
            {
                modifyHandleContent = labelHeadM.Text + textBoxYearM.Text.Trim() + labelLinkM.Text + textBoxNoM.Text.Trim() + labelTailM.Text;
              //  Console.WriteLine(leftInstituteCode + " " + leftInstituteName + " " + leftDeadline + " " + modifyHandleContent + " " + handleDate);
                try
                {
                    conn.Open();
                    string sql = "insert into T_RequireModify values('" + leftInstituteCode + "','" + leftInstituteName + "','" + leftDeadline + "','" + modifyHandleContent + "','" + handleDate+ "')";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("添加责令整改信息成功", "友情提示");
                }
                catch (Exception)
                {
                    MessageBox.Show("！添加责令整改信息失败", "友情提示");
                }
                finally
                {
                    conn.Close();
                }
            }
            if (radioButtonFine.Checked == true)
            {
                fineHandleContent = labelHeadF.Text + textBoxYearF.Text.Trim() + labelLinkF.Text + textBoxNoF.Text.Trim() + labelTailF.Text;
                fineMoney =System.Int32.Parse(textBoxFM.Text.Trim());
               // Console.WriteLine(leftInstituteCode + " " + leftInstituteName + " " + leftDeadline + " " + fineHandleContent + " " + fineMoney + " " + handleDate);
                try
                {
                    conn.Open();
                    string sql = "insert into T_RequireFine values('" + leftInstituteCode + "','" + leftInstituteName + "','" + leftDeadline + "','" + fineHandleContent + "'," + fineMoney + ",'" + handleDate + "')";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("添加当场处罚信息成功", "友情提示");
                }
                catch (Exception)
                {
                    MessageBox.Show("！添加当场处罚信息失败", "友情提示");
                }
                finally
                {
                    conn.Close();
                }
            }
            try
            {
                conn.Open();
                string sql = "delete from T_LeftInstitute where leftInstituteCode='" + instituteCode + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("!删除已处理机构信息失败", "友情提示");
            }
            finally
            {
                conn.Close();
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

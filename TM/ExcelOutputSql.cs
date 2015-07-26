using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GemBox.ExcelLite;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Collections;
using System.IO;
namespace TM
{
    class ExcelOutputSql
    {
        /// <summary>
        /// 将Excel中的数据导入到SQL数据库中
        /// </summary>
      /*  public void ExcelOut(string filePath)
        {
            DataSet ds = ImportFromExcel(filePath);
            DataTable dt = ds.Tables[0];
            string connString = "Data Source=.;Initial Catalog=zfk;Integrated Security=True;Pooling=False";
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();
                string strInsertComm;
                for (int i = 0; i < dt.Rows.Count-1; i++)
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
        }*/

        /// <summary>
        /// Excel导入数据库
        /// </summary>
        /// <returns></returns>
        public  DataSet ImportFromExcel(string FilePath)
        {
            return FillDataSet(FilePath);
        }

        /// <summary>
        /// 导入Excel数据表至DataTable（第一行作为表头）
        /// </summary>
        /// <returns></returns>
        public  System.Data.DataSet FillDataSet(string FilePath)
        {
            if (!File.Exists(FilePath))
            {
                throw new Exception("Excel文件不存在！");
            }

            ArrayList TableList = new ArrayList();
            TableList = GetExcelTables(FilePath);
            if (TableList.Count <= 0)
            {
                return null;
            }
            System.Data.DataTable table;
            System.Data.DataSet ds = new DataSet();
            OleDbConnection dbcon = new OleDbConnection(@"Provider=Microsoft.Ace.OLEDB.12.0;Data Source=" + FilePath + ";Extended Properties=Excel 12.0");
            try
            {
                if (dbcon.State == ConnectionState.Closed)
                {
                    dbcon.Open();
                }
                for (int i = 0; i < TableList.Count; i++)
                {
                    string dtname = TableList[i].ToString();
                    try
                    {
                        OleDbCommand cmd = new OleDbCommand("select * from [" + dtname + "$]", dbcon);
                        OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                        table = new DataTable(dtname);
                        adapter.Fill(table);
                        ds.Tables.Add(table);
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show(exp.Message);
                    }
                }
            }
            finally
            {
                if (dbcon.State == ConnectionState.Open)
                {
                    dbcon.Close();
                }
            }
            return ds;
        }

      //Excel导入SQL数据库
        /// <summary>
        /// 获取Excel数据表列表
        /// </summary>
        /// <returns></returns>
        public  ArrayList GetExcelTables(string FilePath)
        {
            //将Excel架构存入数据里
            System.Data.DataTable dt = new System.Data.DataTable();
            ArrayList TablesList = new ArrayList();

            if (File.Exists(FilePath))
            {
                using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Ace." +
                     "OLEDB.12.0;Extended Properties=\"Excel 12.0\";Data Source=" + FilePath))
                {
                    try
                    {
                        conn.Open();
                        dt = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show(exp.Message);
                    }

                    //获取数据表个数
                    int tablecount = dt.Rows.Count;
                    for (int i = 0; i < tablecount; i = i + 2)
                    {
                        string tablename = dt.Rows[i][2].ToString().Trim().TrimEnd('$');
                        if (TablesList.IndexOf(tablename) < 0)
                        {
                            TablesList.Add(tablename);
                        }
                    }
                }
            }
            return TablesList;
        }       
    }
}

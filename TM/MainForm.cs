using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TM
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void toolStripMenuItemInData_Click(object sender, EventArgs e)
        {
            InData iD = new InData();
            iD.ShowDialog(this);
        }

        private void ToolStripMenuItemZFLR_Click(object sender, EventArgs e)
        {
            ZFLR zf = new ZFLR();
            zf.ShowDialog(this);
        }


        private void ToolStripMenuItemDataModify_Click(object sender, EventArgs e)
        {
            DataModify df = new DataModify();
            df.ShowDialog(this);
        }

        private void ToolStripMenuItemSearchCountRM_Click(object sender, EventArgs e)
        {
            SearchCountRM sm = new SearchCountRM();
            sm.ShowDialog(this);
        }

        private void ToolStripMenuItemSearchCountRF_Click(object sender, EventArgs e)
        {
            SearchCountRF sf = new SearchCountRF();
            sf.ShowDialog(this);
        }

        private void ToolStripMenuItemSearchCountCH_Click(object sender, EventArgs e)
        {
            SearchCountCH sh = new SearchCountCH();
            sh.ShowDialog(this);
        }

        private void ToolStripMenuItemExitSystem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

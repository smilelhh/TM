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
    public partial class Process : Form
    {
        public Process()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            //用户要求取消时，就这样处理一下。有时不太灵喔。

            this.backgroundWorker.CancelAsync();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            //这一句，就是让后台工作开始。

            this.backgroundWorker.RunWorkerAsync();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        } 

        //这里就是通过响应消息，来处理界面的显示工作

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

            //this.progressBar.Value = e.ProgressPercentage;
            //this.labelShow.Text = e.UserState.ToString();
            //this.labelShow.Update();
        }


        //这里是后台工作完成后的消息处理，可以在这里进行后续的处理工作。

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("运算终于完成了");
        }

        //这里，就是后台进程开始工作时，调用工作函数的地方。你可以把你现有的处理函数写在这儿。

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            work(this.backgroundWorker);
        }

        //真正的处理工作

        private bool work(BackgroundWorker bk)
        {
            /*int tatle = 10000;

            for (int i = 0; i < tatle; i++)
            {
                if (bk.CancellationPending) //这里判断一下是否用户要求取消后台进行，并可以尽早退出。
                {
                    bk.ReportProgress(i, String.Format("当前值是 {0},操作被用户申请中断", i));
                    return false;
                }

                //处理的过程中，通过这个函数，向主线程报告处理进度，最好是折算成百分比，与外边的进度条的最大值必须要对应。这里，我没有折算，而是把界面线程的进度条最大值调整为与这里的总数一致。
                //bk.ReportProgress(i, String.Format("当前值是 {0}", i));
            }*/
            return true;         
        }      
    }
}

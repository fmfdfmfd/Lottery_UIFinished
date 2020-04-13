using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lottery
{
    public partial class FrmMain: Form
    {
        private Selector selector = new Selector();

        private List<string> numberList = null;

        public FrmMain()
        {
            InitializeComponent();
            btnSelect.Enabled = false;
        }

        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            numberList = selector.CreateRandomNumList();

            lblNum1.Text = numberList[0];
            lblNum2.Text = numberList[1];
            lblNum3.Text = numberList[2];
            lblNum4.Text = numberList[3];
            lblNum5.Text = numberList[4];
            lblNum6.Text = numberList[5];
            lblNum7.Text = numberList[6];

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnSelect.Enabled = true;
            btnStart.Enabled = false;
            timerRefresh.Start();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            btnSelect.Enabled = false;
            btnStart.Enabled = true;
            timerRefresh.Stop();
            StringBuilder str = new StringBuilder();
            foreach ( string item in numberList )
            {
                str.Append(item + " ");
            }
            lbNumberList.Items.Add(str);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lbNumberList.Items.Clear();
        }
    }
}

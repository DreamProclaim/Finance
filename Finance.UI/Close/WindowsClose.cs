using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin;

namespace Finance.UI.Close
{
    public partial class WindowsClose : CCSkinMain
    {
        public WindowsClose()
        {
            InitializeComponent();
        }

        private void WindowsClose_Load(object sender, EventArgs e)
        {
            this.skinLabel1.Text = "确定要退出系统吗？";
            this.skinButton1.Text = "确定";
            this.skinButton2.Text = "取消";
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void skinButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

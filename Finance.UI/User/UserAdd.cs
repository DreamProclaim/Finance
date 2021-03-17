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

namespace Finance.UI.User
{
    public partial class UserAdd : CCSkinMain
    {
        public UserAdd()
        {
            InitializeComponent();
        }

        private void UserAdd_Load(object sender, EventArgs e)
        {
            this.skinLabel1.Text = "手机号：";
            this.skinLabel2.Text = "姓名：";
            this.skinLabel3.Text = "密码：";
            this.skinLabel4.Text = "性别：";
            this.skinLabel5.Text = "图片：";
        }

        private void UserAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}

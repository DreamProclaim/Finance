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
        }

        private void UserAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

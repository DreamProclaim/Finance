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
using Finance.UI.User;

namespace Finance.UI
{
    public partial class Form1 : CCSkinMain
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            UserAdd userAdd = new UserAdd();
            this.Close();
            userAdd.Show();
        }
    }
}

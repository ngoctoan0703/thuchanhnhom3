using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace làm_việc_nhóm_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if(txtusername.Text == "cahoi" && txtpassword.Text == "123")
            {
                lberror.Visible = false;
                dashboard ds = new dashboard();
                this.Hide();
                ds.Show();
            } else
            {
                lberror.Visible = true;
                txtpassword.Clear();
            }
        }
    }
}

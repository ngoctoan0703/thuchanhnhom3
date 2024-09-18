using làm_việc_nhóm_3.all_user_control;
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
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnaddroom_Click(object sender, EventArgs e)
        {
            panelmoving.Left = btnaddroom.Left + 50;
            // hiển thị control
            uc_addroom1.Visible = true;
            // ưu tiên thứ tự sẽ được đẩy lên trước 
            uc_addroom1.BringToFront();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            uc_addroom1.Visible = false;
            btnaddroom.PerformClick();
        }
    }
}

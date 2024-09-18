namespace làm_việc_nhóm_3
{
    partial class dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            this.btnexit = new Guna.UI2.WinForms.Guna2Button();
            this.btnminisize = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnstaff = new Guna.UI2.WinForms.Guna2Button();
            this.btncd = new Guna.UI2.WinForms.Guna2Button();
            this.btncheckout = new Guna.UI2.WinForms.Guna2Button();
            this.btncr = new Guna.UI2.WinForms.Guna2Button();
            this.btnaddroom = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelmoving = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uc_addroom1 = new làm_việc_nhóm_3.all_user_control.uc_addroom();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnexit
            // 
            this.btnexit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnexit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnexit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnexit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnexit.FillColor = System.Drawing.Color.LightPink;
            this.btnexit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnexit.ForeColor = System.Drawing.Color.White;
            this.btnexit.Image = ((System.Drawing.Image)(resources.GetObject("btnexit.Image")));
            this.btnexit.ImageSize = new System.Drawing.Size(30, 30);
            this.btnexit.Location = new System.Drawing.Point(0, 0);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(64, 59);
            this.btnexit.TabIndex = 0;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnminisize
            // 
            this.btnminisize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnminisize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnminisize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnminisize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnminisize.FillColor = System.Drawing.Color.LightPink;
            this.btnminisize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnminisize.ForeColor = System.Drawing.Color.White;
            this.btnminisize.Image = ((System.Drawing.Image)(resources.GetObject("btnminisize.Image")));
            this.btnminisize.ImageSize = new System.Drawing.Size(30, 30);
            this.btnminisize.Location = new System.Drawing.Point(0, 50);
            this.btnminisize.Name = "btnminisize";
            this.btnminisize.Size = new System.Drawing.Size(64, 59);
            this.btnminisize.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnstaff);
            this.panel1.Controls.Add(this.btncd);
            this.panel1.Controls.Add(this.btncheckout);
            this.panel1.Controls.Add(this.btncr);
            this.panel1.Controls.Add(this.btnaddroom);
            this.panel1.Location = new System.Drawing.Point(70, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1765, 130);
            this.panel1.TabIndex = 2;
            // 
            // btnstaff
            // 
            this.btnstaff.BorderRadius = 18;
            this.btnstaff.BorderThickness = 1;
            this.btnstaff.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnstaff.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnstaff.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnstaff.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnstaff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnstaff.FillColor = System.Drawing.Color.LightPink;
            this.btnstaff.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnstaff.ForeColor = System.Drawing.Color.White;
            this.btnstaff.Location = new System.Drawing.Point(1445, 3);
            this.btnstaff.Name = "btnstaff";
            this.btnstaff.Size = new System.Drawing.Size(254, 120);
            this.btnstaff.TabIndex = 4;
            this.btnstaff.Text = "nhân viên";
            // 
            // btncd
            // 
            this.btncd.BorderRadius = 18;
            this.btncd.BorderThickness = 1;
            this.btncd.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btncd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btncd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btncd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btncd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btncd.FillColor = System.Drawing.Color.LightPink;
            this.btncd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btncd.ForeColor = System.Drawing.Color.White;
            this.btncd.Location = new System.Drawing.Point(1123, 3);
            this.btncd.Name = "btncd";
            this.btncd.Size = new System.Drawing.Size(261, 120);
            this.btncd.TabIndex = 3;
            this.btncd.Text = "chi tiết khách hàng";
            // 
            // btncheckout
            // 
            this.btncheckout.BorderRadius = 18;
            this.btncheckout.BorderThickness = 1;
            this.btncheckout.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btncheckout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btncheckout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btncheckout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btncheckout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btncheckout.FillColor = System.Drawing.Color.LightPink;
            this.btncheckout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btncheckout.ForeColor = System.Drawing.Color.White;
            this.btncheckout.Location = new System.Drawing.Point(763, 3);
            this.btncheckout.Name = "btncheckout";
            this.btncheckout.Size = new System.Drawing.Size(297, 120);
            this.btncheckout.TabIndex = 2;
            this.btncheckout.Text = "thanh toán";
            // 
            // btncr
            // 
            this.btncr.BorderRadius = 18;
            this.btncr.BorderThickness = 1;
            this.btncr.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btncr.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btncr.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btncr.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btncr.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btncr.FillColor = System.Drawing.Color.LightPink;
            this.btncr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btncr.ForeColor = System.Drawing.Color.White;
            this.btncr.Location = new System.Drawing.Point(375, 3);
            this.btncr.Name = "btncr";
            this.btncr.Size = new System.Drawing.Size(321, 120);
            this.btncr.TabIndex = 1;
            this.btncr.Text = "đăng ký khách hàng ";
            // 
            // btnaddroom
            // 
            this.btnaddroom.BorderRadius = 18;
            this.btnaddroom.BorderThickness = 1;
            this.btnaddroom.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnaddroom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnaddroom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnaddroom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnaddroom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnaddroom.FillColor = System.Drawing.Color.LightPink;
            this.btnaddroom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnaddroom.ForeColor = System.Drawing.Color.White;
            this.btnaddroom.Location = new System.Drawing.Point(66, 3);
            this.btnaddroom.Name = "btnaddroom";
            this.btnaddroom.Size = new System.Drawing.Size(246, 120);
            this.btnaddroom.TabIndex = 0;
            this.btnaddroom.Text = "thêm phòng";
            this.btnaddroom.Click += new System.EventHandler(this.btnaddroom_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.uc_addroom1);
            this.panel2.Location = new System.Drawing.Point(23, 148);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1882, 852);
            this.panel2.TabIndex = 3;
            // 
            // panelmoving
            // 
            this.panelmoving.BackColor = System.Drawing.Color.LightSlateGray;
            this.panelmoving.Location = new System.Drawing.Point(70, 143);
            this.panelmoving.Name = "panelmoving";
            this.panelmoving.Size = new System.Drawing.Size(300, 7);
            this.panelmoving.TabIndex = 0;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // uc_addroom1
            // 
            this.uc_addroom1.BackColor = System.Drawing.Color.White;
            this.uc_addroom1.Location = new System.Drawing.Point(-2, -4);
            this.uc_addroom1.Name = "uc_addroom1";
            this.uc_addroom1.Size = new System.Drawing.Size(1882, 852);
            this.uc_addroom1.TabIndex = 0;
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(1946, 1106);
            this.Controls.Add(this.panelmoving);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnminisize);
            this.Controls.Add(this.btnexit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnexit;
        private Guna.UI2.WinForms.Guna2Button btnminisize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnaddroom;
        private Guna.UI2.WinForms.Guna2Button btnstaff;
        private Guna.UI2.WinForms.Guna2Button btncd;
        private Guna.UI2.WinForms.Guna2Button btncheckout;
        private Guna.UI2.WinForms.Guna2Button btncr;
        private Guna.UI2.WinForms.Guna2Panel panelmoving;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private all_user_control.uc_addroom uc_addroom1;
    }
}
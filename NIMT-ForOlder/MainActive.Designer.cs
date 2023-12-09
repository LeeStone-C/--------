namespace NIMT_ForOlder
{
    partial class Main_Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form1));
            this.WelcomeUser = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.panelbottom = new System.Windows.Forms.Panel();
            this.label_logOut = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.timer_timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.PBClose = new System.Windows.Forms.PictureBox();
            this.PBHide = new System.Windows.Forms.PictureBox();
            this.pbMax = new System.Windows.Forms.PictureBox();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.PBUser = new System.Windows.Forms.PictureBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.btnHealth = new System.Windows.Forms.Button();
            this.btnRoom = new System.Windows.Forms.Button();
            this.btnCareServerbook = new System.Windows.Forms.Button();
            this.btnUserHome = new System.Windows.Forms.Button();
            this.pnlAdmin = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnAdminMain = new System.Windows.Forms.Button();
            this.pnlDesktop = new System.Windows.Forms.Panel();
            this.panelbottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMax)).BeginInit();
            this.pnlTitleBar.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBUser)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.pnlUser.SuspendLayout();
            this.pnlAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // WelcomeUser
            // 
            resources.ApplyResources(this.WelcomeUser, "WelcomeUser");
            this.WelcomeUser.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.WelcomeUser.Name = "WelcomeUser";
            // 
            // labName
            // 
            resources.ApplyResources(this.labName, "labName");
            this.labName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labName.Name = "labName";
            // 
            // panelbottom
            // 
            this.panelbottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(138)))));
            this.panelbottom.Controls.Add(this.label_logOut);
            this.panelbottom.Controls.Add(this.label_time);
            this.panelbottom.Controls.Add(this.labName);
            this.panelbottom.Controls.Add(this.WelcomeUser);
            resources.ApplyResources(this.panelbottom, "panelbottom");
            this.panelbottom.Name = "panelbottom";
            // 
            // label_logOut
            // 
            resources.ApplyResources(this.label_logOut, "label_logOut");
            this.label_logOut.ForeColor = System.Drawing.Color.White;
            this.label_logOut.Name = "label_logOut";
            this.label_logOut.Click += new System.EventHandler(this.label_logOut_Click);
            this.label_logOut.MouseLeave += new System.EventHandler(this.label_logOut_MouseLeave);
            this.label_logOut.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label_logOut_MouseMove);
            // 
            // label_time
            // 
            resources.ApplyResources(this.label_time, "label_time");
            this.label_time.ForeColor = System.Drawing.Color.White;
            this.label_time.Name = "label_time";
            // 
            // timer_timer
            // 
            this.timer_timer.Tick += new System.EventHandler(this.timer_timer_Tick);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Name = "label1";
            // 
            // PBClose
            // 
            resources.ApplyResources(this.PBClose, "PBClose");
            this.PBClose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBClose.Name = "PBClose";
            this.PBClose.TabStop = false;
            this.PBClose.Click += new System.EventHandler(this.PBClose_Click);
            this.PBClose.MouseLeave += new System.EventHandler(this.PBClose_MouseLeave);
            this.PBClose.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PBClose_MouseMove);
            // 
            // PBHide
            // 
            resources.ApplyResources(this.PBHide, "PBHide");
            this.PBHide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBHide.Name = "PBHide";
            this.PBHide.TabStop = false;
            this.PBHide.Click += new System.EventHandler(this.PBHide_Click);
            // 
            // pbMax
            // 
            resources.ApplyResources(this.pbMax, "pbMax");
            this.pbMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbMax.Name = "pbMax";
            this.pbMax.TabStop = false;
            this.pbMax.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(138)))));
            this.pnlTitleBar.Controls.Add(this.pbMax);
            this.pnlTitleBar.Controls.Add(this.PBHide);
            this.pnlTitleBar.Controls.Add(this.PBClose);
            this.pnlTitleBar.Controls.Add(this.label1);
            resources.ApplyResources(this.pnlTitleBar, "pnlTitleBar");
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseDown);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(138)))));
            resources.ApplyResources(this.pnlLogo, "pnlLogo");
            this.pnlLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLogo.Controls.Add(this.PBUser);
            this.pnlLogo.Name = "pnlLogo";
            // 
            // PBUser
            // 
            resources.ApplyResources(this.PBUser, "PBUser");
            this.PBUser.Name = "PBUser";
            this.PBUser.TabStop = false;
            this.PBUser.Click += new System.EventHandler(this.PBUser_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(138)))));
            this.pnlMain.Controls.Add(this.pnlUser);
            this.pnlMain.Controls.Add(this.pnlAdmin);
            this.pnlMain.Controls.Add(this.pnlLogo);
            resources.ApplyResources(this.pnlMain, "pnlMain");
            this.pnlMain.Name = "pnlMain";
            // 
            // pnlUser
            // 
            this.pnlUser.Controls.Add(this.button5);
            this.pnlUser.Controls.Add(this.btnHealth);
            this.pnlUser.Controls.Add(this.btnRoom);
            this.pnlUser.Controls.Add(this.btnCareServerbook);
            this.pnlUser.Controls.Add(this.btnUserHome);
            resources.ApplyResources(this.pnlUser, "pnlUser");
            this.pnlUser.Name = "pnlUser";
            // 
            // button5
            // 
            resources.ApplyResources(this.button5, "button5");
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.ForeColor = System.Drawing.Color.Gainsboro;
            this.button5.Name = "button5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // btnHealth
            // 
            resources.ApplyResources(this.btnHealth, "btnHealth");
            this.btnHealth.FlatAppearance.BorderSize = 0;
            this.btnHealth.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHealth.Name = "btnHealth";
            this.btnHealth.UseVisualStyleBackColor = false;
            this.btnHealth.Click += new System.EventHandler(this.btnHealth_Click);
            // 
            // btnRoom
            // 
            resources.ApplyResources(this.btnRoom, "btnRoom");
            this.btnRoom.FlatAppearance.BorderSize = 0;
            this.btnRoom.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.UseVisualStyleBackColor = false;
            this.btnRoom.Click += new System.EventHandler(this.btnRoom_Click);
            // 
            // btnCareServerbook
            // 
            resources.ApplyResources(this.btnCareServerbook, "btnCareServerbook");
            this.btnCareServerbook.FlatAppearance.BorderSize = 0;
            this.btnCareServerbook.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCareServerbook.Name = "btnCareServerbook";
            this.btnCareServerbook.UseVisualStyleBackColor = false;
            this.btnCareServerbook.Click += new System.EventHandler(this.btnCareServerbook_Click);
            // 
            // btnUserHome
            // 
            resources.ApplyResources(this.btnUserHome, "btnUserHome");
            this.btnUserHome.FlatAppearance.BorderSize = 0;
            this.btnUserHome.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUserHome.Name = "btnUserHome";
            this.btnUserHome.UseVisualStyleBackColor = false;
            this.btnUserHome.Click += new System.EventHandler(this.btnUserHome_Click);
            // 
            // pnlAdmin
            // 
            this.pnlAdmin.Controls.Add(this.button4);
            this.pnlAdmin.Controls.Add(this.button3);
            this.pnlAdmin.Controls.Add(this.button1);
            this.pnlAdmin.Controls.Add(this.button2);
            this.pnlAdmin.Controls.Add(this.btnAdmin);
            this.pnlAdmin.Controls.Add(this.btnAdminMain);
            resources.ApplyResources(this.pnlAdmin, "pnlAdmin");
            this.pnlAdmin.Name = "pnlAdmin";
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.ForeColor = System.Drawing.Color.Gainsboro;
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.ForeColor = System.Drawing.Color.Gainsboro;
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.ForeColor = System.Drawing.Color.Gainsboro;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnAdmin
            // 
            resources.ApplyResources(this.btnAdmin, "btnAdmin");
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnAdminMain
            // 
            resources.ApplyResources(this.btnAdminMain, "btnAdminMain");
            this.btnAdminMain.FlatAppearance.BorderSize = 0;
            this.btnAdminMain.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAdminMain.Name = "btnAdminMain";
            this.btnAdminMain.UseVisualStyleBackColor = false;
            this.btnAdminMain.Click += new System.EventHandler(this.btnAdminMain_Click);
            // 
            // pnlDesktop
            // 
            resources.ApplyResources(this.pnlDesktop, "pnlDesktop");
            this.pnlDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(138)))));
            this.pnlDesktop.Name = "pnlDesktop";
            // 
            // Main_Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlDesktop);
            this.Controls.Add(this.panelbottom);
            this.Controls.Add(this.pnlTitleBar);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "Main_Form1";
            this.ShowIcon = false;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Main_Form1_Load);
            this.panelbottom.ResumeLayout(false);
            this.panelbottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMax)).EndInit();
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBUser)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlUser.ResumeLayout(false);
            this.pnlAdmin.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label WelcomeUser;
        private System.Windows.Forms.Panel panelbottom;
        private System.Windows.Forms.Label label_logOut;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Timer timer_timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PBClose;
        private System.Windows.Forms.PictureBox PBHide;
        private System.Windows.Forms.PictureBox pbMax;
        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox PBUser;
        public System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlUser;
        public System.Windows.Forms.Button btnHealth;
        public System.Windows.Forms.Button btnRoom;
        public System.Windows.Forms.Button btnCareServerbook;
        public System.Windows.Forms.Button btnUserHome;
        private System.Windows.Forms.Panel pnlAdmin;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button btnAdmin;
        public System.Windows.Forms.Button btnAdminMain;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Panel pnlDesktop;
        public System.Windows.Forms.Button button5;
        public System.Windows.Forms.Label labName;
    }
}


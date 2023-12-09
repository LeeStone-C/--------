namespace NIMT_ForOlder
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.labWelcome = new System.Windows.Forms.Label();
            this.labAccount = new System.Windows.Forms.Label();
            this.labPwd = new System.Windows.Forms.Label();
            this.txtBAccount = new System.Windows.Forms.TextBox();
            this.txtBPwd = new System.Windows.Forms.TextBox();
            this.palAccountD = new System.Windows.Forms.Panel();
            this.pnlPwdD = new System.Windows.Forms.Panel();
            this.pnlTopTitle = new System.Windows.Forms.Panel();
            this.PBClose = new System.Windows.Forms.PictureBox();
            this.PBMin = new System.Windows.Forms.PictureBox();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.labType = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.pnlTopTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBMin)).BeginInit();
            this.SuspendLayout();
            // 
            // labWelcome
            // 
            this.labWelcome.AutoSize = true;
            this.labWelcome.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labWelcome.Location = new System.Drawing.Point(123, 95);
            this.labWelcome.Name = "labWelcome";
            this.labWelcome.Size = new System.Drawing.Size(85, 33);
            this.labWelcome.TabIndex = 1;
            this.labWelcome.Text = "Login";
            this.labWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labAccount
            // 
            this.labAccount.AutoSize = true;
            this.labAccount.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labAccount.Location = new System.Drawing.Point(124, 164);
            this.labAccount.Name = "labAccount";
            this.labAccount.Size = new System.Drawing.Size(58, 27);
            this.labAccount.TabIndex = 2;
            this.labAccount.Text = " 账户";
            // 
            // labPwd
            // 
            this.labPwd.AutoSize = true;
            this.labPwd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labPwd.Location = new System.Drawing.Point(130, 257);
            this.labPwd.Name = "labPwd";
            this.labPwd.Size = new System.Drawing.Size(52, 27);
            this.labPwd.TabIndex = 3;
            this.labPwd.Text = "密码";
            // 
            // txtBAccount
            // 
            this.txtBAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(138)))));
            this.txtBAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBAccount.Font = new System.Drawing.Font("微软雅黑 Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBAccount.Location = new System.Drawing.Point(135, 203);
            this.txtBAccount.MaxLength = 12;
            this.txtBAccount.Name = "txtBAccount";
            this.txtBAccount.Size = new System.Drawing.Size(214, 24);
            this.txtBAccount.TabIndex = 0;
            // 
            // txtBPwd
            // 
            this.txtBPwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(138)))));
            this.txtBPwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBPwd.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBPwd.Location = new System.Drawing.Point(135, 300);
            this.txtBPwd.MaxLength = 20;
            this.txtBPwd.Name = "txtBPwd";
            this.txtBPwd.Size = new System.Drawing.Size(214, 24);
            this.txtBPwd.TabIndex = 5;
            // 
            // palAccountD
            // 
            this.palAccountD.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.palAccountD.Location = new System.Drawing.Point(135, 234);
            this.palAccountD.Name = "palAccountD";
            this.palAccountD.Size = new System.Drawing.Size(214, 1);
            this.palAccountD.TabIndex = 6;
            // 
            // pnlPwdD
            // 
            this.pnlPwdD.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.pnlPwdD.Location = new System.Drawing.Point(135, 326);
            this.pnlPwdD.Name = "pnlPwdD";
            this.pnlPwdD.Size = new System.Drawing.Size(214, 1);
            this.pnlPwdD.TabIndex = 7;
            // 
            // pnlTopTitle
            // 
            this.pnlTopTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(138)))));
            this.pnlTopTitle.Controls.Add(this.PBClose);
            this.pnlTopTitle.Controls.Add(this.PBMin);
            this.pnlTopTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTopTitle.Name = "pnlTopTitle";
            this.pnlTopTitle.Size = new System.Drawing.Size(461, 28);
            this.pnlTopTitle.TabIndex = 8;
            this.pnlTopTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTopTitle_MouseDown);
            // 
            // PBClose
            // 
            this.PBClose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBClose.Image = ((System.Drawing.Image)(resources.GetObject("PBClose.Image")));
            this.PBClose.Location = new System.Drawing.Point(414, 0);
            this.PBClose.Name = "PBClose";
            this.PBClose.Size = new System.Drawing.Size(25, 28);
            this.PBClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBClose.TabIndex = 1;
            this.PBClose.TabStop = false;
            this.PBClose.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // PBMin
            // 
            this.PBMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBMin.Image = ((System.Drawing.Image)(resources.GetObject("PBMin.Image")));
            this.PBMin.Location = new System.Drawing.Point(374, 0);
            this.PBMin.Name = "PBMin";
            this.PBMin.Size = new System.Drawing.Size(25, 28);
            this.PBMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBMin.TabIndex = 0;
            this.PBMin.TabStop = false;
            this.PBMin.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cboType
            // 
            this.cboType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(138)))));
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "用户(User)",
            "管理员(Admin)",
            "社区人员(Other)"});
            this.cboType.Location = new System.Drawing.Point(135, 370);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(214, 23);
            this.cboType.TabIndex = 0;
            // 
            // labType
            // 
            this.labType.AutoSize = true;
            this.labType.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labType.Location = new System.Drawing.Point(130, 340);
            this.labType.Name = "labType";
            this.labType.Size = new System.Drawing.Size(92, 27);
            this.labType.TabIndex = 9;
            this.labType.Text = "登录选项";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(138)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogin.Location = new System.Drawing.Point(129, 419);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(87, 32);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(138)))));
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRegister.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegister.Location = new System.Drawing.Point(262, 419);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(87, 32);
            this.btnRegister.TabIndex = 11;
            this.btnRegister.Text = "注册";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnResign_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(461, 534);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.labType);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.pnlTopTitle);
            this.Controls.Add(this.pnlPwdD);
            this.Controls.Add(this.palAccountD);
            this.Controls.Add(this.txtBPwd);
            this.Controls.Add(this.txtBAccount);
            this.Controls.Add(this.labPwd);
            this.Controls.Add(this.labAccount);
            this.Controls.Add(this.labWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.pnlTopTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labWelcome;
        private System.Windows.Forms.Label labAccount;
        private System.Windows.Forms.Label labPwd;
        private System.Windows.Forms.Panel palAccountD;
        private System.Windows.Forms.Panel pnlPwdD;
        private System.Windows.Forms.Panel pnlTopTitle;
        private System.Windows.Forms.Label labType;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.PictureBox PBClose;
        private System.Windows.Forms.PictureBox PBMin;
        private System.Windows.Forms.TextBox txtBAccount;
        private System.Windows.Forms.TextBox txtBPwd;
        public System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Button btnLogin;
    }
}
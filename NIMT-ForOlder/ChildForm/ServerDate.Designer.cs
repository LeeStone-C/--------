namespace NIMT_ForOlder.ChildForm
{
    partial class ServerDate
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerDate));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.预约套餐 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.预约时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.预约项目 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.预约次数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMoney = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblPackagesName = new System.Windows.Forms.Label();
            this.lblPackages = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.cboProject = new System.Windows.Forms.ComboBox();
            this.txtProject = new System.Windows.Forms.Label();
            this.cboList = new System.Windows.Forms.ComboBox();
            this.lblList = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.daysPicker1 = new ApeFree.ApeForms.Core.Controls.DaysPicker();
            this.label3 = new System.Windows.Forms.Label();
            this.tallerLabel1 = new ApeFree.ApeForms.Core.Controls.TallerLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.预约套餐,
            this.预约时间,
            this.预约项目,
            this.预约次数});
            this.dataGridView1.DataSource = this.dataSetBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 273);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(782, 130);
            this.dataGridView1.TabIndex = 0;
            // 
            // 预约套餐
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.预约套餐.DefaultCellStyle = dataGridViewCellStyle1;
            this.预约套餐.HeaderText = "预约套餐";
            this.预约套餐.MinimumWidth = 6;
            this.预约套餐.Name = "预约套餐";
            this.预约套餐.Width = 125;
            // 
            // 预约时间
            // 
            this.预约时间.HeaderText = "预约时间";
            this.预约时间.MinimumWidth = 6;
            this.预约时间.Name = "预约时间";
            this.预约时间.Width = 125;
            // 
            // 预约项目
            // 
            this.预约项目.HeaderText = "预约项目";
            this.预约项目.MinimumWidth = 6;
            this.预约项目.Name = "预约项目";
            this.预约项目.Width = 125;
            // 
            // 预约次数
            // 
            this.预约次数.HeaderText = "预约次数";
            this.预约次数.MinimumWidth = 6;
            this.预约次数.Name = "预约次数";
            this.预约次数.Width = 125;
            // 
            // dataSetBindingSource
            // 
            this.dataSetBindingSource.DataSource = typeof(System.Data.DataSet);
            this.dataSetBindingSource.Position = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.lblMoney);
            this.groupBox1.Controls.Add(this.lblPrice);
            this.groupBox1.Controls.Add(this.lblPackagesName);
            this.groupBox1.Controls.Add(this.lblPackages);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnPlus);
            this.groupBox1.Controls.Add(this.cboProject);
            this.groupBox1.Controls.Add(this.txtProject);
            this.groupBox1.Controls.Add(this.cboList);
            this.groupBox1.Controls.Add(this.lblList);
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 141);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "看护套餐";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Location = new System.Drawing.Point(522, 153);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(0, 27);
            this.lblMoney.TabIndex = 11;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(445, 153);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(57, 27);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "价格:";
            // 
            // lblPackagesName
            // 
            this.lblPackagesName.AutoSize = true;
            this.lblPackagesName.Location = new System.Drawing.Point(165, 153);
            this.lblPackagesName.Name = "lblPackagesName";
            this.lblPackagesName.Size = new System.Drawing.Size(0, 27);
            this.lblPackagesName.TabIndex = 9;
            // 
            // lblPackages
            // 
            this.lblPackages.AutoSize = true;
            this.lblPackages.Location = new System.Drawing.Point(75, 153);
            this.lblPackages.Name = "lblPackages";
            this.lblPackages.Size = new System.Drawing.Size(77, 27);
            this.lblPackages.TabIndex = 8;
            this.lblPackages.Text = "套餐名:";
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDelete.Location = new System.Drawing.Point(551, 103);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(76, 25);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnPlus
            // 
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlus.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPlus.Location = new System.Drawing.Point(448, 103);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(76, 25);
            this.btnPlus.TabIndex = 3;
            this.btnPlus.Text = "添加";
            this.btnPlus.UseVisualStyleBackColor = true;
            // 
            // cboProject
            // 
            this.cboProject.FormattingEnabled = true;
            this.cboProject.Location = new System.Drawing.Point(525, 57);
            this.cboProject.Name = "cboProject";
            this.cboProject.Size = new System.Drawing.Size(156, 35);
            this.cboProject.TabIndex = 6;
            // 
            // txtProject
            // 
            this.txtProject.AutoSize = true;
            this.txtProject.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtProject.Location = new System.Drawing.Point(445, 62);
            this.txtProject.Name = "txtProject";
            this.txtProject.Size = new System.Drawing.Size(69, 19);
            this.txtProject.TabIndex = 5;
            this.txtProject.Text = "检查项目";
            // 
            // cboList
            // 
            this.cboList.FormattingEnabled = true;
            this.cboList.Items.AddRange(new object[] {
            "请选择",
            "一级护理",
            "二级护理",
            "三级护理"});
            this.cboList.Location = new System.Drawing.Point(168, 54);
            this.cboList.Name = "cboList";
            this.cboList.Size = new System.Drawing.Size(217, 35);
            this.cboList.TabIndex = 4;
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblList.Location = new System.Drawing.Point(75, 57);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(69, 19);
            this.lblList.TabIndex = 3;
            this.lblList.Text = "套餐列表";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(-3, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "预约结果";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(0, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "预约时间:";
            // 
            // daysPicker1
            // 
            this.daysPicker1.Location = new System.Drawing.Point(78, 156);
            this.daysPicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.daysPicker1.Month = 11;
            this.daysPicker1.Name = "daysPicker1";
            this.daysPicker1.Size = new System.Drawing.Size(288, 187);
            this.daysPicker1.TabIndex = 15;
            this.daysPicker1.Year = 2022;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(451, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "预约时间为:";
            // 
            // tallerLabel1
            // 
            this.tallerLabel1.AutoSize = true;
            this.tallerLabel1.Location = new System.Drawing.Point(548, 233);
            this.tallerLabel1.Name = "tallerLabel1";
            this.tallerLabel1.Size = new System.Drawing.Size(78, 27);
            this.tallerLabel1.TabIndex = 17;
            this.tallerLabel1.Text = "defualt";
            // 
            // ServerDate
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(782, 403);
            this.ControlBox = false;
            this.Controls.Add(this.tallerLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.daysPicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ServerDate";
            this.Text = "ServerDate";
            this.Load += new System.EventHandler(this.ServerDate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dataSetBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblPackagesName;
        private System.Windows.Forms.Label lblPackages;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.ComboBox cboProject;
        private System.Windows.Forms.Label txtProject;
        private System.Windows.Forms.ComboBox cboList;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ApeFree.ApeForms.Core.Controls.DaysPicker daysPicker1;
        private System.Windows.Forms.Label label3;
        private ApeFree.ApeForms.Core.Controls.TallerLabel tallerLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 预约套餐;
        private System.Windows.Forms.DataGridViewTextBoxColumn 预约时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 预约项目;
        private System.Windows.Forms.DataGridViewTextBoxColumn 预约次数;
    }
}
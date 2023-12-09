using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NIMT_ForOlder
{
    public partial class register : Form
    {
        DataBase dataBase = new DataBase();
        public register()
        {
            InitializeComponent();
            this.txtRGPwd.UseSystemPasswordChar = true;
            cboRBType.SelectedIndex = 0;
        }
        private void register_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnRegistering;
        }

        public bool CheckInput()
        {
            if (this.txtRGAccount.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("用户名不能为空！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtRGAccount.Focus();
                return false;
            }
            else if (this.txtRGPwd.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("用户密码不能为空！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtRGPwd.Focus();
                return false;
            }
            else if (this.tbRGName.Text.Trim().Equals(string.Empty)) 
            {
                MessageBox.Show("用户名称不能为空！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.tbRGName.Focus();
                return false;
            }
            else
            {
            return true;
            }
        }
        
        private void PBMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PBregisterCls_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void ChkBoxPwd_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkBoxPwd.Checked)
                this.txtRGPwd.UseSystemPasswordChar = false;
            else
                this.txtRGPwd.UseSystemPasswordChar = true;
        }

        private void btnRegistering_Click(object sender, EventArgs e)
        {
            string name = this.txtRGAccount.Text.Trim();
            string pwd = this.txtRGPwd.Text.Trim();
            string cboRBType = this.cboRBType.Text.Trim();
            string id = this.tbRGName.Text.Trim();
            string sql;
            int count;
            if (CheckInput()) 
            {
                if (cboRBType.Equals("用户(User)"))
                {
                    sql = String.Format("select COUNT(*) from UserInfos where Account = '{0}'", name);
                    count = dataBase.Aggregate(sql);
                    if (count > 0) 
                    {
                        MessageBox.Show("用户名已存在！");
                        txtRGAccount.Clear();
                        txtRGAccount.Focus();
                    }
                    else { 
                    sql = string.Format("insert into UserInfos(Number,Name,Account,Password) values ('未填写','{0}','{1}','{2}')",id,name, pwd);
                    int result = dataBase.IDU(sql);
                    if (result > 0)
                    {
                        MessageBox.Show("用户注册成功!");
                            this.txtRGAccount.Clear();
                            this.txtRGPwd.Clear();
                     }
                    }
                }
                else if (cboRBType.Equals("管理员(Admin)"))
                {
                    sql = String.Format("select COUNT(*) from AdminInfos where Account = '{0}'", name);
                    count = dataBase.Aggregate(sql);
                    if (count > 0)
                    {
                        MessageBox.Show("管理员账户已存在!");
                        txtRGAccount.Clear();
                        txtRGAccount.Focus();
                    }
                    else 
                    {
                        sql = string.Format("insert into AdminInfos(Number,Name,Account,Password) values ('未填写','{0}','{1}','{2}')", id, name, pwd);
                        int result = dataBase.IDU(sql);
                        if (result > 0)
                        {
                            MessageBox.Show("用户注册成功!");
                            this.txtRGAccount.Clear();
                            this.txtRGPwd.Clear();
                        }
                    }
                }
                else if (cboRBType.Equals("社区人员(Other)"))
                {
                    sql = String.Format("select COUNT(*) from StaffInfos where Account = '{0}'", name);
                    count = dataBase.Aggregate(sql);
                    if (count > 0)
                    {
                        MessageBox.Show("社区人员账户已存在!");
                        txtRGAccount.Clear();
                        txtRGAccount.Focus();
                    }
                    else 
                    {
                        sql = string.Format("insert into StaffInfos(Number,Name,Account,Password) values ('未填写','{0}','{1}','{2}')", id,name, pwd);
                        int result = dataBase.IDU(sql);
                        if (result > 0)
                        {

                            MessageBox.Show("用户注册成功!");
                            this.txtRGAccount.Clear();
                            this.txtRGPwd.Clear();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("注册失败！");
                }
            }

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnlRegisterTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}

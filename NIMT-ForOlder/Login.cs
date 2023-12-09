using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NIMT_ForOlder
{
    public partial class Login : Form
    {
        //实例化主页面
        Main_Form1 mf1 = new Main_Form1();
        userInfo info = new userInfo();
        static string connStr = "Data Source=.;Initial Catalog=YangLaoFuWu;User ID=sa;Pwd=123456";
        public Login()
        {
            InitializeComponent();
            this.txtBPwd.UseSystemPasswordChar = true;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.cboType.SelectedIndex = 0;
            this.AcceptButton = btnLogin;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.DialogResult = DialogResult.No;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //CheckInput检测输入
        public bool CheckInput()
        {
            if (this.txtBAccount.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("用户名不能为空！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtBAccount.Focus();
                return false;
            }
            else if (this.txtBPwd.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("用户密码不能为空！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtBPwd.Focus();
                return false;
            }
            else if (this.cboType.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("登录类型不能为空！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cboType.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
                string name = this.txtBAccount.Text.Trim();
                string pwd = this.txtBPwd.Text.Trim();
                string loginType = this.cboType.Text.Trim();
            if (CheckInput()) 
            {
                //获取账户名、密码、及登录类型
                //用户类型登录
                if (loginType.Equals("用户(User)"))
                {
                    SqlConnection conn = new SqlConnection(connStr);
                    conn.Open();
                    SqlCommand command = conn.CreateCommand();
                    command.CommandText = string.Format("select * from UserInfos where Account = '{0}'", name);
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    string sql = string.Format("select COUNT(1) from UserInfos where Account = '{0}' and Password = '{1}'", name, pwd);
                    int result = new DataBase().Aggregate(sql);
                    if (result > 0)
                    {
                        info.Id = Convert.ToString(reader["Name"]);
                        reader.Close();
                        conn.Close();
                        this.DialogResult = DialogResult.OK;
                        this.Hide();
                        mf1.LoginResult(1);
                        mf1.labName.Text = info.Id.Trim();
                        mf1.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("用户名或密码错误！");
                        txtBAccount.Focus();
                        txtBPwd.Clear();
                    }
                }
                else if (loginType.Equals("管理员(Admin)"))
                {
                    string sql = string.Format("select COUNT(1) from AdminInfos where Account = '{0}' and Password = '{1}'", name, pwd);
                    int result = new DataBase().Aggregate(sql);
                    if (result > 0)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Hide();
                        mf1.LoginResult(2);
                        mf1.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("用户名或密码错误！");
                        txtBAccount.Focus();
                        txtBPwd.Clear();
                    }
                }
                else if (loginType.Equals("社区人员(Other)"))
                {
                    string sql = string.Format("select COUNT(1) from StaffInfos where Account = '{0}' and Password = '{1}'", name, pwd);
                    int result = new DataBase().Aggregate(sql);
                    if (result > 0)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Hide();
                        mf1.LoginResult(3);
                        mf1.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("用户名或密码错误！");
                        txtBAccount.Focus();
                        txtBPwd.Clear();
                    }
                }
                else 
                {
                    MessageBox.Show("登录类型有误！");
                }
            }    
        }

        private void btnResign_Click(object sender, EventArgs e)
        {
            register reg = new register();
            this.Hide();
            reg.Show();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnlTopTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        /// <summary>
        /// 信息显示
        /// </summary>
    
        public void Getinfo() 
        {

        }  
    }
}

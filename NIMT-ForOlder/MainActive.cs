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
    public partial class Main_Form1 : Form
    {
        //主题随机颜色
        private Button currentButton;
        private Random random;
        private int tempIndex;
        //子窗口
        private Form currentChildForm;
        public Main_Form1()
        {
            userInfo info = new userInfo();
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            timer_timer.Start();
            random = new Random();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        //方法
        private void Main_Form1_Load(object sender, EventArgs e)
        {
            pnlUser.Visible = false;
            pnlAdmin.Visible = false;
            if (n == 1)
            {
                this.pnlUser.Visible = true;
            }
            else if (n == 2)
            {
                this.pnlAdmin.Visible = true;
            }
            openChildForm(new ChildForm.MagnetDemoPanel());
        }
        public void openChildForm(Form childForm) 
        {
            if (currentChildForm!=null) 
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlDesktop.Controls.Add(childForm);
            pnlDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index) {
              index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
                return ColorTranslator.FromHtml(color);
            }
        private void ActivateButton(object btnSender) 
        {
            if (btnSender!= null) 
            {
                if (currentButton != (Button)btnSender) 
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F,System.Drawing.FontStyle.Regular,System.Drawing.GraphicsUnit.Point,((byte)(0)));
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in pnlMain.Controls) 
            {
                if (previousBtn.GetType()==typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(0, 134, 138);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildForm(new ChildForm.frmdefault());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void PBHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void PBClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void timer_timer_Tick(object sender, EventArgs e)
        {
            DateTime nowTime = System.DateTime.Now.ToLocalTime();
            label_time.Text = nowTime.ToString();
        }
        /// <summary>
        /// 按钮交互动画
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label_logOut_MouseMove(object sender, MouseEventArgs e)
        {
            this.label_logOut.BackColor = Color.Red;
        }
        private void label_logOut_MouseLeave(object sender, EventArgs e)
        {
            label_logOut.BackColor = Color.FromArgb(0, 134, 138);
        }
        private void PBClose_MouseMove(object sender, MouseEventArgs e)
        {
            this.PBClose.BackColor= Color.Red;
        }
        private void PBClose_MouseLeave(object sender, EventArgs e)
        {
            this.PBClose.BackColor = Color.FromArgb(0, 134, 138);
        }
        /// <summary>
        /// 退出登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label_logOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();//不能用ShowDialog()
            //Application.Exit();//全部关闭？
            this.Close();
            this.Dispose();
        }

        private void plUser_Paint(object sender, PaintEventArgs e)
        {

        }
        /// <summary>
        /// 拖拽窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd,int wMsg,int wParam,int lParam);
      
        private void pnlTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        int n;
        public void LoginResult(int x) 
        {
            n = x;
        }
        private void PBUser_Click(object sender, EventArgs e)
        {
            openChildForm(new ChildForm.MagnetDemoPanel());
        }


        public void btnUserHome_Click(object sender, EventArgs e)
        {
            openChildForm(new ChildForm.frmUserMain(this.labName.Text.Trim()));
        }
        private void labName_Click(object sender, EventArgs e)
        {
  
        }

        private void btnCareServerbook_Click(object sender, EventArgs e)
        {
            openChildForm(new ChildForm.ServerDate());
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            openChildForm(new ChildForm.Room());
        }

        private void btnHealth_Click(object sender, EventArgs e)
        {
            openChildForm(new ChildForm.HealthData());
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            openChildForm(new ChildForm.OlderInfoManage());
        }

        private void btnAdminMain_Click(object sender, EventArgs e)
        {
            openChildForm(new ChildForm.Admin());
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            openChildForm(new ChildForm.UserPharmacy());
        }
    }
    }

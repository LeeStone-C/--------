using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NIMT_ForOlder.ChildForm
{
    public partial class frmUserMain : Form
    {
        
        private float X;//定义当前窗体的宽度
        private float Y;//定义当前窗体的高度
        public frmUserMain(string str)
        {
            InitializeComponent();
            this.lbName.Text = str.Trim();
        }
        /// <summary>
        /// 上传头像方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbUpload_Click(object sender, EventArgs e)
        {
            //创建一个对话框对象
            OpenFileDialog ofd = new OpenFileDialog();
            //为对话框设置标题
            ofd.Title = "请选择上传的图片";
            //设置筛选的图片格式
            ofd.Filter = "图片格式|*.jpg";
            //设置是否允许多选
            ofd.Multiselect = false;
            //如果你点了“确定”按钮
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //获得文件的完整路径（包括名字后后缀）
                string filePath = ofd.FileName;
                //将文件路径显示在文本框中
                //txtImgUrl.Text = filePath;
                //找到文件名比如“1.jpg”前面的那个“\”的位置
                int position = filePath.LastIndexOf("\\");
                //从完整路径中截取出来文件名“1.jpg”
                string fileName = filePath.Substring(position + 1);
                //读取选择的文件，返回一个流
                using (Stream stream = ofd.OpenFile())
                {
                    //创建一个流，用来写入得到的文件流（注意：创建一个名为“Images”的文件夹，如果是用相对路径，必须在这个程序的Degug目录下创建
                    //如果是绝对路径，放在那里都行，我用的是相对路径）
                    using (FileStream fs = new FileStream(@"./Images/" + fileName, FileMode.CreateNew))
                    {
                        try
                        {
                            //将得到的文件流复制到写入流中
                            stream.CopyTo(fs);
                            //将写入流中的数据写入到文件中
                            fs.Flush();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("图像已存在");
                            throw;
                        }
                    }
                    //PictrueBOx 显示该图片，此时这个图片已经被复制了一份在Images文件夹下，就相当于上传
                    pictureBox1.ImageLocation = @"./Images/" + fileName;
                }
            }
        }

        int g_formWidth, g_formHeight;
        private void frmUserMain_Load(object sender, EventArgs e)
        {
            g_formHeight = this.Height;
            g_formWidth = this.Width;
            WriteIn_Tags(this);
            txtbCityName.Text = "南京";
            pnlInfoChange.Visible = false;
            this.roundButton5_Click(null, null);
            Getinfo();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void roundButton5_Click(object sender, EventArgs e)
        {
            txtbWeather.Clear();
            try
            {
                cn.com.webxml.www.WeatherWebService w = new cn.com.webxml.www.WeatherWebService();
                string[] r = w.getWeatherbyCityName(txtbCityName.Text.Trim());
                if (r[8] == "")
                {
                    MessageBox.Show("暂时不支持您查询的城市");
                }
                else
                {
                    pictureBox2.Image = Image.FromFile(@"./Images/" + r[8] + "");
                    this.uiLabel1.Text = r[1] + "市";
                    this.txtbWeather.Text = r[10];
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

         void WriteIn_Tags(Control cons)
        {
            foreach (Control con in cons.Controls) 
            {
                string str = con.Width.ToString() + "?"
                + con.Height.ToString() + "?"
                + con.Left.ToString() + "?"
                + con.Top.ToString() + "?"
                + con.Font.Size.ToString();
                con.Tag = str;
                if (con.Controls.Count>0) 
                {
                    WriteIn_Tags(con);//递归遍历所有控件
                }
            }
        }

        private void frmUserMain_ResizeEnd(object sender, EventArgs e)
        {
            Form fm = (Form)sender;
            double scaleX = fm.Width * 1.0 / g_formWidth;
            double scaleY = fm.Height * 1.0 / g_formHeight;
            Resize_AllControls(fm, scaleX, scaleY);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            pnlInfoChange.Visible = true;
        }

        private void roundButton2_Click(object sender, EventArgs e)
        {
            pnlInfoChange.Visible = true;
            pnlInfo.Visible = false;
            panel1.Visible = false;
            panel4.Visible = false;
            
        }

        private void roundButton3_Click(object sender, EventArgs e)
        {
            pnlInfoChange.Visible = false;
            pnlInfo.Visible = true;
            panel1.Visible = true;
            panel4.Visible = true;
        }

        void Resize_AllControls(Control cons, double scaleX, double scaleY) 
        {
            foreach (Control con in cons.Controls) 
            {
                var tags = con.Tag.ToString().Split(new char[] { '?' });
                int width0ld = Convert.ToInt32(tags[0]);
                int height0ld = Convert.ToInt32(tags[1]);
                int left0ld = Convert.ToInt32(tags[2]);
                int top0ld = Convert.ToInt32(tags[3]);
                int fontSize0ld = Convert.ToInt32(tags[4]);

                con.Width = Convert.ToInt32(width0ld);
                con.Height = Convert.ToInt32(height0ld);
                con.Left = Convert.ToInt32(left0ld);
                con.Top = Convert.ToInt32(top0ld);
                int fontSizeNew = Convert.ToInt32(fontSize0ld * scaleX);
                con.Font = new Font(con.Font.Name,fontSizeNew,Font.Style);

                if (con.Controls.Count > 0) 
                {
                    Resize_AllControls(con,scaleX,scaleY); 
                }
            }
        }
        Main_Form1 mf1 = new Main_Form1();
        userInfo info = new userInfo();
        static string connStr = "Data Source=.;Initial Catalog=YangLaoFuWu;User ID=sa;Pwd=123456";


        public void Getinfo()
        {
            string name = lbName.Text.Trim();
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = string.Format("select * from UserInfos where Name = '{0}'", name);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            this.labGender.Text = Convert.ToString(reader["Gender"]);
            this.labBirthDay.Text = Convert.ToString(reader["Birthday"]);
            this.labAge.Text = Convert.ToString(reader["Age"]);
            this.labelphone.Text = Convert.ToString(reader["PhoneNumber1"]);
            this.labelEmergency.Text = Convert.ToString(reader["EmergencyContact"]);
            this.labelCaregiver.Text = Convert.ToString(reader["Caregiver"]);
            this.labelNumber.Text = Convert.ToString(reader["Number"]);
            this.labEGNumber.Text = Convert.ToString(reader["PhoneNumber3"]);
            this.richTextBox2.Text = Convert.ToString(reader["DiseaseHistory"]);
            reader.Close();
            conn.Close();
        }
    }
}

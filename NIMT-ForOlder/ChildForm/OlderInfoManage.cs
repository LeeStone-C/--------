using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NIMT_ForOlder.ChildForm
{
    public partial class OlderInfoManage : Form
    {
        DataBase db = new DataBase();
        public OlderInfoManage()
        {
            InitializeComponent();
        }
        private void OlderInfoManage_Load(object sender, EventArgs e)
        {
            GetList();
        }

        private void uiGroupBox1_Click(object sender, EventArgs e)
        {
            GetList();
        }
        public void GetList()
        {
            string idNumber = this.uiTextBox2.Text.Trim();
            string sql = string.Format("select * from UserInfos");
            DataSet ds = db.GetQuery(sql);
            this.uiDataGridView1.DataSource = ds.Tables["Info"];
        }
    }
}

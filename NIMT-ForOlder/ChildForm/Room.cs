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
    public partial class Room : Form
    {
        public Room()
        {
            InitializeComponent();
            simpleButtonShutter1.AddChildButton("舒逸苑(1号)");
            simpleButtonShutter1.AddChildButton("金夕苑(2号)");
            simpleButtonShutter1.AddChildButton("怡安苑(3号)");
            simpleButtonShutter2.AddChildButton("1层");
            simpleButtonShutter2.AddChildButton("2层");
            simpleButtonShutter2.AddChildButton("3层");
            simpleButtonShutter2.AddChildButton("4层");
            simpleButtonShutter2.AddChildButton("5层");
            simpleButtonShutter2.AddChildButton("6层");
            simpleButtonShutter2.AddChildButton("7层");
        }

        private void simpleButtonShutter1_Load(object sender, EventArgs e)
        {

        }

        private void simpleButtonShutter1_Click(object sender, EventArgs e)
        {
            this.TopLevel = true;
        }

        private void simpleButtonShutter2_Click(object sender, EventArgs e)
        {
            this.TopLevel = true;
        }
    }
}

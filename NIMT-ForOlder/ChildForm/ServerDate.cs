﻿using System;
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
    public partial class ServerDate : Form
    {
        public ServerDate()
        {
            InitializeComponent();
        }

        private void ServerDate_Load(object sender, EventArgs e)
        {
            this.cboList.SelectedIndex = 0;
        }
    }
}

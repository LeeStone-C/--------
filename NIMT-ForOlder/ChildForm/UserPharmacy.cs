using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NIMT_ForOlder.ChildForm
{
    public partial class UserPharmacy : Form
    {
        DataBase db = new DataBase();
        public UserPharmacy()
        {
            InitializeComponent();
        }

        private void UserPharmacy_Load(object sender, EventArgs e)
        {
            string sql = "select Drugs from Pharmacy; ";
            SqlDataReader reader = db.GetList(sql);
            reader.Read();
        }

        private void simpleButtonShutter1_Load(object sender, EventArgs e)
        {

        }
    }
}

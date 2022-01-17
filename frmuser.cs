using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MagicDB;

namespace company
{
    public partial class frmuser : Form
    {
        public frmuser()
        {
            InitializeComponent();
        }

        private void user_Load(object sender, EventArgs e)
        {
            DB.DBMS = DBMSTypes.Access2003;
          DB.DatabaseName = "company";

            Control[] myCtrls = { txtid, txtname, txtaddress, txtsalary,cbx_active };
            DB.ActiveSearchAndSelectRow(ref pnlsearch,ref myCtrls,"employee");
            txtid.Text = DB.AutoNum("employee","employee_id");

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string[] strvals = { txtid.Text, txtname.Text, txtaddress.Text, txtsalary.Text,cbx_active.Checked.ToString()};
            DB.RunInsert("employee", strvals,ref dgvemp,ref pnldata , "employee", "employee_id", ref txtid,ref txtname);
        }

        private void pnlsearch_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string[] strcols = { "employee_name","address","salary","is_active"};
            string[] strvals = { txtname.Text, txtaddress.Text, txtsalary.Text, cbx_active.Checked.ToString()};
            DB.RunUpdate("employee", strcols, strvals, "employee_id", txtid.Text, ref dgvemp, ref pnldata, "employee", "employee_id", ref txtid, ref txtname);
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            DB.RunDelete("employee", "employee_id", txtid.Text, ref dgvemp, ref pnldata, "employee", "employee_id", ref txtid, ref txtname);
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NitradoUnlimited
{
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
        }

        private void settings_Load(object sender, EventArgs e)
        {
            lblusername.Text = main.Variables.username;
            lbluserid.Text = main.Variables.userid;
            lblemail.Text = main.Variables.email;
            txtaccesstoken.Text = Properties.Settings.Default.accesstoken;
            checkshowcredit.Checked = Properties.Settings.Default.showcredit;
            checkshowrealname.Checked = Properties.Settings.Default.showrealname;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.showcredit = checkshowcredit.Checked;
            Properties.Settings.Default.showrealname = checkshowrealname.Checked;
            Properties.Settings.Default.Save();
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KLDS
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }
        public void loadform(object form)
        {
            if (this.mainpanel.Controls.Count > 0)
            {
                this.mainpanel.Controls.RemoveAt(0);
            }
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void User_Button_Click(object sender, EventArgs e)
        {
            loadform(new UserDetail());
        }

        private void Dashboard_Button_Click(object sender, EventArgs e)
        {
            loadform(new Dashboard());
        }

        private void Scan_Button_Click(object sender, EventArgs e)
        {
            loadform(new ScanForm());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadform(new Detection_Form());
        }

        private void Logout_Button_Click(object sender, EventArgs e)
        {
            loadform(new DetectionResultActionForm());
        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

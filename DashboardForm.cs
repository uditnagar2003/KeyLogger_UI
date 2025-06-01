using Client_Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace KLDS
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
            User_Button.Text = $"Hi {User_Session.Name}";
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
            loadform(new Dashboard(this));
        }

        private void Scan_Button_Click(object sender, EventArgs e)
        {
            loadform(new ScanForm(this));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadform(new Detection_Form());
        }

        private void Logout_Button_Click(object sender, EventArgs e)
        {
            User_Session.UserId = 0; // Reset user session
            User_Session.Name = string.Empty; // Reset user name
            User_Session.Email = string.Empty; // Reset user email
                                               User_Session.AccessToken = string.Empty; // Reset user token
            User_Session.RefreshToken = string.Empty; // Reset user role
            new Authentication_State().writeUser_session();
            this.Hide();
            Login_Form loginForm = new Login_Form();
            loginForm.Show();
        }

       
        private void Exit_Button_MouseHover(object sender, EventArgs e)
        {
            this.Exit_Button.BackColor = Color.Red;
        }


        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

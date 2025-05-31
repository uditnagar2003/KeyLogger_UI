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

namespace KLDS
{
    public partial class UserDetail : Form
    {
        public UserDetail()
        {
            InitializeComponent();
            INitializeTextbox();
        }

        private void INitializeTextbox()
        {
            User_id.Text = User_Session.UserId.ToString();// User_Session.UserId.ToString();
            User_Name.Text = User_Session.Name;
            EMail.Text = User_Session.Email;
        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void UserDetail_Load(object sender, EventArgs e)
        {

        }

        private void Edit_Button_Click(object sender, EventArgs e)
        {

        }

        private void Save_Button_Click(object sender, EventArgs e)
        {

        }

        private void Back_Button_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

using Client_Library;
using keylogger_lib.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KLDS
{
    public partial class Login_Form : Form
    {
        private readonly AuthService _authService = new AuthService();

        public Login_Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private async void Login_Button_Click(object sender, EventArgs e)
        {
            Login_Button.Enabled = false; // Disable the button to prevent multiple clicks
            NewUser_Button.Enabled = false; // Disable the button to prevent multiple clicks
            Login_Status.Text = "Logging in...";
            bool loggedIn = await _authService.LoginAsync(User.Text, Password.Text);
            Login_Status.Text = loggedIn ? "Login successful!" : "Login failed. Check credentials.";
            if (loggedIn)
            {


                DashboardForm f = new DashboardForm();
                f.loadform(new Dashboard(f));
                this.Hide();
                f.Show();

                // enable protected actions
            }
            else
            {
                MessageBox.Show("Login failed. Check credentials.");
                Login_Button.Enabled = true; // Disable the button to prevent multiple clicks
                NewUser_Button.Enabled = true; // Disable the button to prevent multiple clicks


            }
        }
        private void Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Prevent the beep sound on Enter key press
                Login_Button.PerformClick(); // Trigger the login button click event
            }
        }


        private void NewUser_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            new KLDS_UI.Register().Show();

        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

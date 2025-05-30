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

        private void label1_Click(object sender, EventArgs e)
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
                var _jwtToken = User_Session.AccessToken;
                var handler = new JwtSecurityTokenHandler();
                var token = handler.ReadJwtToken(_jwtToken);


                User_Session.UserId = Int32.Parse(token.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value);
                User_Session.Email = token.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value;
                User_Session.Name = token.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Name)?.Value;

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

        private void ForgotPassword_Click(object sender, EventArgs e)
        {

        }

        private void NewUser_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            new KLDS_UI.Register().Show();

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

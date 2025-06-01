using Client_Library;
using KLDS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KLDS_UI
{

    public partial class Register : Form
    {
        AuthService authService = new AuthService();
        public Register()
        {
            InitializeComponent();
        }

        private async void Save_Button_Click(object sender, EventArgs e)
        {
            if (!(Password.Text == Confirm_Password.Text))
            {
                MessageBox.Show("Passoword don't Match?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show("Are you sure you want to Create account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    Debug.WriteLine("UserName: " + UserName.Text);

                    bool registered = await authService.RegisterAsync(UserName.Text, Email.Text, Password.Text, Confirm_Password.Text);
                    if (registered)
                    {
                        if (DialogResult.OK == MessageBox.Show("Account created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information))
                            this.Close();
                        Login_Form loginForm = new Login_Form();
                        loginForm.Show();

                    }
                    else
                    {
                        MessageBox.Show("Account creation failed. Please check your details and try again.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Account creation Failed.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
       
    }
}

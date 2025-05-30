namespace KLDS
{
    partial class Login_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            username = new Label();
            label2 = new Label();
            Login_Button = new Button();
            NewUser_Button = new Button();
            Password = new TextBox();
            User = new TextBox();
            Login_Status = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(15, 23, 42);
            label1.Location = new Point(70, 37);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(379, 38);
            label1.TabIndex = 0;
            label1.Text = " Keylogger Detection System";
            label1.Click += label1_Click;
            // 
            // username
            // 
            username.AutoSize = true;
            username.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username.Location = new Point(70, 147);
            username.Margin = new Padding(4, 0, 4, 0);
            username.Name = "username";
            username.Size = new Size(82, 20);
            username.TabIndex = 1;
            username.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(70, 217);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // Login_Button
            // 
            Login_Button.BackColor = Color.FromArgb(15, 23, 42);
            Login_Button.FlatAppearance.BorderColor = Color.White;
            Login_Button.FlatStyle = FlatStyle.Flat;
            Login_Button.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Login_Button.ForeColor = Color.White;
            Login_Button.Location = new Point(70, 296);
            Login_Button.Margin = new Padding(4, 3, 4, 3);
            Login_Button.Name = "Login_Button";
            Login_Button.Size = new Size(353, 42);
            Login_Button.TabIndex = 5;
            Login_Button.Text = "Login";
            Login_Button.UseVisualStyleBackColor = false;
            Login_Button.Click += Login_Button_Click;
            // 
            // NewUser_Button
            // 
            NewUser_Button.BackColor = Color.White;
            NewUser_Button.FlatAppearance.BorderColor = Color.FromArgb(15, 23, 42);
            NewUser_Button.FlatAppearance.BorderSize = 2;
            NewUser_Button.FlatStyle = FlatStyle.Popup;
            NewUser_Button.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            NewUser_Button.ForeColor = Color.FromArgb(15, 23, 42);
            NewUser_Button.Location = new Point(72, 354);
            NewUser_Button.Margin = new Padding(4, 3, 4, 3);
            NewUser_Button.Name = "NewUser_Button";
            NewUser_Button.Size = new Size(352, 36);
            NewUser_Button.TabIndex = 6;
            NewUser_Button.Text = "New User";
            NewUser_Button.UseVisualStyleBackColor = false;
            NewUser_Button.Click += NewUser_Button_Click;
            // 
            // Password
            // 
            Password.BackColor = Color.White;
            Password.Font = new Font("Segoe UI Semilight", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Password.Location = new Point(71, 240);
            Password.Multiline = true;
            Password.Name = "Password";
            Password.Size = new Size(350, 35);
            Password.TabIndex = 9;
            Password.UseSystemPasswordChar = true;
            Password.TextChanged += Password_TextChanged;
            // 
            // User
            // 
            User.BackColor = Color.White;
            User.Font = new Font("Segoe UI Semilight", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            User.Location = new Point(71, 179);
            User.Margin = new Padding(4, 12, 4, 3);
            User.Multiline = true;
            User.Name = "User";
            User.Size = new Size(350, 35);
            User.TabIndex = 10;
            // 
            // Login_Status
            // 
            Login_Status.AutoSize = true;
            Login_Status.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Login_Status.Location = new Point(72, 404);
            Login_Status.Name = "Login_Status";
            Login_Status.Size = new Size(0, 22);
            Login_Status.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(15, 23, 42);
            label3.Location = new Point(199, 75);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(107, 28);
            label3.TabIndex = 12;
            label3.Text = "User Login";
            // 
            // Login_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(493, 475);
            Controls.Add(label3);
            Controls.Add(Login_Status);
            Controls.Add(User);
            Controls.Add(Password);
            Controls.Add(NewUser_Button);
            Controls.Add(Login_Button);
            Controls.Add(label2);
            Controls.Add(username);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login_Form";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Login_Button;
        private System.Windows.Forms.Button NewUser_Button;
        private TextBox Password;
        private TextBox User;
        private Label Login_Status;
        private Label label3;
    }
}


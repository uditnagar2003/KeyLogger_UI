
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            username = new Label();
            label2 = new Label();
            Login_Button = new Button();
            NewUser_Button = new Button();
            Password = new TextBox();
            User = new TextBox();
            Login_Status = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            Exit_Button = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // username
            // 
            username.AutoSize = true;
            username.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username.Location = new Point(98, 176);
            username.Margin = new Padding(4, 0, 4, 0);
            username.Name = "username";
            username.Size = new Size(67, 20);
            username.TabIndex = 1;
            username.Text = "E-Mail Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(95, 246);
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
            Login_Button.Location = new Point(68, 325);
            Login_Button.Margin = new Padding(4, 3, 4, 3);
            Login_Button.Name = "Login_Button";
            Login_Button.Size = new Size(353, 42);
            Login_Button.TabIndex = 2;
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
            NewUser_Button.Location = new Point(70, 383);
            NewUser_Button.Margin = new Padding(4, 3, 4, 3);
            NewUser_Button.Name = "NewUser_Button";
            NewUser_Button.Size = new Size(352, 36);
            NewUser_Button.TabIndex = 3;
            NewUser_Button.Text = "New User";
            NewUser_Button.UseVisualStyleBackColor = false;
            NewUser_Button.Click += NewUser_Button_Click;
            // 
            // Password
            // 
            Password.BackColor = Color.White;
            Password.Font = new Font("Segoe UI Semilight", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Password.Location = new Point(69, 269);
            Password.Multiline = true;
            Password.Name = "Password";
            Password.Size = new Size(350, 35);
            Password.TabIndex = 1;
            Password.UseSystemPasswordChar = true;
            Password.KeyPress += Password_KeyPress;
            // 
            // User
            // 
            User.BackColor = Color.White;
            User.Font = new Font("Segoe UI Semilight", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            User.Location = new Point(69, 208);
            User.Margin = new Padding(4, 12, 4, 3);
            User.Multiline = true;
            User.Name = "User";
            User.Size = new Size(350, 35);
            User.TabIndex = 0;
            // 
            // Login_Status
            // 
            Login_Status.AutoSize = true;
            Login_Status.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Login_Status.Location = new Point(70, 433);
            Login_Status.Name = "Login_Status";
            Login_Status.Size = new Size(0, 22);
            Login_Status.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(15, 23, 42);
            label3.Location = new Point(199, 132);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(107, 28);
            label3.TabIndex = 12;
            label3.Text = "User Login";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(70, 177);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(21, 19);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(199, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 117);
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(68, 246);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(21, 19);
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            // 
            // Exit_Button
            // 
            Exit_Button.FlatStyle = FlatStyle.Flat;
            Exit_Button.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Exit_Button.ForeColor = Color.FromArgb(15, 23, 42);
            Exit_Button.Location = new Point(456, 0);
            Exit_Button.Margin = new Padding(4, 3, 4, 3);
            Exit_Button.Name = "Exit_Button";
            Exit_Button.Size = new Size(43, 44);
            Exit_Button.TabIndex = 16;
            Exit_Button.Text = "X";
            Exit_Button.UseVisualStyleBackColor = true;
            Exit_Button.Click += Exit_Button_Click;
            // 
            // Login_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(498, 528);
            Controls.Add(Exit_Button);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(Login_Status);
            Controls.Add(User);
            Controls.Add(Password);
            Controls.Add(NewUser_Button);
            Controls.Add(Login_Button);
            Controls.Add(label2);
            Controls.Add(username);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login_Form";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }



        #endregion
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Login_Button;
        private System.Windows.Forms.Button NewUser_Button;
        private TextBox Password;
        private TextBox User;
        private Label Login_Status;
        private Label label3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button Exit_Button;
    }
}


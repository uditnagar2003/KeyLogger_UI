namespace KLDS_UI
{
    partial class Register
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
            label2 = new Label();
            UserName = new TextBox();
            Email = new TextBox();
            Password = new TextBox();
            Confirm_Password = new TextBox();
            Save_Button = new Button();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(15, 23, 42);
            label2.Location = new Point(175, 30);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(210, 37);
            label2.TabIndex = 20;
            label2.Text = "Register User";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // UserName
            // 
            UserName.Font = new Font("Segoe UI", 14.25F);
            UserName.Location = new Point(98, 132);
            UserName.Margin = new Padding(4, 3, 4, 3);
            UserName.Name = "UserName";
            UserName.Size = new Size(353, 33);
            UserName.TabIndex = 3;
            // 
            // Email
            // 
            Email.Font = new Font("Segoe UI", 14.25F);
            Email.Location = new Point(98, 209);
            Email.Margin = new Padding(4, 3, 4, 3);
            Email.Multiline = true;
            Email.Name = "Email";
            Email.Size = new Size(353, 37);
            Email.TabIndex = 0;
            // 
            // Password
            // 
            Password.Font = new Font("Segoe UI", 14.25F);
            Password.Location = new Point(98, 290);
            Password.Margin = new Padding(4, 3, 4, 3);
            Password.Multiline = true;
            Password.Name = "Password";
            Password.Size = new Size(353, 37);
            Password.TabIndex = 1;
            // 
            // Confirm_Password
            // 
            Confirm_Password.Font = new Font("Segoe UI", 14.25F);
            Confirm_Password.Location = new Point(98, 371);
            Confirm_Password.Margin = new Padding(4, 3, 4, 3);
            Confirm_Password.Name = "Confirm_Password";
            Confirm_Password.Size = new Size(353, 33);
            Confirm_Password.TabIndex = 2;
            // 
            // Save_Button
            // 
            Save_Button.BackColor = Color.FromArgb(15, 23, 42);
            Save_Button.Cursor = Cursors.Hand;
            Save_Button.FlatStyle = FlatStyle.Flat;
            Save_Button.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Save_Button.ForeColor = Color.White;
            Save_Button.Location = new Point(98, 436);
            Save_Button.Margin = new Padding(4, 3, 4, 3);
            Save_Button.Name = "Save_Button";
            Save_Button.Size = new Size(353, 38);
            Save_Button.TabIndex = 24;
            Save_Button.Text = "Register";
            Save_Button.UseVisualStyleBackColor = false;
            Save_Button.Click += Save_Button_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic);
            label4.ForeColor = Color.FromArgb(15, 23, 42);
            label4.Location = new Point(98, 336);
            label4.Margin = new Padding(6);
            label4.Name = "label4";
            label4.Padding = new Padding(4, 3, 4, 3);
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(149, 26);
            label4.TabIndex = 14;
            label4.Text = "Confirm Password:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic);
            label5.ForeColor = Color.FromArgb(15, 23, 42);
            label5.Location = new Point(98, 255);
            label5.Margin = new Padding(6);
            label5.Name = "label5";
            label5.Padding = new Padding(4, 3, 4, 3);
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(94, 26);
            label5.TabIndex = 13;
            label5.Text = "Password :";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic);
            label3.ForeColor = Color.FromArgb(15, 23, 42);
            label3.Location = new Point(98, 174);
            label3.Margin = new Padding(6);
            label3.Name = "label3";
            label3.Padding = new Padding(4, 3, 4, 3);
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(69, 26);
            label3.TabIndex = 11;
            label3.Text = "E-Mail :";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic);
            label1.ForeColor = Color.FromArgb(15, 23, 42);
            label1.Location = new Point(98, 97);
            label1.Margin = new Padding(6);
            label1.Name = "label1";
            label1.Padding = new Padding(4, 3, 4, 3);
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(105, 26);
            label1.TabIndex = 25;
            label1.Text = "User Name :";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(541, 524);
            Controls.Add(Password);
            Controls.Add(Email);
            Controls.Add(Confirm_Password);
            Controls.Add(UserName);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Save_Button);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Register";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox Email;
        private TextBox Password;
        private TextBox Confirm_Password;
        private Button Save_Button;
        private TextBox UserName;
        private Label label4;
        private Label label5;
        private Label label3;
        private Label label1;
    }
}
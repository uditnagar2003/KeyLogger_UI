
namespace KLDS
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            menu_panel = new Panel();
            pictureBox1 = new PictureBox();
            Scan_Button = new Button();
            label3 = new Label();
            Setting_Button = new Button();
            Logout_Button = new Button();
            Dashboard_Button = new Button();
            User_Button = new Button();
            label1 = new Label();
            Top_pannel = new Panel();
            label2 = new Label();
            Exit_Button = new Button();
            mainpanel = new Panel();
            menu_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Top_pannel.SuspendLayout();
            SuspendLayout();
            // 
            // menu_panel
            // 
            menu_panel.BackColor = Color.FromArgb(15, 23, 42);
            menu_panel.BorderStyle = BorderStyle.FixedSingle;
            menu_panel.Controls.Add(pictureBox1);
            menu_panel.Controls.Add(Scan_Button);
            menu_panel.Controls.Add(label3);
            menu_panel.Controls.Add(Setting_Button);
            menu_panel.Controls.Add(Logout_Button);
            menu_panel.Controls.Add(Dashboard_Button);
            menu_panel.Controls.Add(User_Button);
            menu_panel.Controls.Add(label1);
            menu_panel.Dock = DockStyle.Left;
            menu_panel.Location = new Point(0, 0);
            menu_panel.Margin = new Padding(4, 3, 4, 3);
            menu_panel.Name = "menu_panel";
            menu_panel.Size = new Size(220, 610);
            menu_panel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(25, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 85);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Scan_Button
            // 
            Scan_Button.FlatAppearance.BorderSize = 0;
            Scan_Button.FlatStyle = FlatStyle.Flat;
            Scan_Button.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Scan_Button.ForeColor = Color.White;
            Scan_Button.Image = (Image)resources.GetObject("Scan_Button.Image");
            Scan_Button.ImageAlign = ContentAlignment.MiddleLeft;
            Scan_Button.Location = new Point(4, 187);
            Scan_Button.Margin = new Padding(4, 3, 4, 3);
            Scan_Button.Name = "Scan_Button";
            Scan_Button.Padding = new Padding(10, 0, 0, 0);
            Scan_Button.Size = new Size(215, 48);
            Scan_Button.TabIndex = 3;
            Scan_Button.Text = " Scan";
            Scan_Button.TextAlign = ContentAlignment.MiddleLeft;
            Scan_Button.TextImageRelation = TextImageRelation.ImageBeforeText;
            Scan_Button.UseVisualStyleBackColor = true;
            Scan_Button.Click += Scan_Button_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(4, 73);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Padding = new Padding(10, 0, 0, 0);
            label3.Size = new Size(100, 19);
            label3.TabIndex = 6;
            label3.Text = "Main Menu";
            // 
            // Setting_Button
            // 
            Setting_Button.FlatAppearance.BorderSize = 0;
            Setting_Button.FlatStyle = FlatStyle.Flat;
            Setting_Button.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Setting_Button.ForeColor = Color.White;
            Setting_Button.Image = (Image)resources.GetObject("Setting_Button.Image");
            Setting_Button.ImageAlign = ContentAlignment.MiddleLeft;
            Setting_Button.Location = new Point(4, 233);
            Setting_Button.Margin = new Padding(4, 3, 4, 3);
            Setting_Button.Name = "Setting_Button";
            Setting_Button.Padding = new Padding(10, 0, 0, 0);
            Setting_Button.Size = new Size(215, 48);
            Setting_Button.TabIndex = 5;
            Setting_Button.Text = " Setting";
            Setting_Button.TextAlign = ContentAlignment.MiddleLeft;
            Setting_Button.TextImageRelation = TextImageRelation.ImageBeforeText;
            Setting_Button.UseVisualStyleBackColor = true;
            Setting_Button.Click += button1_Click;
            // 
            // Logout_Button
            // 
            Logout_Button.FlatAppearance.BorderSize = 0;
            Logout_Button.FlatStyle = FlatStyle.Flat;
            Logout_Button.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Logout_Button.ForeColor = Color.White;
            Logout_Button.Image = (Image)resources.GetObject("Logout_Button.Image");
            Logout_Button.ImageAlign = ContentAlignment.MiddleLeft;
            Logout_Button.Location = new Point(4, 279);
            Logout_Button.Margin = new Padding(4, 3, 4, 3);
            Logout_Button.Name = "Logout_Button";
            Logout_Button.Padding = new Padding(10, 0, 0, 0);
            Logout_Button.Size = new Size(215, 48);
            Logout_Button.TabIndex = 4;
            Logout_Button.Text = " Logout";
            Logout_Button.TextAlign = ContentAlignment.MiddleLeft;
            Logout_Button.TextImageRelation = TextImageRelation.ImageBeforeText;
            Logout_Button.UseVisualStyleBackColor = true;
            Logout_Button.Click += Logout_Button_Click;
            // 
            // Dashboard_Button
            // 
            Dashboard_Button.FlatAppearance.BorderSize = 0;
            Dashboard_Button.FlatStyle = FlatStyle.Flat;
            Dashboard_Button.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Dashboard_Button.ForeColor = Color.White;
            Dashboard_Button.Image = (Image)resources.GetObject("Dashboard_Button.Image");
            Dashboard_Button.ImageAlign = ContentAlignment.MiddleLeft;
            Dashboard_Button.Location = new Point(4, 141);
            Dashboard_Button.Margin = new Padding(4, 3, 4, 3);
            Dashboard_Button.Name = "Dashboard_Button";
            Dashboard_Button.Padding = new Padding(10, 0, 0, 0);
            Dashboard_Button.Size = new Size(215, 48);
            Dashboard_Button.TabIndex = 2;
            Dashboard_Button.Text = " Dashboard";
            Dashboard_Button.TextImageRelation = TextImageRelation.ImageBeforeText;
            Dashboard_Button.UseVisualStyleBackColor = true;
            Dashboard_Button.Click += Dashboard_Button_Click;
            // 
            // User_Button
            // 
            User_Button.FlatAppearance.BorderColor = Color.FromArgb(15, 23, 42);
            User_Button.FlatAppearance.BorderSize = 0;
            User_Button.FlatStyle = FlatStyle.Flat;
            User_Button.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            User_Button.ForeColor = Color.White;
            User_Button.Image = (Image)resources.GetObject("User_Button.Image");
            User_Button.ImageAlign = ContentAlignment.MiddleLeft;
            User_Button.Location = new Point(4, 95);
            User_Button.Margin = new Padding(4, 3, 4, 3);
            User_Button.Name = "User_Button";
            User_Button.Padding = new Padding(10, 0, 0, 0);
            User_Button.Size = new Size(215, 48);
            User_Button.TabIndex = 1;
            User_Button.Text = " Hi User";
            User_Button.TextAlign = ContentAlignment.MiddleLeft;
            User_Button.TextImageRelation = TextImageRelation.ImageBeforeText;
            User_Button.UseVisualStyleBackColor = true;
            User_Button.Click += User_Button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 17F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(78, 20);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(60, 26);
            label1.TabIndex = 0;
            label1.Text = "KDS";
            label1.Click += label1_Click;
            // 
            // Top_pannel
            // 
            Top_pannel.BackColor = Color.FromArgb(15, 23, 42);
            Top_pannel.Controls.Add(label2);
            Top_pannel.Controls.Add(Exit_Button);
            Top_pannel.Dock = DockStyle.Top;
            Top_pannel.ForeColor = Color.FromArgb(202, 240, 248);
            Top_pannel.Location = new Point(220, 0);
            Top_pannel.Margin = new Padding(4, 3, 4, 3);
            Top_pannel.Name = "Top_pannel";
            Top_pannel.Size = new Size(900, 50);
            Top_pannel.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(15, 23, 42);
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 8);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(279, 24);
            label2.TabIndex = 8;
            label2.Text = "Keylogger Detection System";
            // 
            // Exit_Button
            // 
            Exit_Button.FlatStyle = FlatStyle.Flat;
            Exit_Button.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Exit_Button.ForeColor = Color.White;
            Exit_Button.Location = new Point(857, 3);
            Exit_Button.Margin = new Padding(4, 3, 4, 3);
            Exit_Button.Name = "Exit_Button";
            Exit_Button.Size = new Size(43, 44);
            Exit_Button.TabIndex = 7;
            Exit_Button.Text = "X";
            Exit_Button.UseVisualStyleBackColor = true;
            Exit_Button.Click += Exit_Button_Click;
            Exit_Button.MouseHover += Exit_Button_MouseHover;
            // 
            // mainpanel
            // 
            mainpanel.BackColor = Color.FromArgb(15, 23, 42);
            mainpanel.Dock = DockStyle.Fill;
            mainpanel.Location = new Point(220, 50);
            mainpanel.Margin = new Padding(4, 3, 4, 3);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(900, 560);
            mainpanel.TabIndex = 6;
            mainpanel.Paint += mainpanel_Paint;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 610);
            Controls.Add(mainpanel);
            Controls.Add(Top_pannel);
            Controls.Add(menu_panel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashboardForm";
            menu_panel.ResumeLayout(false);
            menu_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Top_pannel.ResumeLayout(false);
            Top_pannel.PerformLayout();
            ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Panel menu_panel;
        private System.Windows.Forms.Button User_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Logout_Button;
        private System.Windows.Forms.Button Scan_Button;
        private System.Windows.Forms.Button Dashboard_Button;
        private System.Windows.Forms.Panel Top_pannel;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Setting_Button;
        private Label label3;
        private PictureBox pictureBox1;
    }
}
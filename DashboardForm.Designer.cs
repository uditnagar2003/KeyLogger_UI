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
            menu_panel = new Panel();
            Setting_Button = new Button();
            Logout_Button = new Button();
            Scan_Button = new Button();
            Dashboard_Button = new Button();
            User_Button = new Button();
            label1 = new Label();
            Top_pannel = new Panel();
            label2 = new Label();
            Exit_Button = new Button();
            mainpanel = new Panel();
            menu_panel.SuspendLayout();
            Top_pannel.SuspendLayout();
            SuspendLayout();
            // 
            // menu_panel
            // 
            menu_panel.BackColor = Color.FromArgb(0, 180, 216);
            menu_panel.Controls.Add(Setting_Button);
            menu_panel.Controls.Add(Logout_Button);
            menu_panel.Controls.Add(Scan_Button);
            menu_panel.Controls.Add(Dashboard_Button);
            menu_panel.Controls.Add(User_Button);
            menu_panel.Controls.Add(label1);
            menu_panel.Dock = DockStyle.Left;
            menu_panel.Location = new Point(0, 0);
            menu_panel.Margin = new Padding(4, 3, 4, 3);
            menu_panel.Name = "menu_panel";
            menu_panel.Size = new Size(260, 669);
            menu_panel.TabIndex = 0;
            // 
            // Setting_Button
            // 
            Setting_Button.FlatStyle = FlatStyle.Flat;
            Setting_Button.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Setting_Button.ForeColor = Color.FromArgb(202, 240, 248);
            Setting_Button.Location = new Point(13, 303);
            Setting_Button.Margin = new Padding(4, 3, 4, 3);
            Setting_Button.Name = "Setting_Button";
            Setting_Button.Size = new Size(229, 40);
            Setting_Button.TabIndex = 5;
            Setting_Button.Text = "Setting";
            Setting_Button.UseVisualStyleBackColor = true;
            Setting_Button.Click += button1_Click;
            // 
            // Logout_Button
            // 
            Logout_Button.FlatStyle = FlatStyle.Flat;
            Logout_Button.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Logout_Button.ForeColor = Color.FromArgb(202, 240, 248);
            Logout_Button.Location = new Point(13, 369);
            Logout_Button.Margin = new Padding(4, 3, 4, 3);
            Logout_Button.Name = "Logout_Button";
            Logout_Button.Size = new Size(229, 40);
            Logout_Button.TabIndex = 4;
            Logout_Button.Text = "Logout";
            Logout_Button.UseVisualStyleBackColor = true;
            Logout_Button.Click += Logout_Button_Click;
            // 
            // Scan_Button
            // 
            Scan_Button.FlatStyle = FlatStyle.Flat;
            Scan_Button.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Scan_Button.ForeColor = Color.FromArgb(202, 240, 248);
            Scan_Button.Location = new Point(14, 237);
            Scan_Button.Margin = new Padding(4, 3, 4, 3);
            Scan_Button.Name = "Scan_Button";
            Scan_Button.Size = new Size(229, 40);
            Scan_Button.TabIndex = 3;
            Scan_Button.Text = "Scan";
            Scan_Button.UseVisualStyleBackColor = true;
            Scan_Button.Click += Scan_Button_Click;
            // 
            // Dashboard_Button
            // 
            Dashboard_Button.FlatStyle = FlatStyle.Flat;
            Dashboard_Button.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Dashboard_Button.ForeColor = Color.FromArgb(202, 240, 248);
            Dashboard_Button.Location = new Point(14, 179);
            Dashboard_Button.Margin = new Padding(4, 3, 4, 3);
            Dashboard_Button.Name = "Dashboard_Button";
            Dashboard_Button.Size = new Size(229, 40);
            Dashboard_Button.TabIndex = 2;
            Dashboard_Button.Text = "Dashboard";
            Dashboard_Button.UseVisualStyleBackColor = true;
            Dashboard_Button.Click += Dashboard_Button_Click;
            // 
            // User_Button
            // 
            User_Button.FlatStyle = FlatStyle.Flat;
            User_Button.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            User_Button.ForeColor = Color.FromArgb(202, 240, 248);
            User_Button.Location = new Point(13, 121);
            User_Button.Margin = new Padding(4, 3, 4, 3);
            User_Button.Name = "User_Button";
            User_Button.Size = new Size(229, 40);
            User_Button.TabIndex = 1;
            User_Button.Text = "Hi User";
            User_Button.UseVisualStyleBackColor = true;
            User_Button.Click += User_Button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(202, 240, 248);
            label1.Location = new Point(62, 55);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 33);
            label1.TabIndex = 0;
            label1.Text = "Menu";
            // 
            // Top_pannel
            // 
            Top_pannel.BackColor = Color.FromArgb(0, 180, 216);
            Top_pannel.Controls.Add(label2);
            Top_pannel.Controls.Add(Exit_Button);
            Top_pannel.Dock = DockStyle.Top;
            Top_pannel.ForeColor = Color.FromArgb(202, 240, 248);
            Top_pannel.Location = new Point(260, 0);
            Top_pannel.Margin = new Padding(4, 3, 4, 3);
            Top_pannel.Name = "Top_pannel";
            Top_pannel.Size = new Size(908, 42);
            Top_pannel.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(201, 0);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(416, 37);
            label2.TabIndex = 8;
            label2.Text = "Keylogger Detection System";
            // 
            // Exit_Button
            // 
            Exit_Button.FlatStyle = FlatStyle.Flat;
            Exit_Button.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Exit_Button.Location = new Point(864, 0);
            Exit_Button.Margin = new Padding(4, 3, 4, 3);
            Exit_Button.Name = "Exit_Button";
            Exit_Button.Size = new Size(43, 42);
            Exit_Button.TabIndex = 7;
            Exit_Button.Text = "X";
            Exit_Button.UseVisualStyleBackColor = true;
            // 
            // mainpanel
            // 
            mainpanel.Dock = DockStyle.Fill;
            mainpanel.Location = new Point(260, 42);
            mainpanel.Margin = new Padding(4, 3, 4, 3);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(908, 627);
            mainpanel.TabIndex = 6;
            mainpanel.Paint += mainpanel_Paint;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1168, 669);
            Controls.Add(mainpanel);
            Controls.Add(Top_pannel);
            Controls.Add(menu_panel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "DashboardForm";
            Text = "DashboardForm";
            menu_panel.ResumeLayout(false);
            menu_panel.PerformLayout();
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
    }
}
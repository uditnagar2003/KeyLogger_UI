namespace KLDS
{
    partial class UserDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDetail));
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            User_id = new TextBox();
            User_Name = new TextBox();
            EMail = new TextBox();
            textBox3 = new TextBox();
            Back_Button = new Button();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(391, 50);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(128, 30);
            label2.TabIndex = 9;
            label2.Text = "User Details";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI Semilight", 14.25F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(51, 49);
            label1.Margin = new Padding(6);
            label1.Name = "label1";
            label1.Padding = new Padding(4, 3, 4, 3);
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(121, 31);
            label1.TabIndex = 10;
            label1.Text = "User Name :";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semilight", 14.25F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(91, 92);
            label3.Margin = new Padding(6);
            label3.Name = "label3";
            label3.Padding = new Padding(4, 3, 4, 3);
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(81, 31);
            label3.TabIndex = 11;
            label3.Text = "E-Mail :";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(15, 23, 42);
            label4.Dock = DockStyle.Left;
            label4.Font = new Font("Segoe UI Semilight", 14.25F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(85, 6);
            label4.Margin = new Padding(6);
            label4.Name = "label4";
            label4.Padding = new Padding(4, 3, 4, 3);
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(87, 31);
            label4.TabIndex = 12;
            label4.Text = "User Id :";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semilight", 14.25F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(67, 135);
            label5.Margin = new Padding(6);
            label5.Name = "label5";
            label5.Padding = new Padding(4, 3, 4, 3);
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(105, 31);
            label5.TabIndex = 13;
            label5.Text = "Password :";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label4);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(label5);
            flowLayoutPanel1.Font = new Font("Microsoft Sans Serif", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            flowLayoutPanel1.Location = new Point(209, 114);
            flowLayoutPanel1.Margin = new Padding(4, 3, 4, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(178, 200);
            flowLayoutPanel1.TabIndex = 15;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(User_id);
            flowLayoutPanel2.Controls.Add(User_Name);
            flowLayoutPanel2.Controls.Add(EMail);
            flowLayoutPanel2.Controls.Add(textBox3);
            flowLayoutPanel2.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel2.Font = new Font("Microsoft Sans Serif", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            flowLayoutPanel2.Location = new Point(391, 114);
            flowLayoutPanel2.Margin = new Padding(4, 3, 4, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.RightToLeft = RightToLeft.No;
            flowLayoutPanel2.Size = new Size(360, 200);
            flowLayoutPanel2.TabIndex = 16;
            // 
            // User_id
            // 
            User_id.Font = new Font("Segoe UI Semilight", 14.25F);
            User_id.Location = new Point(3, 12);
            User_id.Margin = new Padding(4, 12, 4, 3);
            User_id.Multiline = true;
            User_id.Name = "User_id";
            User_id.Size = new Size(353, 37);
            User_id.TabIndex = 3;
            // 
            // User_Name
            // 
            User_Name.Font = new Font("Segoe UI Semilight", 14.25F);
            User_Name.Location = new Point(3, 55);
            User_Name.Margin = new Padding(4, 3, 4, 3);
            User_Name.Multiline = true;
            User_Name.Name = "User_Name";
            User_Name.Size = new Size(353, 37);
            User_Name.TabIndex = 0;
            // 
            // EMail
            // 
            EMail.Font = new Font("Segoe UI Semilight", 14.25F);
            EMail.Location = new Point(3, 98);
            EMail.Margin = new Padding(4, 3, 4, 3);
            EMail.Multiline = true;
            EMail.Name = "EMail";
            EMail.Size = new Size(353, 37);
            EMail.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI Semilight", 14.25F);
            textBox3.Location = new Point(3, 141);
            textBox3.Margin = new Padding(4, 3, 4, 3);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(353, 37);
            textBox3.TabIndex = 2;
            // 
            // Back_Button
            // 
            Back_Button.BackColor = Color.FromArgb(37, 99, 235);
            Back_Button.Cursor = Cursors.Hand;
            Back_Button.FlatAppearance.BorderSize = 0;
            Back_Button.FlatStyle = FlatStyle.Flat;
            Back_Button.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Back_Button.ForeColor = Color.White;
            Back_Button.Image = (Image)resources.GetObject("Back_Button.Image");
            Back_Button.ImageAlign = ContentAlignment.MiddleLeft;
            Back_Button.Location = new Point(7, 7);
            Back_Button.Margin = new Padding(4, 3, 4, 3);
            Back_Button.Name = "Back_Button";
            Back_Button.Size = new Size(131, 40);
            Back_Button.TabIndex = 19;
            Back_Button.Text = "Go Back";
            Back_Button.TextAlign = ContentAlignment.MiddleLeft;
            Back_Button.TextImageRelation = TextImageRelation.TextBeforeImage;
            Back_Button.UseVisualStyleBackColor = false;
            // 
            // UserDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 23, 42);
            ClientSize = new Size(920, 519);
            Controls.Add(Back_Button);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label2);
            Controls.Add(flowLayoutPanel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "UserDetail";
            Padding = new Padding(4, 3, 4, 3);
            RightToLeft = RightToLeft.Yes;
            Text = "UserDetail";
            Load += UserDetail_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox User_id;
        private System.Windows.Forms.TextBox User_Name;
        private System.Windows.Forms.TextBox EMail;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button Back_Button;
    }
}
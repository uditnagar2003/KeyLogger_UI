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
            flowLayoutPanel2 = new FlowLayoutPanel();
            User_id = new TextBox();
            User_Name = new TextBox();
            EMail = new TextBox();
            label4 = new Label();
            label1 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 17.75F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = Color.White;
            label2.Location = new Point(394, 35);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(145, 32);
            label2.TabIndex = 9;
            label2.Text = "User Details";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(User_id);
            flowLayoutPanel2.Controls.Add(User_Name);
            flowLayoutPanel2.Controls.Add(EMail);
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
            User_id.Enabled = false;
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
            User_Name.Enabled = false;
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
            EMail.Enabled = false;
            EMail.Font = new Font("Segoe UI Semilight", 14.25F);
            EMail.Location = new Point(3, 98);
            EMail.Margin = new Padding(4, 3, 4, 3);
            EMail.Multiline = true;
            EMail.Name = "EMail";
            EMail.Size = new Size(353, 37);
            EMail.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(15, 23, 42);
            label4.Font = new Font("Segoe UI Semilight", 14.25F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(297, 133);
            label4.Margin = new Padding(6);
            label4.Name = "label4";
            label4.Padding = new Padding(4, 3, 4, 3);
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(87, 31);
            label4.TabIndex = 20;
            label4.Text = "User Id :";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semilight", 14.25F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(263, 175);
            label1.Margin = new Padding(6);
            label1.Name = "label1";
            label1.Padding = new Padding(4, 3, 4, 3);
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(121, 31);
            label1.TabIndex = 18;
            label1.Text = "User Name :";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semilight", 14.25F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(303, 218);
            label3.Margin = new Padding(6);
            label3.Name = "label3";
            label3.Padding = new Padding(4, 3, 4, 3);
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(81, 31);
            label3.TabIndex = 19;
            label3.Text = "E-Mail :";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            label3.Click += label3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(263, 134);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(224, 176);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(264, 218);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 30);
            pictureBox3.TabIndex = 23;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(224, 176);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(30, 30);
            pictureBox4.TabIndex = 24;
            pictureBox4.TabStop = false;
            // 
            // UserDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 23, 42);
            ClientSize = new Size(920, 519);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(flowLayoutPanel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "UserDetail";
            Padding = new Padding(4, 3, 4, 3);
            RightToLeft = RightToLeft.Yes;
            Text = "UserDetail";
            Load += UserDetail_Load;
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox User_id;
        private System.Windows.Forms.TextBox User_Name;
        private System.Windows.Forms.TextBox EMail;
        private Label label4;
        private Label label1;
        private Label label3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}
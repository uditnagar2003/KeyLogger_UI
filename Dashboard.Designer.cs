using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;
using TextBox = System.Windows.Forms.TextBox;

namespace KLDS
{
    partial class Dashboard
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            User_id = new Label();
            User_Name = new Label();
            Key_Log = new DataGridView();
            Process_Id = new DataGridViewTextBoxColumn();
            Process_Name = new DataGridViewTextBoxColumn();
            Process_Path = new DataGridViewTextBoxColumn();
            Detection_Time = new DataGridViewTextBoxColumn();
            Action = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            panel4 = new Panel();
            pictureBox3 = new PictureBox();
            Suspended = new TextBox();
            textBox6 = new TextBox();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            Active = new TextBox();
            textBox4 = new TextBox();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            Total = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)Key_Log).BeginInit();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // User_id
            // 
            User_id.AutoSize = true;
            User_id.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            User_id.ForeColor = Color.FromArgb(0, 180, 216);
            User_id.Location = new Point(189, 87);
            User_id.Margin = new Padding(6);
            User_id.Name = "User_id";
            User_id.Padding = new Padding(4, 3, 4, 3);
            User_id.RightToLeft = RightToLeft.No;
            User_id.Size = new Size(8, 31);
            User_id.TabIndex = 14;
            User_id.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // User_Name
            // 
            User_Name.AutoSize = true;
            User_Name.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            User_Name.ForeColor = Color.FromArgb(0, 180, 216);
            User_Name.Location = new Point(509, 87);
            User_Name.Margin = new Padding(6);
            User_Name.Name = "User_Name";
            User_Name.Padding = new Padding(0, 3, 4, 3);
            User_Name.RightToLeft = RightToLeft.No;
            User_Name.Size = new Size(4, 31);
            User_Name.TabIndex = 16;
            User_Name.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Key_Log
            // 
            Key_Log.AllowUserToAddRows = false;
            Key_Log.AllowUserToDeleteRows = false;
            Key_Log.AllowUserToOrderColumns = true;
            Key_Log.AllowUserToResizeColumns = false;
            Key_Log.AllowUserToResizeRows = false;
            Key_Log.BackgroundColor = Color.FromArgb(15, 23, 42);
            Key_Log.BorderStyle = BorderStyle.None;
            Key_Log.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal;
            Key_Log.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            Key_Log.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            Key_Log.ColumnHeadersHeight = 50;
            Key_Log.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            Key_Log.Columns.AddRange(new DataGridViewColumn[] { Process_Id, Process_Name, Process_Path, Detection_Time, Action });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            Key_Log.DefaultCellStyle = dataGridViewCellStyle2;
            Key_Log.EnableHeadersVisualStyles = false;
            Key_Log.GridColor = Color.FromArgb(15, 23, 42);
            Key_Log.Location = new Point(17, 241);
            Key_Log.Margin = new Padding(4, 3, 4, 3);
            Key_Log.MultiSelect = false;
            Key_Log.Name = "Key_Log";
            Key_Log.ReadOnly = true;
            Key_Log.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            Key_Log.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semilight", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(15, 23, 42);
            Key_Log.RowsDefaultCellStyle = dataGridViewCellStyle3;
            Key_Log.RowTemplate.Height = 50;
            Key_Log.RowTemplate.ReadOnly = true;
            Key_Log.ScrollBars = ScrollBars.Vertical;
            Key_Log.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Key_Log.Size = new Size(883, 279);
            Key_Log.TabIndex = 22;
            Key_Log.CellClick += Key_Log_CellClick;
            // 
            // Process_Id
            // 
            Process_Id.HeaderText = "Process Id";
            Process_Id.Name = "Process_Id";
            Process_Id.ReadOnly = true;
            Process_Id.Width = 108;
            // 
            // Process_Name
            // 
            Process_Name.HeaderText = "Process Name";
            Process_Name.Name = "Process_Name";
            Process_Name.ReadOnly = true;
            Process_Name.Width = 158;
            // 
            // Process_Path
            // 
            Process_Path.HeaderText = "Process Path";
            Process_Path.Name = "Process_Path";
            Process_Path.ReadOnly = true;
            Process_Path.Width = 309;
            // 
            // Detection_Time
            // 
            Detection_Time.HeaderText = "Detection Time";
            Detection_Time.Name = "Detection_Time";
            Detection_Time.ReadOnly = true;
            Detection_Time.Width = 128;
            // 
            // Action
            // 
            Action.HeaderText = "Status";
            Action.Name = "Action";
            Action.ReadOnly = true;
            Action.Width = 128;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(15, 23, 42);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 238);
            panel1.TabIndex = 23;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(30, 41, 59);
            panel4.Controls.Add(pictureBox3);
            panel4.Controls.Add(Suspended);
            panel4.Controls.Add(textBox6);
            panel4.Location = new Point(624, 99);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 100);
            panel4.TabIndex = 30;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(199, 29);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(48, 50);
            pictureBox3.TabIndex = 32;
            pictureBox3.TabStop = false;
            // 
            // Suspended
            // 
            Suspended.BackColor = Color.FromArgb(30, 41, 59);
            Suspended.BorderStyle = BorderStyle.None;
            Suspended.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Suspended.ForeColor = Color.White;
            Suspended.Location = new Point(13, 29);
            Suspended.Name = "Suspended";
            Suspended.Size = new Size(100, 33);
            Suspended.TabIndex = 29;
            Suspended.Text = "0";
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.FromArgb(30, 41, 59);
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox6.ForeColor = Color.White;
            textBox6.Location = new Point(13, 16);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 16);
            textBox6.TabIndex = 28;
            textBox6.Text = "Suspended";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(30, 41, 59);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(Active);
            panel3.Controls.Add(textBox4);
            panel3.Location = new Point(319, 99);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 100);
            panel3.TabIndex = 30;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(199, 29);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 50);
            pictureBox2.TabIndex = 31;
            pictureBox2.TabStop = false;
            // 
            // Active
            // 
            Active.BackColor = Color.FromArgb(30, 41, 59);
            Active.BorderStyle = BorderStyle.None;
            Active.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Active.ForeColor = Color.White;
            Active.Location = new Point(13, 29);
            Active.Margin = new Padding(0);
            Active.Name = "Active";
            Active.Size = new Size(100, 33);
            Active.TabIndex = 29;
            Active.Text = "0";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(30, 41, 59);
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox4.ForeColor = Color.White;
            textBox4.Location = new Point(13, 16);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 16);
            textBox4.TabIndex = 28;
            textBox4.Text = "Active";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 41, 59);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(Total);
            panel2.Controls.Add(textBox1);
            panel2.Location = new Point(17, 99);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 100);
            panel2.TabIndex = 25;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(198, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 50);
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // Total
            // 
            Total.BackColor = Color.FromArgb(30, 41, 59);
            Total.BorderStyle = BorderStyle.None;
            Total.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Total.ForeColor = Color.White;
            Total.Location = new Point(13, 29);
            Total.Name = "Total";
            Total.Size = new Size(100, 33);
            Total.TabIndex = 29;
            Total.Text = "0";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(30, 41, 59);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(13, 16);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 16);
            textBox1.TabIndex = 28;
            textBox1.Text = "Total Detection";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(2, 132, 199);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(724, 23);
            button1.Name = "button1";
            button1.Size = new Size(150, 36);
            button1.TabIndex = 24;
            button1.Text = "Start Scan";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(11, 40);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(346, 19);
            label1.TabIndex = 12;
            label1.Text = "Monitor and Manage Keylogger in Your System";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(11, 11);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(313, 24);
            label2.TabIndex = 11;
            label2.Text = "Keylogger Detection Dashboard";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 23, 42);
            ClientSize = new Size(900, 520);
            Controls.Add(panel1);
            Controls.Add(User_Name);
            Controls.Add(User_id);
            Controls.Add(Key_Log);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)Key_Log).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }



        #endregion
        private System.Windows.Forms.Label User_id;
        private System.Windows.Forms.Label User_Name;
        private System.Windows.Forms.DataGridView Key_Log;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Button button1;
        private Panel panel2;
        private TextBox Total;
        private TextBox textBox1;
        private Panel panel4;
        private TextBox Suspended;
        private TextBox textBox6;
        private Panel panel3;
        private TextBox Active;
        private TextBox textBox4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private DataGridViewTextBoxColumn Process_Id;
        private DataGridViewTextBoxColumn Process_Name;
        private DataGridViewTextBoxColumn Process_Path;
        private DataGridViewTextBoxColumn Detection_Time;
        private DataGridViewTextBoxColumn Action;
    }
}
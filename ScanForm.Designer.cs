namespace KLDS
{
    partial class ScanForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScanForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Stop_Button = new Button();
            Start_Button = new Button();
            Percentage = new Label();
            panel2 = new Panel();
            label2 = new Label();
            progressBar1 = new ProgressBar();
            Task_Label = new Label();
            label1 = new Label();
            label3 = new Label();
            Process_Scanned = new DataGridView();
            Procees_Id = new DataGridViewTextBoxColumn();
            Process_Name = new DataGridViewTextBoxColumn();
            Process_Path = new DataGridViewTextBoxColumn();
            Bytes_Written = new DataGridViewTextBoxColumn();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Process_Scanned).BeginInit();
            SuspendLayout();
            // 
            // Stop_Button
            // 
            Stop_Button.BackColor = Color.FromArgb(239, 68, 68);
            Stop_Button.Cursor = Cursors.Hand;
            Stop_Button.FlatStyle = FlatStyle.Flat;
            Stop_Button.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Stop_Button.ForeColor = Color.White;
            Stop_Button.Image = (Image)resources.GetObject("Stop_Button.Image");
            Stop_Button.ImageAlign = ContentAlignment.MiddleLeft;
            Stop_Button.Location = new Point(752, 12);
            Stop_Button.Margin = new Padding(4, 3, 4, 3);
            Stop_Button.Name = "Stop_Button";
            Stop_Button.Size = new Size(130, 45);
            Stop_Button.TabIndex = 28;
            Stop_Button.Text = "Stop Scan";
            Stop_Button.TextAlign = ContentAlignment.MiddleLeft;
            Stop_Button.TextImageRelation = TextImageRelation.ImageBeforeText;
            Stop_Button.UseVisualStyleBackColor = false;
            Stop_Button.Click += Stop_Button_Click;
            // 
            // Start_Button
            // 
            Start_Button.BackColor = Color.FromArgb(2, 132, 199);
            Start_Button.Cursor = Cursors.Hand;
            Start_Button.FlatStyle = FlatStyle.Flat;
            Start_Button.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Start_Button.ForeColor = Color.White;
            Start_Button.Image = (Image)resources.GetObject("Start_Button.Image");
            Start_Button.ImageAlign = ContentAlignment.MiddleLeft;
            Start_Button.Location = new Point(597, 12);
            Start_Button.Margin = new Padding(4, 3, 4, 3);
            Start_Button.Name = "Start_Button";
            Start_Button.Size = new Size(130, 45);
            Start_Button.TabIndex = 29;
            Start_Button.Text = "Start Scan";
            Start_Button.TextAlign = ContentAlignment.MiddleLeft;
            Start_Button.TextImageRelation = TextImageRelation.ImageBeforeText;
            Start_Button.UseVisualStyleBackColor = false;
            Start_Button.Click += Start_Button_Click;
            // 
            // Percentage
            // 
            Percentage.AutoSize = true;
            Percentage.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Percentage.ForeColor = Color.White;
            Percentage.Location = new Point(758, 102);
            Percentage.Margin = new Padding(6);
            Percentage.Name = "Percentage";
            Percentage.Padding = new Padding(4, 3, 4, 3);
            Percentage.RightToLeft = RightToLeft.No;
            Percentage.Size = new Size(127, 36);
            Percentage.TabIndex = 32;
            Percentage.Text = "Percentage";
            Percentage.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 41, 59);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(0, 152);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(900, 72);
            panel2.TabIndex = 34;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semilight", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(6, 17);
            label2.Margin = new Padding(6);
            label2.Name = "label2";
            label2.Padding = new Padding(4, 3, 4, 3);
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(234, 36);
            label2.TabIndex = 36;
            label2.Text = "Process Being Processed";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // progressBar1
            // 
            progressBar1.ForeColor = SystemColors.HotTrack;
            progressBar1.Location = new Point(22, 76);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(861, 23);
            progressBar1.TabIndex = 39;
            // 
            // Task_Label
            // 
            Task_Label.AutoSize = true;
            Task_Label.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Task_Label.ForeColor = Color.White;
            Task_Label.Location = new Point(22, 102);
            Task_Label.Name = "Task_Label";
            Task_Label.Size = new Size(50, 21);
            Task_Label.TabIndex = 40;
            Task_Label.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(22, 1);
            label1.Margin = new Padding(6);
            label1.Name = "label1";
            label1.Padding = new Padding(4, 3, 4, 3);
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(167, 36);
            label1.TabIndex = 41;
            label1.Text = "Keylogger Scan";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(22, 52);
            label3.Name = "label3";
            label3.Size = new Size(105, 21);
            label3.TabIndex = 42;
            label3.Text = "Scan Progress";
            // 
            // Process_Scanned
            // 
            Process_Scanned.AllowUserToAddRows = false;
            Process_Scanned.AllowUserToOrderColumns = true;
            Process_Scanned.AllowUserToResizeColumns = false;
            Process_Scanned.AllowUserToResizeRows = false;
            Process_Scanned.BackgroundColor = Color.FromArgb(15, 23, 42);
            Process_Scanned.BorderStyle = BorderStyle.None;
            Process_Scanned.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal;
            Process_Scanned.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            Process_Scanned.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            Process_Scanned.ColumnHeadersHeight = 50;
            Process_Scanned.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            Process_Scanned.Columns.AddRange(new DataGridViewColumn[] { Procees_Id, Process_Name, Process_Path, Bytes_Written });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            Process_Scanned.DefaultCellStyle = dataGridViewCellStyle2;
            Process_Scanned.EnableHeadersVisualStyles = false;
            Process_Scanned.GridColor = Color.FromArgb(15, 23, 42);
            Process_Scanned.Location = new Point(17, 227);
            Process_Scanned.Margin = new Padding(17, 0, 0, 0);
            Process_Scanned.MultiSelect = false;
            Process_Scanned.Name = "Process_Scanned";
            Process_Scanned.ReadOnly = true;
            Process_Scanned.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            Process_Scanned.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semilight", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            Process_Scanned.RowsDefaultCellStyle = dataGridViewCellStyle3;
            Process_Scanned.RowTemplate.Height = 50;
            Process_Scanned.RowTemplate.ReadOnly = true;
            Process_Scanned.ScrollBars = ScrollBars.Vertical;
            Process_Scanned.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Process_Scanned.Size = new Size(883, 294);
            Process_Scanned.TabIndex = 43;
            // 
            // Procees_Id
            // 
            Procees_Id.HeaderText = "Process Id";
            Procees_Id.Name = "Procees_Id";
            Procees_Id.ReadOnly = true;
            Procees_Id.Width = 183;
            // 
            // Process_Name
            // 
            Process_Name.HeaderText = "Process Name";
            Process_Name.Name = "Process_Name";
            Process_Name.ReadOnly = true;
            Process_Name.Width = 183;
            // 
            // Process_Path
            // 
            Process_Path.HeaderText = "Process Path";
            Process_Path.Name = "Process_Path";
            Process_Path.ReadOnly = true;
            Process_Path.Width = 334;
            // 
            // Bytes_Written
            // 
            Bytes_Written.HeaderText = "BytesWritten";
            Bytes_Written.Name = "Bytes_Written";
            Bytes_Written.ReadOnly = true;
            Bytes_Written.Width = 183;
            // 
            // ScanForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 23, 42);
            ClientSize = new Size(900, 520);
            Controls.Add(Process_Scanned);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(Task_Label);
            Controls.Add(progressBar1);
            Controls.Add(panel2);
            Controls.Add(Percentage);
            Controls.Add(Start_Button);
            Controls.Add(Stop_Button);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "ScanForm";
            Text = "ScanForm";
            Load += ScanForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Process_Scanned).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Stop_Button;
        private System.Windows.Forms.Button Start_Button;
        private System.Windows.Forms.Label Percentage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private ProgressBar progressBar1;
        private Label Task_Label;
        private Label label1;
        private Label label3;
        private DataGridView Process_Scanned;
        private DataGridViewTextBoxColumn Procees_Id;
        private DataGridViewTextBoxColumn Process_Name;
        private DataGridViewTextBoxColumn Process_Path;
        private DataGridViewTextBoxColumn Bytes_Written;
    }
}
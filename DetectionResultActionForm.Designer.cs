namespace KLDS
{
    partial class DetectionResultActionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetectionResultActionForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label2 = new Label();
            ProcessName = new TextBox();
            ProcesId = new TextBox();
            label1 = new Label();
            label3 = new Label();
            Ignore_Button = new Button();
            Suspend_Button = new Button();
            Detected_Table = new DataGridView();
            Process_Id = new DataGridViewTextBoxColumn();
            Process_Name = new DataGridViewTextBoxColumn();
            Process_Path = new DataGridViewTextBoxColumn();
            PCC = new DataGridViewTextBoxColumn();
            Detection_Time = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)Detected_Table).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semilight", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(24, 23);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(287, 32);
            label2.TabIndex = 17;
            label2.Text = "Detected Keylogger process";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // ProcessName
            // 
            ProcessName.Font = new Font("Segoe UI Semilight", 12F);
            ProcessName.Location = new Point(604, 438);
            ProcessName.Margin = new Padding(4, 3, 4, 3);
            ProcessName.Name = "ProcessName";
            ProcessName.Size = new Size(116, 29);
            ProcessName.TabIndex = 28;
            // 
            // ProcesId
            // 
            ProcesId.Font = new Font("Segoe UI Semilight", 12F);
            ProcesId.Location = new Point(222, 438);
            ProcesId.Margin = new Padding(4, 3, 4, 3);
            ProcesId.Name = "ProcesId";
            ProcesId.Size = new Size(116, 29);
            ProcesId.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semilight", 14.25F, FontStyle.Italic);
            label1.ForeColor = Color.White;
            label1.Location = new Point(461, 440);
            label1.Margin = new Padding(6);
            label1.Name = "label1";
            label1.Padding = new Padding(4, 3, 4, 3);
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(133, 31);
            label1.TabIndex = 26;
            label1.Text = "Process Name";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semilight", 14.25F, FontStyle.Italic);
            label3.ForeColor = Color.White;
            label3.Location = new Point(113, 440);
            label3.Margin = new Padding(6);
            label3.Name = "label3";
            label3.Padding = new Padding(4, 3, 4, 3);
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(99, 31);
            label3.TabIndex = 25;
            label3.Text = "Process Id";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Ignore_Button
            // 
            Ignore_Button.BackColor = Color.FromArgb(37, 99, 235);
            Ignore_Button.Cursor = Cursors.Hand;
            Ignore_Button.FlatStyle = FlatStyle.Flat;
            Ignore_Button.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Ignore_Button.ForeColor = Color.White;
            Ignore_Button.Image = (Image)resources.GetObject("Ignore_Button.Image");
            Ignore_Button.ImageAlign = ContentAlignment.MiddleLeft;
            Ignore_Button.Location = new Point(676, 23);
            Ignore_Button.Margin = new Padding(4, 3, 4, 3);
            Ignore_Button.Name = "Ignore_Button";
            Ignore_Button.Padding = new Padding(5, 0, 0, 0);
            Ignore_Button.Size = new Size(199, 37);
            Ignore_Button.TabIndex = 29;
            Ignore_Button.Text = "Save Results";
            Ignore_Button.TextAlign = ContentAlignment.MiddleLeft;
            Ignore_Button.TextImageRelation = TextImageRelation.ImageBeforeText;
            Ignore_Button.UseVisualStyleBackColor = false;
            Ignore_Button.Click += Ignore_Button_Click;
            // 
            // Suspend_Button
            // 
            Suspend_Button.BackColor = Color.FromArgb(37, 99, 235);
            Suspend_Button.Cursor = Cursors.Hand;
            Suspend_Button.FlatStyle = FlatStyle.Flat;
            Suspend_Button.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Suspend_Button.ForeColor = Color.White;
            Suspend_Button.Location = new Point(300, 480);
            Suspend_Button.Margin = new Padding(4, 3, 4, 3);
            Suspend_Button.Name = "Suspend_Button";
            Suspend_Button.Size = new Size(259, 45);
            Suspend_Button.TabIndex = 29;
            Suspend_Button.Text = "Suspend Process";
            Suspend_Button.UseVisualStyleBackColor = false;
            Suspend_Button.Click += Suspend_Button_Click_1;
            // 
            // Detected_Table
            // 
            Detected_Table.AllowUserToAddRows = false;
            Detected_Table.AllowUserToDeleteRows = false;
            Detected_Table.AllowUserToOrderColumns = true;
            Detected_Table.AllowUserToResizeColumns = false;
            Detected_Table.AllowUserToResizeRows = false;
            Detected_Table.BackgroundColor = Color.FromArgb(15, 23, 42);
            Detected_Table.BorderStyle = BorderStyle.None;
            Detected_Table.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal;
            Detected_Table.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            Detected_Table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            Detected_Table.ColumnHeadersHeight = 50;
            Detected_Table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            Detected_Table.Columns.AddRange(new DataGridViewColumn[] { Process_Id, Process_Name, Process_Path, PCC, Detection_Time, Status });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            Detected_Table.DefaultCellStyle = dataGridViewCellStyle2;
            Detected_Table.EnableHeadersVisualStyles = false;
            Detected_Table.GridColor = Color.FromArgb(15, 23, 42);
            Detected_Table.Location = new Point(13, 78);
            Detected_Table.Margin = new Padding(4, 3, 4, 3);
            Detected_Table.MultiSelect = false;
            Detected_Table.Name = "Detected_Table";
            Detected_Table.ReadOnly = true;
            Detected_Table.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            Detected_Table.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semilight", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            Detected_Table.RowsDefaultCellStyle = dataGridViewCellStyle3;
            Detected_Table.RowTemplate.Height = 50;
            Detected_Table.RowTemplate.ReadOnly = true;
            Detected_Table.ScrollBars = ScrollBars.Vertical;
            Detected_Table.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Detected_Table.Size = new Size(883, 353);
            Detected_Table.TabIndex = 30;
            Detected_Table.CellClick += Detected_Table_CellClick;
            // 
            // Process_Id
            // 
            Process_Id.HeaderText = "Process Id";
            Process_Id.Name = "Process_Id";
            Process_Id.ReadOnly = true;
            Process_Id.Width = 96;
            // 
            // Process_Name
            // 
            Process_Name.HeaderText = "Process Name";
            Process_Name.Name = "Process_Name";
            Process_Name.ReadOnly = true;
            Process_Name.Width = 146;
            // 
            // Process_Path
            // 
            Process_Path.HeaderText = "Process Path";
            Process_Path.Name = "Process_Path";
            Process_Path.ReadOnly = true;
            Process_Path.Width = 297;
            // 
            // PCC
            // 
            PCC.HeaderText = "PCC";
            PCC.Name = "PCC";
            PCC.ReadOnly = true;
            PCC.Width = 88;
            // 
            // Detection_Time
            // 
            Detection_Time.HeaderText = "Detection Time";
            Detection_Time.Name = "Detection_Time";
            Detection_Time.ReadOnly = true;
            Detection_Time.Width = 116;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Width = 116;
            // 
            // DetectionResultActionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 23, 42);
            ClientSize = new Size(900, 537);
            Controls.Add(Detected_Table);
            Controls.Add(Suspend_Button);
            Controls.Add(Ignore_Button);
            Controls.Add(ProcessName);
            Controls.Add(ProcesId);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "DetectionResultActionForm";
            Text = "DetectionResultActionForm";
            Load += DetectionResultActionForm_Load;
            ((System.ComponentModel.ISupportInitialize)Detected_Table).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ProcessName;
        private System.Windows.Forms.TextBox ProcesId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Ignore_Button;
        private System.Windows.Forms.Button Suspend_Button;
        private DataGridView Detected_Table;
        private DataGridViewTextBoxColumn Process_Id;
        private DataGridViewTextBoxColumn Process_Name;
        private DataGridViewTextBoxColumn Process_Path;
        private DataGridViewTextBoxColumn PCC;
        private DataGridViewTextBoxColumn Detection_Time;
        private DataGridViewTextBoxColumn Status;
    }
}
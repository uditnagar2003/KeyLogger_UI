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
            label2 = new Label();
            Detected_Table = new DataGridView();
            Process_Id = new DataGridViewTextBoxColumn();
            Process_Name = new DataGridViewTextBoxColumn();
            Process_Path = new DataGridViewTextBoxColumn();
            PCC = new DataGridViewTextBoxColumn();
            Action = new DataGridViewTextBoxColumn();
            ProcessName = new TextBox();
            ProcesId = new TextBox();
            label1 = new Label();
            label3 = new Label();
            Ignore_Button = new Button();
            Suspend_Button = new Button();
            label4 = new Label();
            Time_of_Detection = new Label();
            Threshold_PCC = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)Detected_Table).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 180, 216);
            label2.Location = new Point(352, 10);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(249, 37);
            label2.TabIndex = 17;
            label2.Text = "Detection Result";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.Click += label2_Click;
            // 
            // Detected_Table
            // 
            Detected_Table.AllowUserToDeleteRows = false;
            Detected_Table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Detected_Table.Columns.AddRange(new DataGridViewColumn[] { Process_Id, Process_Name, Process_Path, PCC, Action });
            Detected_Table.Location = new Point(37, 141);
            Detected_Table.Margin = new Padding(4, 3, 4, 3);
            Detected_Table.MultiSelect = false;
            Detected_Table.Name = "Detected_Table";
            Detected_Table.ReadOnly = true;
            Detected_Table.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Detected_Table.Size = new Size(868, 273);
            Detected_Table.TabIndex = 18;
            Detected_Table.CellContentClick += Detected_Table_CellClick;
            // 
            // Process_Id
            // 
            Process_Id.HeaderText = "Process_Id";
            Process_Id.Name = "Process_Id";
            Process_Id.ReadOnly = true;
            // 
            // Process_Name
            // 
            Process_Name.HeaderText = "Process Name";
            Process_Name.Name = "Process_Name";
            Process_Name.ReadOnly = true;
            // 
            // Process_Path
            // 
            Process_Path.FillWeight = 300F;
            Process_Path.HeaderText = "Process Path";
            Process_Path.Name = "Process_Path";
            Process_Path.ReadOnly = true;
            Process_Path.Width = 300;
            // 
            // PCC
            // 
            PCC.HeaderText = "PCC";
            PCC.Name = "PCC";
            PCC.ReadOnly = true;
            // 
            // Action
            // 
            Action.HeaderText = "Action";
            Action.Name = "Action";
            Action.ReadOnly = true;
            // 
            // ProcessName
            // 
            ProcessName.Location = new Point(654, 450);
            ProcessName.Margin = new Padding(4, 3, 4, 3);
            ProcessName.Name = "ProcessName";
            ProcessName.Size = new Size(116, 21);
            ProcessName.TabIndex = 28;
            ProcessName.TextChanged += textBox2_TextChanged;
            // 
            // ProcesId
            // 
            ProcesId.Location = new Point(261, 450);
            ProcesId.Margin = new Padding(4, 3, 4, 3);
            ProcesId.Name = "ProcesId";
            ProcesId.Size = new Size(116, 21);
            ProcesId.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 180, 216);
            label1.Location = new Point(461, 440);
            label1.Margin = new Padding(6);
            label1.Name = "label1";
            label1.Padding = new Padding(4, 3, 4, 3);
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(160, 31);
            label1.TabIndex = 26;
            label1.Text = "Process Name";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 180, 216);
            label3.Location = new Point(113, 440);
            label3.Margin = new Padding(6);
            label3.Name = "label3";
            label3.Padding = new Padding(4, 3, 4, 3);
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(121, 31);
            label3.TabIndex = 25;
            label3.Text = "Process Id";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Ignore_Button
            // 
            Ignore_Button.BackColor = Color.FromArgb(0, 180, 216);
            Ignore_Button.Cursor = Cursors.Hand;
            Ignore_Button.FlatStyle = FlatStyle.Flat;
            Ignore_Button.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Ignore_Button.ForeColor = Color.FromArgb(202, 240, 248);
            Ignore_Button.Location = new Point(467, 480);
            Ignore_Button.Margin = new Padding(4, 3, 4, 3);
            Ignore_Button.Name = "Ignore_Button";
            Ignore_Button.Size = new Size(259, 45);
            Ignore_Button.TabIndex = 29;
            Ignore_Button.Text = "Ignore Process";
            Ignore_Button.UseVisualStyleBackColor = false;
            Ignore_Button.Click += Ignore_Button_Click;
            // 
            // Suspend_Button
            // 
            Suspend_Button.BackColor = Color.FromArgb(0, 180, 216);
            Suspend_Button.Cursor = Cursors.Hand;
            Suspend_Button.FlatStyle = FlatStyle.Flat;
            Suspend_Button.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Suspend_Button.ForeColor = Color.FromArgb(202, 240, 248);
            Suspend_Button.Location = new Point(119, 480);
            Suspend_Button.Margin = new Padding(4, 3, 4, 3);
            Suspend_Button.Name = "Suspend_Button";
            Suspend_Button.Size = new Size(259, 45);
            Suspend_Button.TabIndex = 29;
            Suspend_Button.Text = "Suspend Process";
            Suspend_Button.UseVisualStyleBackColor = false;
            Suspend_Button.Click += Suspend_Button_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 180, 216);
            label4.Location = new Point(31, 73);
            label4.Margin = new Padding(6);
            label4.Name = "label4";
            label4.Padding = new Padding(4, 3, 4, 3);
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(192, 31);
            label4.TabIndex = 30;
            label4.Text = "Time Of Detection";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Time_of_Detection
            // 
            Time_of_Detection.AutoSize = true;
            Time_of_Detection.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Time_of_Detection.ForeColor = Color.FromArgb(0, 180, 216);
            Time_of_Detection.Location = new Point(265, 73);
            Time_of_Detection.Margin = new Padding(6);
            Time_of_Detection.Name = "Time_of_Detection";
            Time_of_Detection.Padding = new Padding(4, 3, 4, 3);
            Time_of_Detection.RightToLeft = RightToLeft.No;
            Time_of_Detection.Size = new Size(192, 31);
            Time_of_Detection.TabIndex = 31;
            Time_of_Detection.Text = "Time Of Detection";
            Time_of_Detection.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Threshold_PCC
            // 
            Threshold_PCC.AutoSize = true;
            Threshold_PCC.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Threshold_PCC.ForeColor = Color.FromArgb(0, 180, 216);
            Threshold_PCC.Location = new Point(732, 73);
            Threshold_PCC.Margin = new Padding(6);
            Threshold_PCC.Name = "Threshold_PCC";
            Threshold_PCC.Padding = new Padding(4, 3, 4, 3);
            Threshold_PCC.RightToLeft = RightToLeft.No;
            Threshold_PCC.Size = new Size(166, 31);
            Threshold_PCC.TabIndex = 33;
            Threshold_PCC.Text = "Threshold PCC";
            Threshold_PCC.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 180, 216);
            label6.Location = new Point(498, 73);
            label6.Margin = new Padding(6);
            label6.Name = "label6";
            label6.Padding = new Padding(4, 3, 4, 3);
            label6.RightToLeft = RightToLeft.No;
            label6.Size = new Size(166, 31);
            label6.TabIndex = 32;
            label6.Text = "Threshold PCC";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DetectionResultActionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(959, 570);
            Controls.Add(Threshold_PCC);
            Controls.Add(label6);
            Controls.Add(Time_of_Detection);
            Controls.Add(label4);
            Controls.Add(Suspend_Button);
            Controls.Add(Ignore_Button);
            Controls.Add(ProcessName);
            Controls.Add(ProcesId);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(Detected_Table);
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox ProcessName;
        private System.Windows.Forms.TextBox ProcesId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Ignore_Button;
        private System.Windows.Forms.Button Suspend_Button;
        private System.Windows.Forms.DataGridViewTextBoxColumn Process_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Process_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Process_Path;
        private System.Windows.Forms.DataGridViewTextBoxColumn PCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Action;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Time_of_Detection;
        private System.Windows.Forms.Label Threshold_PCC;
        private System.Windows.Forms.Label label6;
        private DataGridView Detected_Table;
    }
}
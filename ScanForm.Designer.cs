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
            Stop_Button = new Button();
            Start_Button = new Button();
            Percentage = new Label();
            panel1 = new Panel();
            Input_Box = new RichTextBox();
            label1 = new Label();
            panel2 = new Panel();
            Process_Scanned = new DataGridView();
            Procees_Id = new DataGridViewTextBoxColumn();
            Process_Name = new DataGridViewTextBoxColumn();
            Bytes_Written = new DataGridViewTextBoxColumn();
            PCC = new DataGridViewTextBoxColumn();
            label2 = new Label();
            statusStrip1 = new StatusStrip();
            Task_Label = new ToolStripStatusLabel();
            progressBar1 = new ToolStripProgressBar();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Process_Scanned).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Stop_Button
            // 
            Stop_Button.BackColor = Color.FromArgb(0, 180, 216);
            Stop_Button.Cursor = Cursors.Hand;
            Stop_Button.FlatStyle = FlatStyle.Flat;
            Stop_Button.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Stop_Button.ForeColor = Color.FromArgb(202, 240, 248);
            Stop_Button.Location = new Point(288, 14);
            Stop_Button.Margin = new Padding(4, 3, 4, 3);
            Stop_Button.Name = "Stop_Button";
            Stop_Button.Size = new Size(198, 45);
            Stop_Button.TabIndex = 28;
            Stop_Button.Text = "Stop Detection";
            Stop_Button.UseVisualStyleBackColor = false;
            Stop_Button.Click += Stop_Button_Click;
            // 
            // Start_Button
            // 
            Start_Button.BackColor = Color.FromArgb(0, 180, 216);
            Start_Button.Cursor = Cursors.Hand;
            Start_Button.FlatStyle = FlatStyle.Flat;
            Start_Button.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Start_Button.ForeColor = Color.FromArgb(202, 240, 248);
            Start_Button.Location = new Point(55, 14);
            Start_Button.Margin = new Padding(4, 3, 4, 3);
            Start_Button.Name = "Start_Button";
            Start_Button.Size = new Size(205, 45);
            Start_Button.TabIndex = 29;
            Start_Button.Text = "Start Detection";
            Start_Button.UseVisualStyleBackColor = false;
            Start_Button.Click += Start_Button_Click;
            // 
            // Percentage
            // 
            Percentage.AutoSize = true;
            Percentage.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Percentage.ForeColor = Color.FromArgb(0, 180, 216);
            Percentage.Location = new Point(737, 31);
            Percentage.Margin = new Padding(6);
            Percentage.Name = "Percentage";
            Percentage.Padding = new Padding(4, 3, 4, 3);
            Percentage.RightToLeft = RightToLeft.No;
            Percentage.Size = new Size(130, 31);
            Percentage.TabIndex = 32;
            Percentage.Text = "Percentage";
            Percentage.TextAlign = ContentAlignment.MiddleLeft;
            Percentage.Click += Percentage_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(Input_Box);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(22, 157);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(326, 348);
            panel1.TabIndex = 33;
            // 
            // Input_Box
            // 
            Input_Box.Location = new Point(12, 51);
            Input_Box.Margin = new Padding(4, 3, 4, 3);
            Input_Box.Name = "Input_Box";
            Input_Box.Size = new Size(310, 282);
            Input_Box.TabIndex = 38;
            Input_Box.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 180, 216);
            label1.Location = new Point(6, 6);
            label1.Margin = new Padding(6);
            label1.Name = "label1";
            label1.Padding = new Padding(4, 3, 4, 3);
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(145, 31);
            label1.TabIndex = 35;
            label1.Text = "Text Inputted";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(Process_Scanned);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(355, 157);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(532, 348);
            panel2.TabIndex = 34;
            // 
            // Process_Scanned
            // 
            Process_Scanned.AllowUserToDeleteRows = false;
            Process_Scanned.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Process_Scanned.Columns.AddRange(new DataGridViewColumn[] { Procees_Id, Process_Name, Bytes_Written, PCC });
            Process_Scanned.Location = new Point(12, 51);
            Process_Scanned.Margin = new Padding(4, 3, 4, 3);
            Process_Scanned.Name = "Process_Scanned";
            Process_Scanned.ReadOnly = true;
            Process_Scanned.Size = new Size(517, 294);
            Process_Scanned.TabIndex = 37;
            // 
            // Procees_Id
            // 
            Procees_Id.HeaderText = "Process Id";
            Procees_Id.Name = "Procees_Id";
            Procees_Id.ReadOnly = true;
            // 
            // Process_Name
            // 
            Process_Name.HeaderText = "Process Name";
            Process_Name.Name = "Process_Name";
            Process_Name.ReadOnly = true;
            // 
            // Bytes_Written
            // 
            Bytes_Written.HeaderText = "Bytes Written";
            Bytes_Written.Name = "Bytes_Written";
            Bytes_Written.ReadOnly = true;
            // 
            // PCC
            // 
            PCC.HeaderText = "PCC";
            PCC.Name = "PCC";
            PCC.ReadOnly = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 180, 216);
            label2.Location = new Point(6, 6);
            label2.Margin = new Padding(6);
            label2.Name = "label2";
            label2.Padding = new Padding(4, 3, 4, 3);
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(267, 31);
            label2.TabIndex = 36;
            label2.Text = "Process Being Processed";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // statusStrip1
            // 
            statusStrip1.AutoSize = false;
            statusStrip1.Dock = DockStyle.None;
            statusStrip1.Items.AddRange(new ToolStripItem[] { Task_Label, progressBar1 });
            statusStrip1.Location = new Point(22, 78);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(862, 35);
            statusStrip1.TabIndex = 38;
            statusStrip1.Text = "statusStrip1";
            // 
            // Task_Label
            // 
            Task_Label.AutoSize = false;
            Task_Label.Name = "Task_Label";
            Task_Label.Size = new Size(300, 30);
            Task_Label.Text = "toolStripStatusLabel1";
            // 
            // progressBar1
            // 
            progressBar1.AutoSize = false;
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(530, 29);
            // 
            // ScanForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 519);
            Controls.Add(statusStrip1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(Percentage);
            Controls.Add(Start_Button);
            Controls.Add(Stop_Button);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "ScanForm";
            Text = "ScanForm";
            Load += ScanForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Process_Scanned).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Stop_Button;
        private System.Windows.Forms.Button Start_Button;
        private System.Windows.Forms.Label Percentage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox Input_Box;
        private System.Windows.Forms.DataGridView Process_Scanned;
        private System.Windows.Forms.DataGridViewTextBoxColumn Procees_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Process_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bytes_Written;
        private System.Windows.Forms.DataGridViewTextBoxColumn PCC;
        private System.Windows.Forms.Label label2;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel Task_Label;
        private ToolStripProgressBar progressBar1;
    }
}
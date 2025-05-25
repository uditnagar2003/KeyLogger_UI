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
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Ignore_Button = new System.Windows.Forms.Button();
            this.Suspend_Button = new System.Windows.Forms.Button();
            this.Process_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Process_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Process_Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.Time_of_Detection = new System.Windows.Forms.Label();
            this.Threshold_PCC = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(216)))));
            this.label2.Location = new System.Drawing.Point(302, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 37);
            this.label2.TabIndex = 17;
            this.label2.Text = "Detection Result";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Process_Id,
            this.Process_Name,
            this.Process_Path,
            this.PCC,
            this.Action});
            this.dataGridView1.Location = new System.Drawing.Point(32, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(744, 237);
            this.dataGridView1.TabIndex = 18;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(561, 390);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 28;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(224, 390);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(216)))));
            this.label1.Location = new System.Drawing.Point(395, 381);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(3);
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(158, 31);
            this.label1.TabIndex = 26;
            this.label1.Text = "Process Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(216)))));
            this.label3.Location = new System.Drawing.Point(97, 381);
            this.label3.Margin = new System.Windows.Forms.Padding(5);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(3);
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(119, 31);
            this.label3.TabIndex = 25;
            this.label3.Text = "Process Id";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Ignore_Button
            // 
            this.Ignore_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(216)))));
            this.Ignore_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ignore_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ignore_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ignore_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.Ignore_Button.Location = new System.Drawing.Point(400, 416);
            this.Ignore_Button.Name = "Ignore_Button";
            this.Ignore_Button.Size = new System.Drawing.Size(222, 39);
            this.Ignore_Button.TabIndex = 29;
            this.Ignore_Button.Text = "Ignore Process";
            this.Ignore_Button.UseVisualStyleBackColor = false;
            this.Ignore_Button.Click += new System.EventHandler(this.Suspend_Button_Click);
            // 
            // Suspend_Button
            // 
            this.Suspend_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(216)))));
            this.Suspend_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Suspend_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Suspend_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Suspend_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.Suspend_Button.Location = new System.Drawing.Point(102, 416);
            this.Suspend_Button.Name = "Suspend_Button";
            this.Suspend_Button.Size = new System.Drawing.Size(222, 39);
            this.Suspend_Button.TabIndex = 29;
            this.Suspend_Button.Text = "Suspend Process";
            this.Suspend_Button.UseVisualStyleBackColor = false;
            // 
            // Process_Id
            // 
            this.Process_Id.HeaderText = "Process_Id";
            this.Process_Id.Name = "Process_Id";
            this.Process_Id.ReadOnly = true;
            // 
            // Process_Name
            // 
            this.Process_Name.HeaderText = "Process Name";
            this.Process_Name.Name = "Process_Name";
            this.Process_Name.ReadOnly = true;
            // 
            // Process_Path
            // 
            this.Process_Path.FillWeight = 300F;
            this.Process_Path.HeaderText = "Process Path";
            this.Process_Path.Name = "Process_Path";
            this.Process_Path.ReadOnly = true;
            this.Process_Path.Width = 300;
            // 
            // PCC
            // 
            this.PCC.HeaderText = "PCC";
            this.PCC.Name = "PCC";
            this.PCC.ReadOnly = true;
            // 
            // Action
            // 
            this.Action.HeaderText = "Action";
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(216)))));
            this.label4.Location = new System.Drawing.Point(27, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(5);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(3);
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(190, 31);
            this.label4.TabIndex = 30;
            this.label4.Text = "Time Of Detection";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Time_of_Detection
            // 
            this.Time_of_Detection.AutoSize = true;
            this.Time_of_Detection.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time_of_Detection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(216)))));
            this.Time_of_Detection.Location = new System.Drawing.Point(227, 63);
            this.Time_of_Detection.Margin = new System.Windows.Forms.Padding(5);
            this.Time_of_Detection.Name = "Time_of_Detection";
            this.Time_of_Detection.Padding = new System.Windows.Forms.Padding(3);
            this.Time_of_Detection.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Time_of_Detection.Size = new System.Drawing.Size(190, 31);
            this.Time_of_Detection.TabIndex = 31;
            this.Time_of_Detection.Text = "Time Of Detection";
            this.Time_of_Detection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Threshold_PCC
            // 
            this.Threshold_PCC.AutoSize = true;
            this.Threshold_PCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Threshold_PCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(216)))));
            this.Threshold_PCC.Location = new System.Drawing.Point(627, 63);
            this.Threshold_PCC.Margin = new System.Windows.Forms.Padding(5);
            this.Threshold_PCC.Name = "Threshold_PCC";
            this.Threshold_PCC.Padding = new System.Windows.Forms.Padding(3);
            this.Threshold_PCC.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Threshold_PCC.Size = new System.Drawing.Size(164, 31);
            this.Threshold_PCC.TabIndex = 33;
            this.Threshold_PCC.Text = "Threshold PCC";
            this.Threshold_PCC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(216)))));
            this.label6.Location = new System.Drawing.Point(427, 63);
            this.label6.Margin = new System.Windows.Forms.Padding(5);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(3);
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(164, 31);
            this.label6.TabIndex = 32;
            this.label6.Text = "Threshold PCC";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DetectionResultActionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 494);
            this.Controls.Add(this.Threshold_PCC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Time_of_Detection);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Suspend_Button);
            this.Controls.Add(this.Ignore_Button);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DetectionResultActionForm";
            this.Text = "DetectionResultActionForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
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
    }
}
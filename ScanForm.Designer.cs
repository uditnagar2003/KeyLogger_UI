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
            this.Stop_Button = new System.Windows.Forms.Button();
            this.Start_Button = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Task_Label = new System.Windows.Forms.Label();
            this.Percentage = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Procees_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Process_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bytes_Written = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Stop_Button
            // 
            this.Stop_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(216)))));
            this.Stop_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Stop_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Stop_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stop_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.Stop_Button.Location = new System.Drawing.Point(247, 12);
            this.Stop_Button.Name = "Stop_Button";
            this.Stop_Button.Size = new System.Drawing.Size(170, 39);
            this.Stop_Button.TabIndex = 28;
            this.Stop_Button.Text = "Stop Detection";
            this.Stop_Button.UseVisualStyleBackColor = false;
            // 
            // Start_Button
            // 
            this.Start_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(216)))));
            this.Start_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Start_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.Start_Button.Location = new System.Drawing.Point(47, 12);
            this.Start_Button.Name = "Start_Button";
            this.Start_Button.Size = new System.Drawing.Size(176, 39);
            this.Start_Button.TabIndex = 29;
            this.Start_Button.Text = "Start Detection";
            this.Start_Button.UseVisualStyleBackColor = false;
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(216)))));
            this.progressBar1.Location = new System.Drawing.Point(12, 66);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(748, 23);
            this.progressBar1.TabIndex = 30;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // Task_Label
            // 
            this.Task_Label.AutoSize = true;
            this.Task_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Task_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(216)))));
            this.Task_Label.Location = new System.Drawing.Point(14, 97);
            this.Task_Label.Margin = new System.Windows.Forms.Padding(5);
            this.Task_Label.Name = "Task_Label";
            this.Task_Label.Padding = new System.Windows.Forms.Padding(3);
            this.Task_Label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Task_Label.Size = new System.Drawing.Size(258, 31);
            this.Task_Label.TabIndex = 31;
            this.Task_Label.Text = "Current Task being Done";
            this.Task_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Percentage
            // 
            this.Percentage.AutoSize = true;
            this.Percentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Percentage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(216)))));
            this.Percentage.Location = new System.Drawing.Point(632, 27);
            this.Percentage.Margin = new System.Windows.Forms.Padding(5);
            this.Percentage.Name = "Percentage";
            this.Percentage.Padding = new System.Windows.Forms.Padding(3);
            this.Percentage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Percentage.Size = new System.Drawing.Size(128, 31);
            this.Percentage.TabIndex = 32;
            this.Percentage.Text = "Percentage";
            this.Percentage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Percentage.Click += new System.EventHandler(this.Percentage_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(19, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 302);
            this.panel1.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(304, 136);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(456, 302);
            this.panel2.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(216)))));
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(3);
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(143, 31);
            this.label1.TabIndex = 35;
            this.label1.Text = "Text Inputted";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(216)))));
            this.label2.Location = new System.Drawing.Point(5, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(3);
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(265, 31);
            this.label2.TabIndex = 36;
            this.label2.Text = "Process Being Processed";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(10, 44);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(266, 245);
            this.richTextBox1.TabIndex = 38;
            this.richTextBox1.Text = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Procees_Id,
            this.Process_Name,
            this.Bytes_Written,
            this.PCC});
            this.dataGridView1.Location = new System.Drawing.Point(10, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(443, 255);
            this.dataGridView1.TabIndex = 37;
            // 
            // Procees_Id
            // 
            this.Procees_Id.HeaderText = "Process Id";
            this.Procees_Id.Name = "Procees_Id";
            this.Procees_Id.ReadOnly = true;
            // 
            // Process_Name
            // 
            this.Process_Name.HeaderText = "Process Name";
            this.Process_Name.Name = "Process_Name";
            this.Process_Name.ReadOnly = true;
            // 
            // Bytes_Written
            // 
            this.Bytes_Written.HeaderText = "Bytes Written";
            this.Bytes_Written.Name = "Bytes_Written";
            this.Bytes_Written.ReadOnly = true;
            // 
            // PCC
            // 
            this.PCC.HeaderText = "PCC";
            this.PCC.Name = "PCC";
            this.PCC.ReadOnly = true;
            // 
            // ScanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Percentage);
            this.Controls.Add(this.Task_Label);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Start_Button);
            this.Controls.Add(this.Stop_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScanForm";
            this.Text = "ScanForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Stop_Button;
        private System.Windows.Forms.Button Start_Button;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label Task_Label;
        private System.Windows.Forms.Label Percentage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Procees_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Process_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bytes_Written;
        private System.Windows.Forms.DataGridViewTextBoxColumn PCC;
        private System.Windows.Forms.Label label2;
    }
}
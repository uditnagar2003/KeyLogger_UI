namespace KLDS
{
    partial class Detection_Form
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
            label3 = new Label();
            Algorithm = new ComboBox();
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
            Number_of_Interval = new TextBox();
            DUration_Of_Interval = new TextBox();
            Key_Max = new TextBox();
            Key_Min = new TextBox();
            Save_Button = new Button();
            label4 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Italic);
            label3.ForeColor = Color.White;
            label3.Location = new Point(336, 154);
            label3.Margin = new Padding(6);
            label3.Name = "label3";
            label3.Padding = new Padding(4, 3, 4, 3);
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(148, 27);
            label3.TabIndex = 18;
            label3.Text = "Number of interval";
            label3.TextAlign = ContentAlignment.MiddleLeft;

            // 
            // Algorithm
            // 
            Algorithm.DropDownStyle = ComboBoxStyle.DropDownList;
            Algorithm.FormattingEnabled = true;
            Algorithm.Items.AddRange(new object[] { "Random (RN)", "Impulse (IMP)", "Sine Wave (SIN)" });
            Algorithm.Location = new Point(495, 106);
            Algorithm.Margin = new Padding(4, 3, 4, 3);
            Algorithm.Name = "Algorithm";
            Algorithm.Size = new Size(277, 23);
            Algorithm.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Italic);
            label1.ForeColor = Color.White;
            label1.Location = new Point(293, 206);
            label1.Margin = new Padding(6);
            label1.Name = "label1";
            label1.Padding = new Padding(4, 3, 4, 3);
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(192, 27);
            label1.TabIndex = 20;
            label1.Text = "Duration of interval in ms";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Italic);
            label5.ForeColor = Color.White;
            label5.Location = new Point(286, 250);
            label5.Margin = new Padding(6);
            label5.Name = "label5";
            label5.Padding = new Padding(4, 3, 4, 3);
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(198, 27);
            label5.TabIndex = 21;
            label5.Text = "Max Keystroke Per Interval";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Italic);
            label6.ForeColor = Color.White;
            label6.Location = new Point(289, 297);
            label6.Margin = new Padding(6);
            label6.Name = "label6";
            label6.Padding = new Padding(4, 3, 4, 3);
            label6.RightToLeft = RightToLeft.No;
            label6.Size = new Size(195, 27);
            label6.TabIndex = 22;
            label6.Text = "Min Keystroke Per Interval";
            label6.TextAlign = ContentAlignment.MiddleLeft;
         
            // 
            // Number_of_Interval
            // 
            Number_of_Interval.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Number_of_Interval.Location = new Point(494, 154);
            Number_of_Interval.Margin = new Padding(4, 3, 4, 3);
            Number_of_Interval.Name = "Number_of_Interval";
            Number_of_Interval.Size = new Size(248, 26);
            Number_of_Interval.TabIndex = 23;
            // 
            // DUration_Of_Interval
            // 
            DUration_Of_Interval.Font = new Font("Segoe UI Semilight", 12F);
            DUration_Of_Interval.Location = new Point(494, 204);
            DUration_Of_Interval.Margin = new Padding(4, 3, 4, 3);
            DUration_Of_Interval.Name = "DUration_Of_Interval";
            DUration_Of_Interval.Size = new Size(248, 29);
            DUration_Of_Interval.TabIndex = 24;
            // 
            // Key_Max
            // 
            Key_Max.Font = new Font("Segoe UI Semilight", 12F);
            Key_Max.Location = new Point(495, 248);
            Key_Max.Margin = new Padding(4, 3, 4, 3);
            Key_Max.Name = "Key_Max";
            Key_Max.Size = new Size(247, 29);
            Key_Max.TabIndex = 25;
            // 
            // Key_Min
            // 
            Key_Min.Font = new Font("Segoe UI Semilight", 12F);
            Key_Min.Location = new Point(494, 295);
            Key_Min.Margin = new Padding(4, 3, 4, 3);
            Key_Min.Name = "Key_Min";
            Key_Min.Size = new Size(248, 29);
            Key_Min.TabIndex = 26;
            // 
            // Save_Button
            // 
            Save_Button.BackColor = Color.White;
            Save_Button.Cursor = Cursors.Hand;
            Save_Button.FlatAppearance.BorderColor = Color.White;
            Save_Button.FlatStyle = FlatStyle.Flat;
            Save_Button.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Save_Button.ForeColor = Color.FromArgb(15, 23, 42);
            Save_Button.Location = new Point(494, 345);
            Save_Button.Margin = new Padding(4, 3, 4, 3);
            Save_Button.Name = "Save_Button";
            Save_Button.Size = new Size(145, 45);
            Save_Button.TabIndex = 27;
            Save_Button.Text = "Save";
            Save_Button.UseVisualStyleBackColor = false;
            Save_Button.Click += Save_Button_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Italic);
            label4.ForeColor = Color.White;
            label4.Location = new Point(261, 102);
            label4.Margin = new Padding(6);
            label4.Name = "label4";
            label4.Padding = new Padding(4, 3, 4, 3);
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(223, 27);
            label4.TabIndex = 17;
            label4.Text = "Pattern Generation Algorithm";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(9, 38);
            label7.Margin = new Padding(0);
            label7.Name = "label7";
            label7.Size = new Size(366, 19);
            label7.TabIndex = 29;
            label7.Text = "Set various parameter for keylogger detection core";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.FlatStyle = FlatStyle.Flat;
            label8.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(9, 9);
            label8.Margin = new Padding(0);
            label8.Name = "label8";
            label8.Size = new Size(252, 24);
            label8.TabIndex = 28;
            label8.Text = "Configure Detection Core";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // Detection_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 23, 42);
            ClientSize = new Size(933, 519);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(Save_Button);
            Controls.Add(Key_Min);
            Controls.Add(Key_Max);
            Controls.Add(DUration_Of_Interval);
            Controls.Add(Number_of_Interval);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(Algorithm);
            Controls.Add(label3);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Detection_Form";
            Text = "Detection_Form";
            Load += Detection_Form_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Algorithm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Number_of_Interval;
        private System.Windows.Forms.TextBox DUration_Of_Interval;
        private System.Windows.Forms.TextBox Key_Max;
        private System.Windows.Forms.TextBox Key_Min;
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.Label label4;
        private Label label7;
        private Label label8;
    }
}
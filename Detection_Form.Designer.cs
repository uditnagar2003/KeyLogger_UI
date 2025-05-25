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
            label2 = new Label();
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
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 180, 216);
            label3.Location = new Point(135, 106);
            label3.Margin = new Padding(6);
            label3.Name = "label3";
            label3.Padding = new Padding(4, 3, 4, 3);
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(195, 31);
            label3.TabIndex = 18;
            label3.Text = "Number of interval";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 180, 216);
            label2.Location = new Point(360, 10);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(177, 37);
            label2.TabIndex = 16;
            label2.Text = "Intialization";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // Algorithm
            // 
            Algorithm.DropDownStyle = ComboBoxStyle.DropDownList;
            Algorithm.FormattingEnabled = true;
            Algorithm.Items.AddRange(new object[] { "Random (RN)", "Impulse (IMP)", "Sine Wave (SIN)" });
            Algorithm.Location = new Point(370, 69);
            Algorithm.Margin = new Padding(4, 3, 4, 3);
            Algorithm.Name = "Algorithm";
            Algorithm.Size = new Size(277, 23);
            Algorithm.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 180, 216);
            label1.Location = new Point(62, 153);
            label1.Margin = new Padding(6);
            label1.Name = "label1";
            label1.Padding = new Padding(4, 3, 4, 3);
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(258, 31);
            label1.TabIndex = 20;
            label1.Text = "Duration of interval in ms";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 180, 216);
            label5.Location = new Point(38, 201);
            label5.Margin = new Padding(6);
            label5.Name = "label5";
            label5.Padding = new Padding(4, 3, 4, 3);
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(278, 31);
            label5.TabIndex = 21;
            label5.Text = "Max Keystroke Per Interval";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 180, 216);
            label6.Location = new Point(46, 248);
            label6.Margin = new Padding(6);
            label6.Name = "label6";
            label6.Padding = new Padding(4, 3, 4, 3);
            label6.RightToLeft = RightToLeft.No;
            label6.Size = new Size(272, 31);
            label6.TabIndex = 22;
            label6.Text = "Min Keystroke Per Interval";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            label6.Click += label6_Click;
            // 
            // Number_of_Interval
            // 
            Number_of_Interval.Location = new Point(369, 117);
            Number_of_Interval.Margin = new Padding(4, 3, 4, 3);
            Number_of_Interval.Name = "Number_of_Interval";
            Number_of_Interval.Size = new Size(116, 21);
            Number_of_Interval.TabIndex = 23;
            // 
            // DUration_Of_Interval
            // 
            DUration_Of_Interval.Location = new Point(370, 164);
            DUration_Of_Interval.Margin = new Padding(4, 3, 4, 3);
            DUration_Of_Interval.Name = "DUration_Of_Interval";
            DUration_Of_Interval.Size = new Size(116, 21);
            DUration_Of_Interval.TabIndex = 24;
            // 
            // Key_Max
            // 
            Key_Max.Location = new Point(370, 211);
            Key_Max.Margin = new Padding(4, 3, 4, 3);
            Key_Max.Name = "Key_Max";
            Key_Max.Size = new Size(116, 21);
            Key_Max.TabIndex = 25;
            // 
            // Key_Min
            // 
            Key_Min.Location = new Point(369, 258);
            Key_Min.Margin = new Padding(4, 3, 4, 3);
            Key_Min.Name = "Key_Min";
            Key_Min.Size = new Size(116, 21);
            Key_Min.TabIndex = 26;
            // 
            // Save_Button
            // 
            Save_Button.BackColor = Color.FromArgb(0, 180, 216);
            Save_Button.Cursor = Cursors.Hand;
            Save_Button.FlatStyle = FlatStyle.Flat;
            Save_Button.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Save_Button.ForeColor = Color.FromArgb(202, 240, 248);
            Save_Button.Location = new Point(369, 305);
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
            label4.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 180, 216);
            label4.Location = new Point(16, 59);
            label4.Margin = new Padding(6);
            label4.Name = "label4";
            label4.Padding = new Padding(4, 3, 4, 3);
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(297, 31);
            label4.TabIndex = 17;
            label4.Text = "Pattern Generation Algorithm";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Detection_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
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
            Controls.Add(label2);
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
        private System.Windows.Forms.Label label2;
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
    }
}
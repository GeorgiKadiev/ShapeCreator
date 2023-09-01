namespace WinFormsApp1
{
    partial class LINQMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param Name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            buttonFindByColor = new Button();
            buttonFirst = new Button();
            buttonAcsendingArea = new Button();
            comboBox1 = new ComboBox();
            buttonDescending = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // buttonFindByColor
            // 
            buttonFindByColor.Location = new Point(149, 76);
            buttonFindByColor.Margin = new Padding(4);
            buttonFindByColor.Name = "buttonFindByColor";
            buttonFindByColor.Size = new Size(99, 33);
            buttonFindByColor.TabIndex = 2;
            buttonFindByColor.Text = "Search";
            buttonFindByColor.UseVisualStyleBackColor = true;
            buttonFindByColor.Click += buttonFindByColor_Click;
            // 
            // buttonFirst
            // 
            buttonFirst.Location = new Point(154, 67);
            buttonFirst.Margin = new Padding(4);
            buttonFirst.Name = "buttonFirst";
            buttonFirst.Size = new Size(96, 32);
            buttonFirst.TabIndex = 4;
            buttonFirst.Text = "Get";
            buttonFirst.UseVisualStyleBackColor = true;
            buttonFirst.Click += buttonFirst_Click;
            // 
            // buttonAcsendingArea
            // 
            buttonAcsendingArea.Location = new Point(149, 99);
            buttonAcsendingArea.Margin = new Padding(4);
            buttonAcsendingArea.Name = "buttonAcsendingArea";
            buttonAcsendingArea.Size = new Size(96, 32);
            buttonAcsendingArea.TabIndex = 9;
            buttonAcsendingArea.Text = "Order";
            buttonAcsendingArea.UseVisualStyleBackColor = true;
            buttonAcsendingArea.Click += buttonAcsendingArea_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(33, 36);
            comboBox1.Margin = new Padding(4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(154, 29);
            comboBox1.TabIndex = 11;
            // 
            // buttonDescending
            // 
            buttonDescending.Location = new Point(154, 99);
            buttonDescending.Margin = new Padding(4);
            buttonDescending.Name = "buttonDescending";
            buttonDescending.Size = new Size(96, 32);
            buttonDescending.TabIndex = 12;
            buttonDescending.Text = "Order";
            buttonDescending.UseVisualStyleBackColor = true;
            buttonDescending.Click += buttonDescending_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(33, 33);
            radioButton1.Margin = new Padding(4);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(81, 25);
            radioButton1.TabIndex = 13;
            radioButton1.TabStop = true;
            radioButton1.Text = "By Area";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(33, 57);
            radioButton2.Margin = new Padding(4);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(116, 25);
            radioButton2.TabIndex = 14;
            radioButton2.TabStop = true;
            radioButton2.Text = "By Perimeter";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(32, 33);
            radioButton3.Margin = new Padding(4);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(81, 25);
            radioButton3.TabIndex = 15;
            radioButton3.TabStop = true;
            radioButton3.Text = "By Area";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(32, 57);
            radioButton4.Margin = new Padding(4);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(116, 25);
            radioButton4.TabIndex = 16;
            radioButton4.TabStop = true;
            radioButton4.Text = "By Perimeter";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonFindByColor);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Location = new Point(65, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(268, 123);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Find By Color";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonFirst);
            groupBox2.Location = new Point(416, 21);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(268, 123);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Get First Shape";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(radioButton1);
            groupBox3.Controls.Add(radioButton2);
            groupBox3.Controls.Add(buttonAcsendingArea);
            groupBox3.Location = new Point(65, 164);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(268, 142);
            groupBox3.TabIndex = 19;
            groupBox3.TabStop = false;
            groupBox3.Text = "Order Ascending";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(radioButton3);
            groupBox4.Controls.Add(radioButton4);
            groupBox4.Controls.Add(buttonDescending);
            groupBox4.Location = new Point(416, 164);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(268, 142);
            groupBox4.TabIndex = 20;
            groupBox4.TabStop = false;
            groupBox4.Text = "Order Descending";
            // 
            // LINQMenu
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(102, 194, 179);
            ClientSize = new Size(744, 345);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Black;
            Margin = new Padding(4);
            Name = "LINQMenu";
            Text = "LINQMenu";
            Load += LINQMenu_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button buttonFindByColor;
        private Button button2;
        private Button buttonAcsendingArea;
        private ComboBox comboBox1;
        private Button buttonFirst;
        private Button buttonDescending;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
    }
}
namespace WinFormsApp1.Quadrilaterals
{
    partial class Rectanglee
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            buttonSubmit = new Button();
            label3 = new Label();
            comboBoxChangeColor = new ComboBox();
            groupBox1 = new GroupBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 31);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(55, 21);
            label1.TabIndex = 0;
            label1.Text = "Width:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 66);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(61, 21);
            label2.TabIndex = 1;
            label2.Text = "Lenght:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(136, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 29);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(136, 63);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 29);
            textBox2.TabIndex = 3;
            // 
            // buttonSubmit
            // 
            buttonSubmit.FlatAppearance.BorderSize = 0;
            buttonSubmit.FlatStyle = FlatStyle.Flat;
            buttonSubmit.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSubmit.Location = new Point(100, 226);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(100, 37);
            buttonSubmit.TabIndex = 4;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 101);
            label3.Name = "label3";
            label3.Size = new Size(102, 21);
            label3.TabIndex = 5;
            label3.Text = "Border Color:";
            // 
            // comboBoxChangeColor
            // 
            comboBoxChangeColor.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxChangeColor.FormattingEnabled = true;
            comboBoxChangeColor.Location = new Point(136, 98);
            comboBoxChangeColor.Name = "comboBoxChangeColor";
            comboBoxChangeColor.Size = new Size(100, 29);
            comboBoxChangeColor.TabIndex = 6;
            comboBoxChangeColor.SelectedIndexChanged += comboBoxChangeColor_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBoxChangeColor);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(256, 208);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enter Values";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(136, 168);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 29);
            textBox4.TabIndex = 12;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(136, 133);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 29);
            textBox3.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 171);
            label6.Name = "label6";
            label6.Size = new Size(104, 21);
            label6.TabIndex = 10;
            label6.Text = "Y coordinates";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 136);
            label5.Name = "label5";
            label5.Size = new Size(107, 21);
            label5.TabIndex = 9;
            label5.Text = "X coordinates:";
            // 
            // Rectanglee
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(102, 194, 179);
            ClientSize = new Size(290, 266);
            Controls.Add(groupBox1);
            Controls.Add(buttonSubmit);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Rectanglee";
            Text = "Rectangle";
            Load += Rectanglee_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button buttonSubmit;
        private Label label3;
        private ComboBox comboBoxChangeColor;
        private GroupBox groupBox1;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label6;
        private Label label5;
    }
}
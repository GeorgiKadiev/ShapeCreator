namespace WinFormsApp1.Quadrilaterals
{
    partial class Square
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
            textBox1 = new TextBox();
            buttonSubmit = new Button();
            label2 = new Label();
            comboBoxChangeColor = new ComboBox();
            groupBox1 = new GroupBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(18, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(43, 21);
            label1.TabIndex = 0;
            label1.Text = "Side:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(149, 29);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(127, 29);
            textBox1.TabIndex = 1;
            // 
            // buttonSubmit
            // 
            buttonSubmit.FlatAppearance.BorderSize = 0;
            buttonSubmit.FlatStyle = FlatStyle.Flat;
            buttonSubmit.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSubmit.Location = new Point(116, 187);
            buttonSubmit.Margin = new Padding(4);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(96, 41);
            buttonSubmit.TabIndex = 2;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 68);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(102, 21);
            label2.TabIndex = 3;
            label2.Text = "Border Color:";
            // 
            // comboBoxChangeColor
            // 
            comboBoxChangeColor.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxChangeColor.FormattingEnabled = true;
            comboBoxChangeColor.Location = new Point(149, 65);
            comboBoxChangeColor.Name = "comboBoxChangeColor";
            comboBoxChangeColor.Size = new Size(127, 29);
            comboBoxChangeColor.TabIndex = 4;
            comboBoxChangeColor.SelectedIndexChanged += comboBoxChangeColor_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(comboBoxChangeColor);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(299, 176);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enter Values";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(149, 138);
            textBox3.Margin = new Padding(4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(127, 29);
            textBox3.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(149, 101);
            textBox2.Margin = new Padding(4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(127, 29);
            textBox2.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 141);
            label5.Name = "label5";
            label5.Size = new Size(107, 21);
            label5.TabIndex = 6;
            label5.Text = "Y coordinates:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 104);
            label4.Name = "label4";
            label4.Size = new Size(107, 21);
            label4.TabIndex = 5;
            label4.Text = "X coordinates:";
            // 
            // Square
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(102, 194, 179);
            ClientSize = new Size(328, 227);
            Controls.Add(groupBox1);
            Controls.Add(buttonSubmit);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Square";
            Text = "Square";
            Load += Square_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button buttonSubmit;
        private Label label2;
        private ComboBox comboBoxChangeColor;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private TextBox textBox3;
        private TextBox textBox2;
    }
}
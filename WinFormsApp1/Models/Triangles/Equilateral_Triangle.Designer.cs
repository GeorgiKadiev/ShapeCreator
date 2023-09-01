namespace WinFormsApp1.Triangles
{
    partial class EquilateralTriangle
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
            label4 = new Label();
            textBox1 = new TextBox();
            comboBoxChangeColor = new ComboBox();
            buttonSubmit = new Button();
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
            label1.Location = new Point(21, 31);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(43, 21);
            label1.TabIndex = 0;
            label1.Text = "Side:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 66);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(102, 21);
            label4.TabIndex = 3;
            label4.Text = "Border Color:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(152, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(116, 29);
            textBox1.TabIndex = 4;
            // 
            // comboBoxChangeColor
            // 
            comboBoxChangeColor.FormattingEnabled = true;
            comboBoxChangeColor.Location = new Point(152, 63);
            comboBoxChangeColor.Name = "comboBoxChangeColor";
            comboBoxChangeColor.Size = new Size(116, 29);
            comboBoxChangeColor.TabIndex = 7;
            comboBoxChangeColor.SelectedIndexChanged += comboBoxChangeColor_SelectedIndexChanged;
            // 
            // buttonSubmit
            // 
            buttonSubmit.FlatAppearance.BorderSize = 0;
            buttonSubmit.FlatStyle = FlatStyle.Flat;
            buttonSubmit.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSubmit.Location = new Point(118, 207);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(106, 41);
            buttonSubmit.TabIndex = 8;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(comboBoxChangeColor);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(21, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(289, 179);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enter Values";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(152, 133);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(116, 29);
            textBox4.TabIndex = 11;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(152, 98);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(116, 29);
            textBox3.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 136);
            label6.Name = "label6";
            label6.Size = new Size(107, 21);
            label6.TabIndex = 9;
            label6.Text = "Y coordinates:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 101);
            label5.Name = "label5";
            label5.Size = new Size(107, 21);
            label5.TabIndex = 8;
            label5.Text = "X coordinates:";
            // 
            // EquilateralTriangle
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(102, 194, 179);
            ClientSize = new Size(338, 247);
            Controls.Add(groupBox1);
            Controls.Add(buttonSubmit);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "EquilateralTriangle";
            Text = "EquilateralTriangle";
            Load += Equilateral_Triangle_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label4;
        private TextBox textBox1;
        private ComboBox comboBoxChangeColor;
        private Button buttonSubmit;
        private GroupBox groupBox1;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label6;
        private Label label5;
    }
}
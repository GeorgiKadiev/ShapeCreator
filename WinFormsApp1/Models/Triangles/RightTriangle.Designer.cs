namespace WinFormsApp1.Triangles
{
    partial class RightTriangle
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
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBoxChangeColor = new ComboBox();
            buttonSubmit = new Button();
            groupBox1 = new GroupBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 35);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(57, 21);
            label1.TabIndex = 0;
            label1.Text = "Side A:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 70);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 1;
            label2.Text = "Side B:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 111);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(102, 21);
            label4.TabIndex = 3;
            label4.Text = "Border Color:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(148, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 29);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(148, 63);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(121, 29);
            textBox2.TabIndex = 5;
            // 
            // comboBoxChangeColor
            // 
            comboBoxChangeColor.BackColor = Color.White;
            comboBoxChangeColor.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxChangeColor.FormattingEnabled = true;
            comboBoxChangeColor.Location = new Point(148, 104);
            comboBoxChangeColor.Name = "comboBoxChangeColor";
            comboBoxChangeColor.Size = new Size(121, 29);
            comboBoxChangeColor.TabIndex = 7;
            comboBoxChangeColor.SelectedIndexChanged += comboBoxChangeColor_SelectedIndexChanged;
            // 
            // buttonSubmit
            // 
            buttonSubmit.FlatAppearance.BorderSize = 0;
            buttonSubmit.FlatStyle = FlatStyle.Flat;
            buttonSubmit.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSubmit.Location = new Point(111, 234);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(114, 59);
            buttonSubmit.TabIndex = 8;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(comboBoxChangeColor);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(22, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(286, 217);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enter values";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(148, 174);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(121, 29);
            textBox5.TabIndex = 11;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(148, 139);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(121, 29);
            textBox4.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 177);
            label7.Name = "label7";
            label7.Size = new Size(100, 21);
            label7.TabIndex = 9;
            label7.Text = "Y coordinate:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 141);
            label6.Name = "label6";
            label6.Size = new Size(100, 21);
            label6.TabIndex = 8;
            label6.Text = "X coordinate:";
            // 
            // RightTriangle
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(102, 194, 179);
            ClientSize = new Size(331, 289);
            Controls.Add(groupBox1);
            Controls.Add(buttonSubmit);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4);
            Name = "RightTriangle";
            Text = "RightTriangle";
            Load += Right_Triangle_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBoxChangeColor;
        private Button buttonSubmit;
        private GroupBox groupBox1;
        private Label label7;
        private Label label6;
        private TextBox textBox5;
        private TextBox textBox4;
    }
}
namespace WinFormsApp1.Quadrilaterals
{
    partial class Rombus
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
            label4 = new Label();
            comboBoxChangeColor = new ComboBox();
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
            label1.Location = new Point(19, 31);
            label1.Name = "label1";
            label1.Size = new Size(43, 21);
            label1.TabIndex = 0;
            label1.Text = "Side:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 66);
            label2.Name = "label2";
            label2.Size = new Size(89, 21);
            label2.TabIndex = 1;
            label2.Text = "Diagonal A:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(156, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 29);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(156, 63);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 29);
            textBox2.TabIndex = 4;
            // 
            // buttonSubmit
            // 
            buttonSubmit.FlatAppearance.BorderSize = 0;
            buttonSubmit.FlatStyle = FlatStyle.Flat;
            buttonSubmit.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSubmit.Location = new Point(104, 224);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(98, 36);
            buttonSubmit.TabIndex = 6;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 102);
            label4.Name = "label4";
            label4.Size = new Size(102, 21);
            label4.TabIndex = 7;
            label4.Text = "Border Color:";
            // 
            // comboBoxChangeColor
            // 
            comboBoxChangeColor.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxChangeColor.FormattingEnabled = true;
            comboBoxChangeColor.Location = new Point(156, 99);
            comboBoxChangeColor.Name = "comboBoxChangeColor";
            comboBoxChangeColor.Size = new Size(100, 29);
            comboBoxChangeColor.TabIndex = 8;
            comboBoxChangeColor.SelectedIndexChanged += comboBoxChangeColor_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBoxChangeColor);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(291, 209);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enter Values";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(156, 169);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 29);
            textBox5.TabIndex = 12;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(156, 134);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 29);
            textBox4.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 172);
            label7.Name = "label7";
            label7.Size = new Size(104, 21);
            label7.TabIndex = 10;
            label7.Text = "Y coordinates";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 137);
            label6.Name = "label6";
            label6.Size = new Size(107, 21);
            label6.TabIndex = 9;
            label6.Text = "X coordinates:";
            // 
            // Rombus
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(102, 194, 179);
            ClientSize = new Size(325, 261);
            Controls.Add(groupBox1);
            Controls.Add(buttonSubmit);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Rombus";
            Text = "Rombus";
            Load += Rombus_Load;
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
        private Label label4;
        private ComboBox comboBoxChangeColor;
        private GroupBox groupBox1;
        private Label label7;
        private Label label6;
        private TextBox textBox5;
        private TextBox textBox4;
    }
}
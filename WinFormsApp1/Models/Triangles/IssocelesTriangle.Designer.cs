namespace WinFormsApp1
{
    partial class IssocelesTriangle
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
            label3 = new Label();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            label4 = new Label();
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
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(30, 28);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(97, 21);
            label1.TabIndex = 0;
            label1.Text = "Base Lenght:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(30, 63);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(59, 21);
            label3.TabIndex = 2;
            label3.Text = "Height:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(172, 30);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(127, 29);
            textBox1.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(172, 66);
            textBox3.Margin = new Padding(4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(127, 29);
            textBox3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(30, 100);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(102, 21);
            label4.TabIndex = 7;
            label4.Text = "Border Color:";
            // 
            // comboBoxChangeColor
            // 
            comboBoxChangeColor.FormattingEnabled = true;
            comboBoxChangeColor.Location = new Point(172, 103);
            comboBoxChangeColor.Margin = new Padding(4);
            comboBoxChangeColor.Name = "comboBoxChangeColor";
            comboBoxChangeColor.Size = new Size(127, 29);
            comboBoxChangeColor.TabIndex = 8;
            comboBoxChangeColor.SelectedIndexChanged += comboBoxChangeColor_SelectedIndexChanged;
            // 
            // buttonSubmit
            // 
            buttonSubmit.FlatAppearance.BorderSize = 0;
            buttonSubmit.FlatStyle = FlatStyle.Flat;
            buttonSubmit.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSubmit.Location = new Point(128, 240);
            buttonSubmit.Margin = new Padding(4);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(96, 32);
            buttonSubmit.TabIndex = 9;
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
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(15, 17);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(323, 215);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enter Values";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(172, 174);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(127, 29);
            textBox5.TabIndex = 12;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(172, 139);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(127, 29);
            textBox4.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 177);
            label7.Name = "label7";
            label7.Size = new Size(107, 21);
            label7.TabIndex = 10;
            label7.Text = "Y coordinates:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 139);
            label6.Name = "label6";
            label6.Size = new Size(107, 21);
            label6.TabIndex = 9;
            label6.Text = "X coordinates:";
            // 
            // IssocelesTriangle
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(102, 194, 179);
            ClientSize = new Size(364, 280);
            Controls.Add(groupBox1);
            Controls.Add(buttonSubmit);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "IssocelesTriangle";
            Text = "IssocelesTriangle";
            Load += IssocelesTriangle_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox3;
        private Label label4;
        private ComboBox comboBoxChangeColor;
        private Button buttonSubmit;
        private GroupBox groupBox1;
        private TextBox textBox5;
        private TextBox textBox4;
        private Label label7;
        private Label label6;
    }
}
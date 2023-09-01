namespace WinFormsApp1
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            TriangleButton = new Button();
            QuadraliteralButton = new Button();
            CircleButton = new Button();
            panelSide = new Panel();
            button1 = new Button();
            panel1 = new Panel();
            label1 = new Label();
            buttonRhombs = new Button();
            buttonIssoceles = new Button();
            buttonRectangle = new Button();
            panel3 = new Panel();
            buttonSquare = new Button();
            buttonEquilateral = new Button();
            buttonRight = new Button();
            panelWidth = new Panel();
            buttonSave = new Button();
            buttonLINQ = new Button();
            buttonRedo = new Button();
            buttonUndo = new Button();
            TextBoxPerimeterAnswear = new TextBox();
            TextBoxAreaAnswear = new TextBox();
            panelBoard = new Panel();
            label2 = new Label();
            label3 = new Label();
            panelSide.SuspendLayout();
            panel1.SuspendLayout();
            panelWidth.SuspendLayout();
            SuspendLayout();
            // 
            // TriangleButton
            // 
            TriangleButton.BackColor = Color.FromArgb(19, 122, 127);
            TriangleButton.BackgroundImageLayout = ImageLayout.None;
            TriangleButton.FlatAppearance.BorderSize = 0;
            TriangleButton.FlatStyle = FlatStyle.Flat;
            TriangleButton.Image = (Image)resources.GetObject("TriangleButton.Image");
            TriangleButton.Location = new Point(25, 142);
            TriangleButton.Name = "TriangleButton";
            TriangleButton.Size = new Size(180, 65);
            TriangleButton.TabIndex = 0;
            TriangleButton.UseVisualStyleBackColor = false;
            TriangleButton.Click += button1_Click;
            // 
            // QuadraliteralButton
            // 
            QuadraliteralButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            QuadraliteralButton.BackColor = Color.FromArgb(19, 122, 127);
            QuadraliteralButton.FlatAppearance.BorderSize = 0;
            QuadraliteralButton.FlatStyle = FlatStyle.Flat;
            QuadraliteralButton.Image = (Image)resources.GetObject("QuadraliteralButton.Image");
            QuadraliteralButton.Location = new Point(25, 207);
            QuadraliteralButton.Name = "QuadraliteralButton";
            QuadraliteralButton.Size = new Size(180, 71);
            QuadraliteralButton.TabIndex = 1;
            QuadraliteralButton.UseVisualStyleBackColor = false;
            QuadraliteralButton.Click += QuadraliteralButton_Click;
            // 
            // CircleButton
            // 
            CircleButton.BackColor = Color.FromArgb(19, 122, 127);
            CircleButton.FlatAppearance.BorderSize = 0;
            CircleButton.FlatStyle = FlatStyle.Flat;
            CircleButton.Image = Properties.Resources._14;
            CircleButton.Location = new Point(25, 277);
            CircleButton.Name = "CircleButton";
            CircleButton.Size = new Size(180, 75);
            CircleButton.TabIndex = 2;
            CircleButton.Text = "Circle";
            CircleButton.UseVisualStyleBackColor = false;
            CircleButton.Click += CircleButton_Click;
            // 
            // panelSide
            // 
            panelSide.BackColor = Color.FromArgb(19, 122, 127);
            panelSide.BackgroundImageLayout = ImageLayout.None;
            panelSide.Controls.Add(button1);
            panelSide.Controls.Add(panel1);
            panelSide.Controls.Add(buttonRhombs);
            panelSide.Controls.Add(buttonIssoceles);
            panelSide.Controls.Add(buttonRectangle);
            panelSide.Controls.Add(panel3);
            panelSide.Controls.Add(buttonSquare);
            panelSide.Controls.Add(buttonEquilateral);
            panelSide.Controls.Add(TriangleButton);
            panelSide.Controls.Add(buttonRight);
            panelSide.Controls.Add(QuadraliteralButton);
            panelSide.Controls.Add(CircleButton);
            panelSide.Dock = DockStyle.Left;
            panelSide.Location = new Point(0, 0);
            panelSide.Name = "panelSide";
            panelSide.Size = new Size(246, 733);
            panelSide.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("Franklin Gothic Heavy", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(84, 70, 103);
            button1.Location = new Point(25, 655);
            button1.Name = "button1";
            button1.Size = new Size(180, 51);
            button1.TabIndex = 20;
            button1.Text = "LOAD SHAPES";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(19, 122, 127);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(22, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(195, 119);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(19, 122, 127);
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Franklin Gothic Heavy", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(84, 70, 103);
            label1.Location = new Point(-22, 29);
            label1.Name = "label1";
            label1.Size = new Size(246, 148);
            label1.TabIndex = 0;
            label1.Text = "SHAPE CREATOR";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // buttonRhombs
            // 
            buttonRhombs.FlatAppearance.BorderSize = 0;
            buttonRhombs.FlatStyle = FlatStyle.Flat;
            buttonRhombs.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRhombs.ForeColor = SystemColors.ButtonFace;
            buttonRhombs.Location = new Point(51, 611);
            buttonRhombs.Name = "buttonRhombs";
            buttonRhombs.Size = new Size(124, 30);
            buttonRhombs.TabIndex = 8;
            buttonRhombs.Text = "Rhombus";
            buttonRhombs.UseVisualStyleBackColor = true;
            buttonRhombs.Click += buttonRhombs_Click;
            // 
            // buttonIssoceles
            // 
            buttonIssoceles.FlatAppearance.BorderSize = 0;
            buttonIssoceles.FlatStyle = FlatStyle.Flat;
            buttonIssoceles.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonIssoceles.ForeColor = SystemColors.ButtonFace;
            buttonIssoceles.Location = new Point(37, 459);
            buttonIssoceles.Name = "buttonIssoceles";
            buttonIssoceles.Size = new Size(155, 29);
            buttonIssoceles.TabIndex = 6;
            buttonIssoceles.Text = "Issoceles Triangle";
            buttonIssoceles.UseVisualStyleBackColor = true;
            buttonIssoceles.Click += buttonIssoceles_Click;
            // 
            // buttonRectangle
            // 
            buttonRectangle.FlatAppearance.BorderSize = 0;
            buttonRectangle.FlatStyle = FlatStyle.Flat;
            buttonRectangle.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRectangle.ForeColor = SystemColors.ButtonFace;
            buttonRectangle.Location = new Point(53, 571);
            buttonRectangle.Name = "buttonRectangle";
            buttonRectangle.Size = new Size(122, 30);
            buttonRectangle.TabIndex = 7;
            buttonRectangle.Text = "Rectangle";
            buttonRectangle.UseVisualStyleBackColor = true;
            buttonRectangle.Click += buttonRectangle_Click;
            // 
            // panel3
            // 
            panel3.Location = new Point(246, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1164, 613);
            panel3.TabIndex = 5;
            // 
            // buttonSquare
            // 
            buttonSquare.FlatAppearance.BorderSize = 0;
            buttonSquare.FlatStyle = FlatStyle.Flat;
            buttonSquare.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSquare.ForeColor = SystemColors.ButtonFace;
            buttonSquare.Location = new Point(69, 532);
            buttonSquare.Name = "buttonSquare";
            buttonSquare.Size = new Size(87, 32);
            buttonSquare.TabIndex = 6;
            buttonSquare.Text = "Square";
            buttonSquare.UseVisualStyleBackColor = true;
            buttonSquare.Click += buttonSquare_Click;
            // 
            // buttonEquilateral
            // 
            buttonEquilateral.FlatAppearance.BorderSize = 0;
            buttonEquilateral.FlatStyle = FlatStyle.Flat;
            buttonEquilateral.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEquilateral.ForeColor = SystemColors.ButtonFace;
            buttonEquilateral.Location = new Point(38, 421);
            buttonEquilateral.Name = "buttonEquilateral";
            buttonEquilateral.Size = new Size(155, 31);
            buttonEquilateral.TabIndex = 5;
            buttonEquilateral.Text = "Equilateral Triangle";
            buttonEquilateral.UseVisualStyleBackColor = true;
            buttonEquilateral.Click += buttonEquilateral_Click;
            // 
            // buttonRight
            // 
            buttonRight.FlatAppearance.BorderSize = 0;
            buttonRight.FlatStyle = FlatStyle.Flat;
            buttonRight.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRight.ForeColor = SystemColors.ButtonFace;
            buttonRight.Location = new Point(42, 383);
            buttonRight.Name = "buttonRight";
            buttonRight.Size = new Size(155, 31);
            buttonRight.TabIndex = 5;
            buttonRight.Text = "Right Triangle";
            buttonRight.UseVisualStyleBackColor = true;
            buttonRight.Click += buttonRight_Click;
            // 
            // panelWidth
            // 
            panelWidth.BackColor = Color.FromArgb(81, 67, 99);
            panelWidth.Controls.Add(label3);
            panelWidth.Controls.Add(buttonSave);
            panelWidth.Controls.Add(label2);
            panelWidth.Controls.Add(buttonLINQ);
            panelWidth.Controls.Add(buttonRedo);
            panelWidth.Controls.Add(buttonUndo);
            panelWidth.Controls.Add(TextBoxPerimeterAnswear);
            panelWidth.Controls.Add(TextBoxAreaAnswear);
            panelWidth.Dock = DockStyle.Bottom;
            panelWidth.Location = new Point(246, 610);
            panelWidth.Name = "panelWidth";
            panelWidth.Size = new Size(1164, 123);
            panelWidth.TabIndex = 4;
            // 
            // buttonSave
            // 
            buttonSave.AutoSize = true;
            buttonSave.BackColor = Color.FromArgb(209, 127, 96);
            buttonSave.Cursor = Cursors.Hand;
            buttonSave.FlatAppearance.BorderSize = 0;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Font = new Font("Franklin Gothic Heavy", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSave.ForeColor = SystemColors.ButtonFace;
            buttonSave.Location = new Point(984, 44);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(118, 47);
            buttonSave.TabIndex = 21;
            buttonSave.Text = "SAVE";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonLINQ
            // 
            buttonLINQ.BackColor = Color.FromArgb(201, 116, 110);
            buttonLINQ.FlatAppearance.BorderSize = 0;
            buttonLINQ.FlatStyle = FlatStyle.Flat;
            buttonLINQ.Font = new Font("Franklin Gothic Heavy", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLINQ.ForeColor = Color.White;
            buttonLINQ.Location = new Point(834, 43);
            buttonLINQ.Name = "buttonLINQ";
            buttonLINQ.Size = new Size(118, 48);
            buttonLINQ.TabIndex = 20;
            buttonLINQ.Text = "LINQ";
            buttonLINQ.UseVisualStyleBackColor = false;
            buttonLINQ.Click += buttonLINQ_Click;
            // 
            // buttonRedo
            // 
            buttonRedo.BackColor = Color.FromArgb(201, 116, 110);
            buttonRedo.Cursor = Cursors.Hand;
            buttonRedo.FlatAppearance.BorderSize = 0;
            buttonRedo.FlatStyle = FlatStyle.Flat;
            buttonRedo.Font = new Font("Franklin Gothic Heavy", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRedo.ForeColor = SystemColors.ButtonFace;
            buttonRedo.Location = new Point(685, 43);
            buttonRedo.Name = "buttonRedo";
            buttonRedo.Size = new Size(118, 47);
            buttonRedo.TabIndex = 19;
            buttonRedo.Text = "REDO";
            buttonRedo.UseVisualStyleBackColor = false;
            buttonRedo.Click += buttonRedo_Click;
            // 
            // buttonUndo
            // 
            buttonUndo.AutoSize = true;
            buttonUndo.BackColor = Color.FromArgb(201, 116, 110);
            buttonUndo.Cursor = Cursors.Hand;
            buttonUndo.FlatAppearance.BorderSize = 0;
            buttonUndo.FlatStyle = FlatStyle.Flat;
            buttonUndo.Font = new Font("Franklin Gothic Heavy", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonUndo.ForeColor = SystemColors.ButtonFace;
            buttonUndo.Location = new Point(537, 44);
            buttonUndo.Name = "buttonUndo";
            buttonUndo.Size = new Size(118, 47);
            buttonUndo.TabIndex = 18;
            buttonUndo.Text = "UNDO";
            buttonUndo.UseVisualStyleBackColor = false;
            buttonUndo.Click += buttonUndo_Click;
            // 
            // TextBoxPerimeterAnswear
            // 
            TextBoxPerimeterAnswear.BackColor = Color.FromArgb(224, 224, 224);
            TextBoxPerimeterAnswear.BorderStyle = BorderStyle.None;
            TextBoxPerimeterAnswear.Font = new Font("Franklin Gothic Heavy", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxPerimeterAnswear.ForeColor = SystemColors.ControlDarkDark;
            TextBoxPerimeterAnswear.Location = new Point(328, 59);
            TextBoxPerimeterAnswear.Name = "TextBoxPerimeterAnswear";
            TextBoxPerimeterAnswear.Size = new Size(100, 22);
            TextBoxPerimeterAnswear.TabIndex = 17;
            // 
            // TextBoxAreaAnswear
            // 
            TextBoxAreaAnswear.BackColor = Color.FromArgb(224, 224, 224);
            TextBoxAreaAnswear.BorderStyle = BorderStyle.None;
            TextBoxAreaAnswear.Font = new Font("Franklin Gothic Heavy", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxAreaAnswear.ForeColor = SystemColors.ControlDarkDark;
            TextBoxAreaAnswear.Location = new Point(99, 60);
            TextBoxAreaAnswear.Name = "TextBoxAreaAnswear";
            TextBoxAreaAnswear.Size = new Size(100, 22);
            TextBoxAreaAnswear.TabIndex = 16;
            // 
            // panelBoard
            // 
            panelBoard.BackColor = Color.White;
            panelBoard.Location = new Point(246, 0);
            panelBoard.Name = "panelBoard";
            panelBoard.Size = new Size(1164, 613);
            panelBoard.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Heavy", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(30, 55);
            label2.Name = "label2";
            label2.Size = new Size(63, 26);
            label2.TabIndex = 0;
            label2.Text = "Area:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Heavy", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(206, 55);
            label3.Name = "label3";
            label3.Size = new Size(116, 26);
            label3.TabIndex = 1;
            label3.Text = "Perimeter:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1410, 733);
            Controls.Add(panelBoard);
            Controls.Add(panelWidth);
            Controls.Add(panelSide);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainForm";
            Text = "Shape Creator";
            panelSide.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panelWidth.ResumeLayout(false);
            panelWidth.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button TriangleButton;
        private Button QuadraliteralButton;
        private Button CircleButton;
        private Panel panelSide;
        private Panel panelWidth;
        private Panel panel3;
        private TextBox TextBoxPerimeterAnswear;
        private Button buttonRight;
        private Button buttonIssoceles;
        private Button buttonEquilateral;
        private Button buttonRhombs;
        private Button buttonRectangle;
        private Button buttonSquare;
        public TextBox TextBoxAreaAnswear;
        private Button buttonUndo;
        private Panel panel1;
        private Label label1;
        private Button buttonRedo;
        private Button button1;
        private Button buttonLINQ;
        private Button buttonSave;
        public static Panel panelBoard;
        private Label label3;
        private Label label2;
    }
}
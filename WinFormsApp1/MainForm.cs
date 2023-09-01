using WinFormsApp1.Quadrilaterals;
using WinFormsApp1.Triangles;
using System.Text.Json;
using WinFormsApp1.ActionHistory;
using WinFormsApp1.Data;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {

        private readonly Storage _storage;

        public MainForm(Storage storage)
        {
            _storage = storage;

            InitializeComponent();

            buttonRight.Enabled = false;
            buttonRight.Visible = false;
            buttonEquilateral.Enabled = false;
            buttonEquilateral.Visible = false;
            buttonIssoceles.Enabled = false;
            buttonIssoceles.Visible = false;
            buttonSquare.Enabled = false;
            buttonSquare.Visible = false;
            buttonRectangle.Enabled = false;
            buttonRectangle.Visible = false;
            buttonRhombs.Enabled = false;
            buttonRhombs.Visible = false;
            TextBoxAreaAnswear.Enabled = false;
            TextBoxPerimeterAnswear.Enabled = false;
        }

        public event EventHandler<ActionHistory.UserAction>? ShapeCreated;
        public event EventHandler<ActionHistory.UserAction>? ShapeRemoved;
        public event EventHandler<ActionHistory.UserAction>? BorderColorChanged;
        public event EventHandler<ActionHistory.UserAction>? FillColorChanged;
        public event EventHandler<ActionHistory.UserAction>? UndoButtonClicked;
        public event EventHandler<ActionHistory.UserAction>? RedoButtonClicked;

        public void OnClearPanelBoard(object source, EventArgs e)
        {
            TextBoxAreaAnswear.Text = "";
            TextBoxPerimeterAnswear.Text = "";

            Graphics g = panelBoard.CreateGraphics();
            g.Clear(Color.White);

            _storage!.Shapes.ForEach(s =>
            {
                if (!s.IsDeleted)
                {
                    s.Draw(panelBoard, Constants.ShapeRatio, false);
                    TextBoxAreaAnswear.Text = s.Area.ToString();
                    TextBoxPerimeterAnswear.Text = s.Perimeter.ToString();
                }
            });
            if (_storage.Shapes.Count > 0) _storage.Shapes.FindLast(shape => !shape.IsDeleted)?.Draw(panelBoard, Constants.ShapeRatio, true);
        }


        protected virtual void OnShapeCreated(ActionArgs args)
        {
            if (ShapeCreated != null)
                ShapeCreated(this, new ActionHistory.UserAction(Constants.Actions.CreateShape, args));
        }

        protected virtual void OnShapeRemoved(ActionArgs args)
        {
            if (ShapeRemoved != null)
                ShapeRemoved(this, new ActionHistory.UserAction(Constants.Actions.DeleteShape, args));
        }

        protected virtual void OnBorderColorChanged(ActionArgs args)
        {
            if (BorderColorChanged != null)
                BorderColorChanged(this, new ActionHistory.UserAction(Constants.Actions.ChangeBorderColor, args));
        }

        protected virtual void OnFillColorChanged(ActionArgs args)
        {
            if (FillColorChanged != null)
                FillColorChanged(this, new ActionHistory.UserAction(Constants.Actions.ChangeFillColor, args));
        }

        protected virtual void OnUndoButtonClicked()
        {
            if (UndoButtonClicked != null)
                UndoButtonClicked(this, new ActionHistory.UserAction(Constants.Actions.UndoButtonClicked, null!));
        }

        protected virtual void OnRedoButtonClicked()
        {
            if (RedoButtonClicked != null)
                RedoButtonClicked(this, new ActionHistory.UserAction(Constants.Actions.RedoButtonClicked, null!));
        }


        private void button1_Click(object sender, EventArgs e)
        {
            buttonRight.Enabled = true;
            buttonRight.Visible = true;
            buttonEquilateral.Enabled = true;
            buttonEquilateral.Visible = true;
            buttonIssoceles.Enabled = true;
            buttonIssoceles.Visible = true;
            buttonSquare.Enabled = false;
            buttonSquare.Visible = false;
            buttonRectangle.Enabled = false;
            buttonRectangle.Visible = false;
            buttonRhombs.Enabled = false;
            buttonRhombs.Visible = false;
        }

        private void QuadraliteralButton_Click(object sender, EventArgs e)
        {
            buttonSquare.Enabled = true;
            buttonSquare.Visible = true;
            buttonRectangle.Enabled = true;
            buttonRectangle.Visible = true;
            buttonRhombs.Enabled = true;
            buttonRhombs.Visible = true;
            buttonRight.Enabled = false;
            buttonRight.Visible = false;
            buttonEquilateral.Enabled = false;
            buttonEquilateral.Visible = false;
            buttonIssoceles.Enabled = false;
            buttonIssoceles.Visible = false;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AutomatedEntry();
        }

        private void buttonLINQ_Click(object sender, EventArgs e)
        {
            LINQMenu lINQMenu = new LINQMenu(_storage);
            lINQMenu.Show();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            DataEntry[] arr = _storage.ShapesToData();
            string jsonData = JsonSerializer.Serialize<DataEntry[]>(arr);
            ClassLibrary.FileProcessor.SaveToFile(jsonData);
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            using (RightTriangle rightTriangle = new RightTriangle())
            {
                if (rightTriangle.ShowDialog() == DialogResult.OK)
                {
                    if (_storage!.Shapes.Count > 0) _storage.Shapes.FindLast(shape => !shape.IsDeleted)?.Draw(panelBoard, Constants.ShapeRatio, false);

                    rightTriangle.Draw(panelBoard, Constants.ShapeRatio, true);
                    TextBoxAreaAnswear.Text = rightTriangle.Area.ToString();
                    TextBoxPerimeterAnswear.Text = rightTriangle.Perimeter.ToString();

                    var entry = new DataEntry(rightTriangle.Name, rightTriangle.BorderColor, rightTriangle.X, rightTriangle.Y, rightTriangle.IsDeleted);
                    entry.SideA = rightTriangle.SideA;
                    entry.SideB = rightTriangle.SideB;

                    rightTriangle.DataId = entry.Id;

                    _storage.AddData(entry);
                    _storage.AddShape(rightTriangle);

                    ActionArgs actionArgs = new ActionArgs();
                    actionArgs.id = rightTriangle.Id;
                    OnShapeCreated(actionArgs);
                }
            }

        }

        private void buttonEquilateral_Click(object sender, EventArgs e)
        {
            using (EquilateralTriangle equilateralTriangle = new EquilateralTriangle())
            {
                if (equilateralTriangle.ShowDialog() == DialogResult.OK)
                {
                    if (_storage!.Shapes.Count > 0) _storage.Shapes.FindLast(shape => !shape.IsDeleted)?.Draw(panelBoard, Constants.ShapeRatio, false);

                    equilateralTriangle.Draw(panelBoard, Constants.ShapeRatio, true);
                    TextBoxAreaAnswear.Text = equilateralTriangle.Area.ToString();
                    TextBoxPerimeterAnswear.Text = equilateralTriangle.Perimeter.ToString();

                    var entry = new DataEntry(equilateralTriangle.Name, equilateralTriangle.BorderColor, equilateralTriangle.X, equilateralTriangle.Y, equilateralTriangle.IsDeleted);
                    entry.SideA = equilateralTriangle.SideA;

                    equilateralTriangle.DataId = entry.Id;

                    _storage.AddData(entry);
                    _storage.AddShape(equilateralTriangle);

                    ActionArgs actionArgs = new ActionArgs();
                    actionArgs.id = equilateralTriangle.Id;
                    OnShapeCreated(actionArgs);
                }
            }
        }

        private void buttonIssoceles_Click(object sender, EventArgs e)
        {
            using (var issocelesTriangle = new IssocelesTriangle())
            {
                if (issocelesTriangle.ShowDialog() == DialogResult.OK)
                {
                    if (_storage!.Shapes.Count > 0) _storage.Shapes.FindLast(shape => !shape.IsDeleted)?.Draw(panelBoard, Constants.ShapeRatio, false);

                    issocelesTriangle.Draw(panelBoard, Constants.ShapeRatio, true);
                    TextBoxAreaAnswear.Text = issocelesTriangle.Area.ToString();
                    TextBoxPerimeterAnswear.Text = issocelesTriangle.Perimeter.ToString();

                    var entry = new DataEntry(issocelesTriangle.Name, issocelesTriangle.BorderColor, issocelesTriangle.X, issocelesTriangle.Y, issocelesTriangle.IsDeleted);
                    entry.SideC = issocelesTriangle.BaseLenght;
                    entry.Height = issocelesTriangle.Heightt;

                    issocelesTriangle.DataId = entry.Id;

                    _storage.AddData(entry);
                    _storage.AddShape(issocelesTriangle);

                    ActionArgs actionArgs = new ActionArgs();
                    actionArgs.id = issocelesTriangle.Id;
                    OnShapeCreated(actionArgs);
                }
            }
        }

        private void buttonSquare_Click(object sender, EventArgs e)
        {
            using (var square = new Square())
            {
                if (square.ShowDialog() == DialogResult.OK)
                {
                    if (_storage!.Shapes.Count > 0) _storage.Shapes.FindLast(shape => !shape.IsDeleted)?.Draw(panelBoard, Constants.ShapeRatio, false);

                    square.Draw(panelBoard, Constants.ShapeRatio, true);
                    TextBoxAreaAnswear.Text = square.Area.ToString();
                    TextBoxPerimeterAnswear.Text = square.Perimeter.ToString();

                    var entry = new DataEntry(square.Name, square.BorderColor, square.X, square.Y, square.IsDeleted);
                    entry.SideA = square.Side;

                    square.DataId = entry.Id;

                    _storage.AddData(entry);
                    _storage.AddShape(square);

                    ActionArgs actionArgs = new ActionArgs();
                    actionArgs.id = square.Id;
                    OnShapeCreated(actionArgs);
                }
            }
        }

        private void buttonRectangle_Click(object sender, EventArgs e)
        {
            using (var rectangle = new Rectanglee())
            {
                if (rectangle.ShowDialog() == DialogResult.OK)
                {
                    if (_storage!.Shapes.Count > 0) _storage.Shapes.FindLast(shape => !shape.IsDeleted)?.Draw(panelBoard, Constants.ShapeRatio, false);

                    rectangle.Draw(panelBoard, Constants.ShapeRatio, true);
                    TextBoxAreaAnswear.Text = rectangle.Area.ToString();
                    TextBoxPerimeterAnswear.Text = rectangle.Perimeter.ToString();

                    var entry = new DataEntry(rectangle.Name, rectangle.BorderColor, rectangle.X, rectangle.Y, rectangle.IsDeleted);
                    entry.SideA = rectangle.SideA;
                    entry.SideB = rectangle.SideB;

                    rectangle.DataId = entry.Id;

                    _storage.AddData(entry);
                    _storage.AddShape(rectangle);

                    ActionArgs actionArgs = new ActionArgs();
                    actionArgs.id = rectangle.Id;
                    OnShapeCreated(actionArgs);
                }
            }
        }

        private void buttonRhombs_Click(object sender, EventArgs e)
        {
            using (var rhombus = new Rombus())
            {
                if (rhombus.ShowDialog() == DialogResult.OK)
                {
                    if (_storage!.Shapes.Count > 0) _storage.Shapes.FindLast(shape => !shape.IsDeleted)?.Draw(panelBoard, Constants.ShapeRatio, false);

                    rhombus.Draw(panelBoard, Constants.ShapeRatio, true);
                    TextBoxAreaAnswear.Text = rhombus.Area.ToString();
                    TextBoxPerimeterAnswear.Text = rhombus.Perimeter.ToString();

                    var entry = new DataEntry(rhombus.Name, rhombus.BorderColor, rhombus.X, rhombus.Y, rhombus.IsDeleted);
                    entry.SideA = rhombus.Side;
                    entry.DiagonalA = rhombus.DiagonalA;

                    rhombus.DataId = entry.Id;

                    _storage.AddData(entry);
                    _storage.AddShape(rhombus);

                    ActionArgs actionArgs = new ActionArgs();
                    actionArgs.id = rhombus.Id;
                    OnShapeCreated(actionArgs);
                }
            }
        }
        private void CircleButton_Click(object sender, EventArgs e)
        {
            using (var circle = new Circle())
            {
                if (circle.ShowDialog() == DialogResult.OK)
                {
                    if (_storage!.Shapes.Count > 0) _storage.Shapes.FindLast(shape => !shape.IsDeleted)?.Draw(panelBoard, Constants.ShapeRatio, false);

                    circle.Draw(panelBoard, Constants.ShapeRatio, true);
                    TextBoxAreaAnswear.Text = circle.Area.ToString();
                    TextBoxPerimeterAnswear.Text = circle.Perimeter.ToString();

                    var entry = new DataEntry(circle.Name, circle.BorderColor, circle.X, circle.Y, circle.IsDeleted);
                    entry.Radius = circle.Radius;

                    circle.DataId = entry.Id;

                    _storage.AddData(entry);
                    _storage.AddShape(circle);

                    ActionArgs actionArgs = new ActionArgs();
                    actionArgs.id = circle.Id;
                    OnShapeCreated(actionArgs);
                }
            }
        }

        private void buttonUndo_Click(object sender, EventArgs e)
        {
            OnUndoButtonClicked();
        }

        private void buttonRedo_Click(object sender, EventArgs e)
        {
            OnRedoButtonClicked();
        }


        private void AutomatedEntry()
        {
            List<DataEntry> entryData = new List<DataEntry>();

            var json = ClassLibrary.FileProcessor.ReadFromFile();
            entryData = JsonSerializer.Deserialize<List<DataEntry>>(json)!;

            foreach (var entry in entryData!)
            {
                if (entry.Name == "RightTriangle")
                {
                    RightTriangle rightTriangle = new RightTriangle();
                    rightTriangle.SideA = entry.SideA;
                    rightTriangle.SideB = entry.SideB;
                    rightTriangle.SideC = Math.Sqrt(rightTriangle.SideA * rightTriangle.SideA + rightTriangle.SideB * rightTriangle.SideB);
                    rightTriangle.BorderColor = entry.BorderColor;
                    rightTriangle.X = entry.X;
                    rightTriangle.Y = entry.Y;
                    rightTriangle.Area = rightTriangle.SetArea();
                    rightTriangle.Perimeter = rightTriangle.SetPerimeter();

                    rightTriangle.DataId = entry.Id;


                    if (_storage!.Shapes.Count > 0) _storage.Shapes.FindLast(shape => !shape.IsDeleted)?.Draw(panelBoard, Constants.ShapeRatio, false);

                    rightTriangle.Draw(panelBoard, Constants.ShapeRatio, true);
                    TextBoxAreaAnswear.Text = rightTriangle.Area.ToString();
                    TextBoxPerimeterAnswear.Text = rightTriangle.Perimeter.ToString();
                    Thread.Sleep(30);


                    _storage.AddData(entry);
                    _storage.AddShape(rightTriangle);

                    ActionArgs actionArgs = new ActionArgs();
                    actionArgs.id = rightTriangle.Id;
                    OnShapeCreated(actionArgs);
                }

                if (entry.Name == "IssocelesTriangle")
                {
                    IssocelesTriangle issocelesTriangle = new IssocelesTriangle();
                    issocelesTriangle.BaseLenght = entry.SideC;
                    issocelesTriangle.Heightt = entry.Height;
                    issocelesTriangle.Hip = Math.Sqrt(issocelesTriangle.Heightt * issocelesTriangle.Heightt + (issocelesTriangle.BaseLenght / 2) * (issocelesTriangle.BaseLenght / 2));
                    issocelesTriangle.BorderColor = entry.BorderColor;
                    issocelesTriangle.X = entry.X;
                    issocelesTriangle.Y = entry.Y;
                    issocelesTriangle.Area = issocelesTriangle.SetArea();
                    issocelesTriangle.Perimeter = issocelesTriangle.SetPerimeter();

                    issocelesTriangle.DataId = entry.Id;


                    if (_storage!.Shapes.Count > 0) _storage.Shapes.FindLast(shape => !shape.IsDeleted)?.Draw(panelBoard, Constants.ShapeRatio, false);

                    issocelesTriangle.Draw(panelBoard, Constants.ShapeRatio, true);
                    TextBoxAreaAnswear.Text = issocelesTriangle.Area.ToString();
                    TextBoxPerimeterAnswear.Text = issocelesTriangle.Perimeter.ToString();
                    Thread.Sleep(30);

                    _storage.AddData(entry);
                    _storage.AddShape(issocelesTriangle);

                    ActionArgs actionArgs = new ActionArgs();
                    actionArgs.id = issocelesTriangle.Id;
                    OnShapeCreated(actionArgs);
                }

                if (entry.Name == "EquilateralTriangle")
                {
                    EquilateralTriangle equilateralTriangle = new EquilateralTriangle();
                    equilateralTriangle.SideA = entry.SideA;
                    equilateralTriangle.TriangleHeight = Math.Sqrt(equilateralTriangle.SideA * equilateralTriangle.SideA - (equilateralTriangle.SideA / 2) * (equilateralTriangle.SideA / 2));
                    equilateralTriangle.BorderColor = entry.BorderColor;
                    equilateralTriangle.X = entry.X;
                    equilateralTriangle.Y = entry.Y;
                    equilateralTriangle.Area = equilateralTriangle.SetArea();
                    equilateralTriangle.Perimeter = equilateralTriangle.SetPerimeter();

                    equilateralTriangle.DataId = entry.Id;


                    if (_storage!.Shapes.Count > 0) _storage.Shapes.FindLast(shape => !shape.IsDeleted)?.Draw(panelBoard, Constants.ShapeRatio, false);

                    equilateralTriangle.Draw(panelBoard, Constants.ShapeRatio, true);
                    TextBoxAreaAnswear.Text = equilateralTriangle.Area.ToString();
                    TextBoxPerimeterAnswear.Text = equilateralTriangle.Perimeter.ToString();
                    Thread.Sleep(30);

                    _storage.AddData(entry);
                    _storage.AddShape(equilateralTriangle);

                    ActionArgs actionArgs = new ActionArgs();
                    actionArgs.id = equilateralTriangle.Id;
                    OnShapeCreated(actionArgs);
                }

                if (entry.Name == "Square")
                {
                    Square square = new Square();
                    square.Side = entry.SideA;
                    square.BorderColor = entry.BorderColor;
                    square.X = entry.X;
                    square.Y = entry.Y;
                    square.Area = square.SetArea();
                    square.Perimeter = square.SetPerimeter();

                    square.DataId = entry.Id;

                    if (_storage!.Shapes.Count > 0) _storage.Shapes.FindLast(shape => !shape.IsDeleted)?.Draw(panelBoard, Constants.ShapeRatio, false);

                    square.Draw(panelBoard, Constants.ShapeRatio, true);
                    TextBoxAreaAnswear.Text = square.Area.ToString();
                    TextBoxPerimeterAnswear.Text = square.Perimeter.ToString();
                    Thread.Sleep(30);

                    _storage.AddData(entry);
                    _storage.AddShape(square);

                    ActionArgs actionArgs = new ActionArgs();
                    actionArgs.id = square.Id;
                    OnShapeCreated(actionArgs);
                }

                if (entry.Name == "Rectanglee")
                {
                    Rectanglee rectangle = new Rectanglee();
                    rectangle.SideA = entry.SideA;
                    rectangle.SideB = entry.SideB;
                    rectangle.BorderColor = entry.BorderColor;
                    rectangle.X = entry.X;
                    rectangle.Y = entry.Y;
                    rectangle.Area = rectangle.SetArea();
                    rectangle.Perimeter = rectangle.SetPerimeter();

                    rectangle.DataId = entry.Id;

                    if (_storage!.Shapes.Count > 0) _storage.Shapes.FindLast(shape => !shape.IsDeleted)?.Draw(panelBoard, Constants.ShapeRatio, false);

                    rectangle.Draw(panelBoard, Constants.ShapeRatio, true);
                    TextBoxAreaAnswear.Text = rectangle.Area.ToString();
                    TextBoxPerimeterAnswear.Text = rectangle.Perimeter.ToString();
                    Thread.Sleep(30);

                    _storage.AddData(entry);
                    _storage.AddShape(rectangle);

                    ActionArgs actionArgs = new ActionArgs();
                    actionArgs.id = rectangle.Id;
                    OnShapeCreated(actionArgs);
                }

                if (entry.Name == "Rombus")
                {
                    Rombus rhombus = new Rombus();
                    rhombus.Side = entry.SideA;
                    rhombus.DiagonalA = entry.DiagonalA;
                    rhombus.DiagonalB = Math.Sqrt(rhombus.Side * rhombus.Side - (rhombus.DiagonalA / 2) * (rhombus.DiagonalA / 2)) * 2;
                    rhombus.BorderColor = entry.BorderColor;
                    rhombus.X = entry.X;
                    rhombus.Y = entry.Y;
                    rhombus.Area = rhombus.SetArea();
                    rhombus.Perimeter = rhombus.SetPerimeter();

                    rhombus.DataId = entry.Id;


                    if (_storage!.Shapes.Count > 0) _storage.Shapes.FindLast(shape => !shape.IsDeleted)?.Draw(panelBoard, Constants.ShapeRatio, false);

                    rhombus.Draw(panelBoard, Constants.ShapeRatio, true);
                    TextBoxAreaAnswear.Text = rhombus.Area.ToString();
                    TextBoxPerimeterAnswear.Text = rhombus.Perimeter.ToString();
                    Thread.Sleep(30);

                    _storage.AddData(entry);
                    _storage.AddShape(rhombus);

                    ActionArgs actionArgs = new ActionArgs();
                    actionArgs.id = rhombus.Id;
                    OnShapeCreated(actionArgs);
                }

                if (entry.Name == "Circle")
                {
                    Circle circle = new Circle();
                    circle.Radius = entry.Radius;
                    circle.BorderColor = entry.BorderColor;
                    circle.X = entry.X;
                    circle.Y = entry.Y;
                    circle.Area = circle.SetArea();
                    circle.Perimeter = circle.SetPerimeter();

                    circle.DataId = entry.Id;


                    if (_storage!.Shapes.Count > 0) _storage.Shapes.FindLast(shape => !shape.IsDeleted)?.Draw(panelBoard, Constants.ShapeRatio, false);

                    circle.Draw(panelBoard, Constants.ShapeRatio, true);
                    TextBoxAreaAnswear.Text = circle.Area.ToString();
                    TextBoxPerimeterAnswear.Text = circle.Perimeter.ToString();

                    _storage.AddData(entry);
                    _storage.AddShape(circle);

                    ActionArgs actionArgs = new ActionArgs();
                    actionArgs.id = circle.Id;
                    OnShapeCreated(actionArgs);
                }

            };
        }
    }
}

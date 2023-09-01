using WinFormsApp1.Data;
using WinFormsApp1.Queries;

namespace WinFormsApp1
{
    public partial class LINQMenu : Form
    {

        private readonly Storage _storage;

        public LINQMenu(Storage storage)
        {
            InitializeComponent();
            _storage = storage;
        }


        private void buttonFindByColor_Click(object sender, EventArgs e)
        {
            string color = comboBox1.Text;
            LinQ.findColoredShapes(_storage, color);
        }

        private void LINQMenu_Load(object sender, EventArgs e)
        {
            foreach (var color in Enum.GetValues(typeof(Constants.Colors)))
            {
                comboBox1.Items.Add(color);
                comboBox1.SelectedIndex = 0;
            }
            radioButton1.Checked = true;
            radioButton3.Checked = true;
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            LinQ.firstShapeStats(_storage);
        }

        private void buttonAcsendingArea_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                LinQ.ShapeOrderAcsending(_storage, "Area");
            }
            if (radioButton2.Checked)
            {
                LinQ.ShapeOrderAcsending(_storage, "Perimeter");
            }
        }

        private void buttonDescending_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                LinQ.ShapeOrderDecending(_storage, "Area");
            }
            if (radioButton4.Checked)
            {
                LinQ.ShapeOrderDecending(_storage, "Perimeter");
            }
        }
    }
}

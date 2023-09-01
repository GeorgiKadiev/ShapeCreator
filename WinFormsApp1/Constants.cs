
namespace WinFormsApp1
{
    public class Constants
    {
        public static int ShapeRatio = 10;
        public enum Colors
        { Black, Blue, Red, Green, Yellow, Orange };

        public enum Actions
        { CreateShape, DeleteShape, RestoreShape, ChangeBorderColor, ChangeFillColor, UndoButtonClicked, RedoButtonClicked };

        public enum Events
        { ShapeCreated, ShapeRestored, ShapeRemoved, BorderColorChanged, FillColorChanged }

    }
}

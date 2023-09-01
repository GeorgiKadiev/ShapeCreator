using WinFormsApp1.ActionHistory;

namespace WinFormsApp1.Data
{
    public class Storage
    {
        private List<Models.Shape> _shapes = new List<Models.Shape>();
        private List<DataEntry> _data = new List<DataEntry>();

        public List<Models.Shape> Shapes { get { return _shapes; } }

        public event EventHandler? ClearPanelBoard;

        protected virtual void OnClearPanelBoard()
        {
            if (ClearPanelBoard != null)
                ClearPanelBoard(this, EventArgs.Empty);
        }

        public void OnShapeRemoved(object source, UserAction action)
        {
            RemoveShape(action.ActionArgs.id);
        }

        public void OnShapeRestored(object source, UserAction action)
        {
            RestoreShape(action.ActionArgs.id);
        }

        public void AddShape(Models.Shape shape)
        {
            _shapes.Add(shape);
        }

        public void AddData(DataEntry data)
        {
            _data.Add(data);
        }

        public void RestoreShape(long id)
        {
            Models.Shape shape = GetShapeById(id);
            if (shape == null)
            {
                MessageBox.Show("The existingShapes doesn't exist");
                return;
            }

            shape.IsDeleted = false;

            AddEntry(shape.DataId);

            OnClearPanelBoard();
        }

        public void RemoveShape(long id)
        {
            var shape = GetShapeById(id);
            if (shape == null)
            {
                MessageBox.Show("The existingShapes doesn't exist");
                return;
            }
            shape.IsDeleted = true;

            RemoveEntry(shape.DataId);

            OnClearPanelBoard();
        }
        public void RemoveEntry(long id)
        {
            var data = _data.Find(data => data.Id == id);
            data!.IsDeleted = true;
        }

        public void AddEntry(long id)
        {
            var data = _data.Find(data => data.Id == id);
            data!.IsDeleted = false;
        }

        public Models.Shape GetShapeById(long id)
        {
            return _shapes.Find(shape => shape.Id == id)!;
        }


        public DataEntry[] ShapesToData()
        {
            DataEntry[] existingData = _data.Where(s => !s.IsDeleted).ToArray();
            return existingData;
        }

    }
}

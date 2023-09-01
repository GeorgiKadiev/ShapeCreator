
namespace WinFormsApp1.ActionHistory
{
    public class EventHistory
    {
        private int _currentPosition = -1;
        private List<UserAction> _actions = new List<UserAction>();

        public event EventHandler<UserAction>? HistoryShapeRestored;
        public event EventHandler<UserAction>? HistoryShapeRemoved;

        protected virtual void OnHistoryShapeRestored(ActionArgs args)
        {
            if (HistoryShapeRestored != null)
                HistoryShapeRestored(this, new UserAction(Constants.Actions.RestoreShape, args));
        }

        protected virtual void OnHistoryShapeRemoved(ActionArgs args)
        {
            if (HistoryShapeRemoved != null)
                HistoryShapeRemoved(this, new UserAction(Constants.Actions.DeleteShape, args));
        }



        public void OnShapeCreated(object source, UserAction action)
        {
            AddActionToHistoryList(action);
        }

        public void OnUndoButtonClicked(object source, UserAction action)
        {
            if (_actions.Count == 0 || _currentPosition == -1)
            {
                MessageBox.Show("Nothing to undo.");
                return;
            }

            action.Type = _actions[_currentPosition].Type;
            action.ActionArgs = new ActionArgs();
            action.ActionArgs.id = _actions[_currentPosition].ActionArgs.id;
            UndoLastAction(action);

            _currentPosition -= 1;
        }

        public void OnRedoButtonCicked(object source, UserAction action)
        {
            if (_actions.Count == 0 || _currentPosition == _actions.Count - 1)
            {
                MessageBox.Show("Nothing to redo.");
                return;
            }

            _currentPosition += 1;
            action.Type = _actions[_currentPosition].Type;
            action.ActionArgs = new ActionArgs();
            action.ActionArgs.id = _actions[_currentPosition].ActionArgs.id;

            RedoAction(action);

        }

        public void UndoLastAction(UserAction action)
        {

            if (action.Type == Constants.Actions.CreateShape)
                OnHistoryShapeRemoved(action.ActionArgs);
        }

        public void RedoAction(UserAction action)
        {

            if (action.Type == Constants.Actions.CreateShape)
                OnHistoryShapeRestored(action.ActionArgs);
        }

        protected void AddActionToHistoryList(UserAction action)
        {
            _actions.RemoveRange(_currentPosition + 1, _actions.Count - _currentPosition - 1);
            _actions.Add(action);
            _currentPosition = _actions.Count - 1;
        }
    }
}

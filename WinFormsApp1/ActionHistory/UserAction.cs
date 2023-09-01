
namespace WinFormsApp1.ActionHistory
{
    public class UserAction
    {
        private Constants.Actions _type;
        private ActionArgs _actionArgs;

        public UserAction(Constants.Actions type, ActionArgs args)
        {
            _type = type;
            _actionArgs = args;
        }

        public Constants.Actions Type { get => _type; set => _type = value; }
        public ActionArgs ActionArgs { get => _actionArgs; set => _actionArgs = value; }
    }
}

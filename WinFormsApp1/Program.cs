#pragma warning disable CS8622
using WinFormsApp1.ActionHistory;
using WinFormsApp1.Data;

namespace WinFormsApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();


            EventHistory eventHistory = new EventHistory();
            Storage storage = new Storage();
            MainForm mainForm = new MainForm(storage);

            storage.ClearPanelBoard += mainForm.OnClearPanelBoard;
            eventHistory.HistoryShapeRemoved += storage.OnShapeRemoved;
            eventHistory.HistoryShapeRestored += storage.OnShapeRestored;
            mainForm.ShapeCreated += eventHistory.OnShapeCreated;
            mainForm.UndoButtonClicked += eventHistory.OnUndoButtonClicked;
            mainForm.RedoButtonClicked += eventHistory.OnRedoButtonCicked;
            
            Application.Run(mainForm);
        }
    }
}
#pragma warning restore CS8622
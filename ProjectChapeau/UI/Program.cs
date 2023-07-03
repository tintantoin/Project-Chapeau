using ProjectChapeau.ChapeauUI;

namespace UI
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
            //Application.Run(FormChanger.GetFormChanger());           
            //Application.Run(new ServeerderUI());
            FormChanger formChanger = FormChanger.GetFormChanger();
            formChanger.StartApplication();
            //Application.Run(new paymenttable());
        }
    }
}
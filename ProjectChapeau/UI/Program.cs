using Model;

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
            Personeel personeel = new Personeel();
            personeel.functie = FunctieType.BarPersoneel;
            ItemBereidersUI ui = new ItemBereidersUI(personeel);
            //Application.Run(TafelOverzicht.GetInstance());           
            Application.Run(ui);

        }
    }
}

namespace database
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //ApplicationConfiguration.Initialize();
            //Application.Run(new jineng());
            //Application.Run(new characters());
            //Application.Run(new activity());
            Application.Run(new login());

        }
    }
}
using Gym_Management_system.Database;

namespace Gym_Management_system
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
            //Application.Run(new LoginForm());

            Application.Run(new MainForm());
            //Application.Run(new AddPlanForm());
            //Application.Run(new EditPlanForm());
        }
    }
}
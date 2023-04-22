using mini选课习题;
using mini选课习题.Calculater;
using mini选课习题.Shopping;

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
            switch ( 2 )
            {
                case 0 : Application.Run(new SimpleSelect());
                    break;
                case 1 : Application.Run(new StudenteRgister());
                    break;
                case 2: Application.Run(new Calculate());
                    break;
                case 3:Application.Run(new Shpooing());
                    break;
        }


        }
    }
}
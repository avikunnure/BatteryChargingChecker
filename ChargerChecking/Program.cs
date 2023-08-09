using Microsoft.Extensions.Configuration;
using Microsoft.Win32;
using System.Configuration;

namespace ChargerChecking
{
    internal static class Program
    {
       
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

          

            ApplicationConfiguration.Initialize();
            Application.Run(new ChargerCheck());
        }

        
    }
}
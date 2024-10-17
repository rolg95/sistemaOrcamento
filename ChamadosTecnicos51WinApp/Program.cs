using Forms.Login;
using System.Configuration;

namespace Forms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            // Para personalizar a configura��o da aplica��o, como definir configura��es de DPI alto ou fonte padr�o,
            // veja https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Executa o formul�rio principal
            Application.Run(new FormPrincipal());
    }
    }
}
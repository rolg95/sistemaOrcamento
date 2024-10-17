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

            // Para personalizar a configuração da aplicação, como definir configurações de DPI alto ou fonte padrão,
            // veja https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Executa o formulário principal
            Application.Run(new FormPrincipal());
    }
    }
}
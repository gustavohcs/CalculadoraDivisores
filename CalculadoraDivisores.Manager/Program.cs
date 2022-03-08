using System;
using System.Linq;
using System.Diagnostics;
using System.Windows.Forms;
using CalculadoraDivisores.Infra.IoC;

namespace CalculadoraDivisores.Manager
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (ValidateProgramInstance())
                return;

            ServiceRegister.Register();


            StartApplication();
        }

        private static bool ValidateProgramInstance()
        {
            var currentProcess = Process.GetCurrentProcess();
            var processes = Process.GetProcesses()
                .Where(w => w.ProcessName == currentProcess.ProcessName && w.MainModule.FileName.Equals(Process.GetCurrentProcess().MainModule.FileName));
            if (processes.Count() > 1)
            {
                MessageBox.Show("Já existe uma instância do aplicativo \"WindowsForms\" em execução.");
                return true;
            }
            return false;
        }

        private static void StartApplication()
        {
            try
            {
                Application.SetHighDpiMode(HighDpiMode.SystemAware);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                using (var mainForm = new MainForm()) 
                {
                    mainForm.StartPosition = FormStartPosition.CenterScreen;
                    Application.Run(mainForm);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"O aplicativo se comportou de maneira inesperada e foi fechado. Erro: {ex.Message}");
            }
        }
    }
}

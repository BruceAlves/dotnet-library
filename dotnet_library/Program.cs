using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnet_library
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new Cadastro_Usuario());
            //Application.Run(new LivrosEmprestadosUsuario());
            Application.Run(new Login());
            Application.Run(new TelaLivrosEmprestados());

            Application.Run(new Tela_Finalizar_Emprestimos());

        }
    }
}

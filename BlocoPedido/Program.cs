using System;
using System.Windows.Forms;
using BlocoPedido.Data;

namespace BlocoPedido
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            GerenciadorDados.CarregaDadosArquivos();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmPrincipal());
        }
    }
}

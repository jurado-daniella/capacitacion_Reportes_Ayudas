using System;
using System.Windows.Forms;

namespace Ejecucion_BodegaCRUD
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CapaVista_BodegaCRUD.Formas.FrmBodega());
        }
    }
}

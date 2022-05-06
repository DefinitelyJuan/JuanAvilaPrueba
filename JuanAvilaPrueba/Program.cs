using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuanAvilaPrueba
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Properties.Settings.Default["JuanAvilaPruebaConnectionString"] = ConfigurationManager.ConnectionStrings["cn"].ToString();
            Application.Run(new frmMenu());
        }
    }
}

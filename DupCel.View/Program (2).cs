using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DupCel.View
{
   static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmLogin Sistema = new frmLogin();
            Sistema.ShowDialog();

            if (Sistema.logado)
            {
                Application.Run(new frmPrincipal());
            }



           
        }
    }
}

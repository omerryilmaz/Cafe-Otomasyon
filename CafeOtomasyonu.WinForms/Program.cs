using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeOtomasyonu.Entities.Models;
using CafeOtomasyonu.Entities.Tools;
using CafeOtomasyonu.WinForms.AnaMenu;

namespace CafeOtomasyonu.WinForms
{
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ConnectionTools.BaglantiKontrol();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
           

            Application.Run(new frmAnaMenu());
        }
    }
}

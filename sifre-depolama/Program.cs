using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sifre_depolama
{
    static class Program
    {

        [STAThread]
        static void Main()
        {


            CLS.SQLConnectionClass.Baglanti();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}

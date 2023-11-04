using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace O_Amor_Vive___Semana_do_Calvário_2022
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmPrincipalCoplan()); //("C://Users//Tecno Space//Music//Repertório 2022//Faro1.mp3", "Farol Cíntia Alves"));
        }
    }
}

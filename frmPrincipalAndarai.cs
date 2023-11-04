using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace O_Amor_Vive___Semana_do_Calvário_2022
{
    public partial class frmPrincipalAndarai : Form
    {
        public frmPrincipalAndarai()
        {
            InitializeComponent();
        }

        private void frmPrincipalAndarai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                Application.Exit();
            }
        }
    }
}

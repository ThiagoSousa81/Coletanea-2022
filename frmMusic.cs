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
    public partial class frmMusic : Form
    {
        string URL, Nome;
        public frmMusic(string url, string nome)
        {
            InitializeComponent();
            this.URL = url;
            this.Nome = nome;
        }

        private void axWindowsMediaPlayer1_KeyPressEvent(object sender, AxWMPLib._WMPOCXEvents_KeyPressEvent e)
        {
            if (e.nKeyAscii == Convert.ToChar(Keys.Escape))
            {
                this.Close();
            }
        }
        
        private void axWindowsMediaPlayer1_EndOfStream(object sender, AxWMPLib._WMPOCXEvents_EndOfStreamEvent e)
        {
            this.Close();
        }

        private void frmMusic_FormClosing(object sender, FormClosingEventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();            
        }

        private void frmMusic_Load(object sender, EventArgs e)
        {
            this.Text = "Semana do Calvário 2022 - " + Nome;
            axWindowsMediaPlayer1.URL = URL;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
    }
}

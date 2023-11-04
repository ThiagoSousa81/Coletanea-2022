using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Xml;
namespace O_Amor_Vive___Semana_do_Calvário_2022
{
    public partial class frmPrincipalCoplan : Form
    {/*
        public string abrirXML()
        {
            using (XmlReader reader = XmlReader.Create("C://Program Files//Semana do Calvário 2022//Musicas.xml"))
            {
                reader.
            }
                return "";
        }*/
        public frmPrincipalCoplan()
        {
            InitializeComponent();
        }
        int VisiblePanel = 1;
        private void ShowPn1()
        {
            lblOAmorVive.Visible = true;
            lblAoPeDacruz.Visible = true;
            lblAoOlharPraCruz.Visible = true;
            lblMaiorQueTudo.Visible = true;
            lblLevantoACruz.Visible = true;
            lblOpoderDoAmor.Visible = true;
            lblNaoMaisEu.Visible = true;
            lblPorqueEleVive.Visible = true;
            lblAmorEscritoComSangue.Visible = true;
            lblResgateDeAmor.Visible = true;
        }
        private void HidePn1()
        {
            lblOAmorVive.Visible = false;
            lblAoPeDacruz.Visible = false;
            lblAoOlharPraCruz.Visible = false;
            lblMaiorQueTudo.Visible = false;
            lblLevantoACruz.Visible = false;
            lblOpoderDoAmor.Visible = false;
            lblNaoMaisEu.Visible = false;
            lblPorqueEleVive.Visible = false;
            lblAmorEscritoComSangue.Visible = false;
            lblResgateDeAmor.Visible = false;
        }

        private void ShowPn2()
        {
            lblMensagemDacruz.Visible = true;
            lblDignoEOCordeiro.Visible = true;
            lblTomaOMeuCoracao.Visible = true;
            lblTeuSantoNome.Visible = true;
            lblAdoralo.Visible = true;
            lblEmTi.Visible = true;
            lblEleViveEmMim.Visible = true;
            lblDignoDeLor.Visible = true;
            lblEraParaSerEu.Visible = true;
            lblTomouMeuLugar.Visible = true;
        }
        private void HidePn2()
        {
            lblMensagemDacruz.Visible = false;
            lblDignoEOCordeiro.Visible = false;
            lblTomaOMeuCoracao.Visible = false;
            lblTeuSantoNome.Visible = false;
            lblAdoralo.Visible = false;
            lblEmTi.Visible = false;
            lblEleViveEmMim.Visible = false;
            lblDignoDeLor.Visible = false;
            lblEraParaSerEu.Visible = false;
            lblTomouMeuLugar.Visible = false;
        }
        private void frmPrincipal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                Application.Exit();
            }
        }

        private void btnAvance_Click(object sender, EventArgs e)
        {
            if (VisiblePanel == 1)
            {
                HidePn1();
                ShowPn2();
                VisiblePanel = 2;
                btnBack.Visible = true;
                btnAvance.Visible = false;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (VisiblePanel == 2)
            {
                HidePn2();
                ShowPn1();
                VisiblePanel = 1;
                btnBack.Visible = false;
                btnAvance.Visible = true;
            }
        }

        private void frmPrincipalCoplan_Load(object sender, EventArgs e)
        {
            
        }

        private void lblEleViveEmMim_Click(object sender, EventArgs e)
        {
            frmMusic Play = new frmMusic("C://Program Files//Semana Santa 2022//Musicas//ELE VIVE EM MIM.mp4", "Ele vive em mim");
            Play.ShowDialog();
        }

        private void lblDignoDeLor_Click(object sender, EventArgs e)
        {
            frmMusic Play = new frmMusic("C://Program Files//Semana Santa 2022//Musicas//DIGNO DE LOUVOR.mp4", "Digno de louvor");
            Play.ShowDialog();
        }

        private void lblTomaOMeuCoracao_Click(object sender, EventArgs e)
        {
            frmMusic Play = new frmMusic("C://Program Files//Semana Santa 2022//Musicas//TOMA O MEU CORACAO.mp4", "Toma o meu coração");
            Play.ShowDialog();
        }

        private void lblEmTi_Click(object sender, EventArgs e)
        {
            frmMusic Play = new frmMusic("C://Program Files//Semana Santa 2022//Musicas//EM TI.mp4", "Em Ti");
            Play.ShowDialog();
        }

        private void lblAdoralo_Click(object sender, EventArgs e)
        {
            frmMusic Play = new frmMusic("C://Program Files//Semana Santa 2022//Musicas//ADORA LO.mp4", "Adorá-Lo");
            Play.ShowDialog();
        }

        private void lblTeuSantoNome_Click(object sender, EventArgs e)
        {
            frmMusic Play = new frmMusic("C://Program Files//Semana Santa 2022//Musicas//TEU SANTO NOME.mp4", "Teu santo nome");
            Play.ShowDialog();
        }

        private void lblEraParaSerEu_Click(object sender, EventArgs e)
        {
            frmMusic Play = new frmMusic("C://Program Files//Semana Santa 2022//Musicas//ERA PARA SER EU.mp4", "Era para ser eu");
            Play.ShowDialog();
        }

        private void lblDignoEOCordeiro_Click(object sender, EventArgs e)
        {
            frmMusic Play = new frmMusic("C://Program Files//Semana Santa 2022//Musicas//DIGNO E O CORDEIRO.mp4", "Digno é o Cordeiro");
            Play.ShowDialog();
        }

        private void lblMensagemDacruz_Click(object sender, EventArgs e)
        {
            frmMusic Play = new frmMusic("C://Program Files//Semana Santa 2022//Musicas//MENSAGEM DA CRUZ.mp4", "Mensagem da Cruz");
            Play.ShowDialog();
        }

        private void lblTomouMeuLugar_Click(object sender, EventArgs e)
        {
            frmMusic Play = new frmMusic("C://Program Files//Semana Santa 2022//Musicas//TOMOU O MEU LUGAR.mp4", "Tomou o meu lugar");
            Play.ShowDialog();
        }

        private void lblOAmorVive_Click(object sender, EventArgs e)
        {
            frmMusic Play = new frmMusic("C://Program Files//Semana Santa 2022//Musicas//O AMOR VIVE.mp4", "O amor vive");
            Play.ShowDialog();
        }

        private void lblMaiorQueTudo_Click(object sender, EventArgs e)
        {
            frmMusic Play = new frmMusic("C://Program Files//Semana Santa 2022//Musicas//MAIOR QUE TUDO.mp4", "Maior que tudo");
            Play.ShowDialog();
        }

        private void lblLevantoACruz_Click(object sender, EventArgs e)
        {
            frmMusic Play = new frmMusic("C://Program Files//Semana Santa 2022//Musicas//LEVANTO A CRUZ.mp4", "Levanto a Cruz");
            Play.ShowDialog();
        }

        private void lblAoOlharPraCruz_Click(object sender, EventArgs e)
        {
            frmMusic Play = new frmMusic("C://Program Files//Semana Santa 2022//Musicas//AO OLHAR PRA CRUZ.mp4", "Ao olhar pra cruz");
            Play.ShowDialog();
        }

        private void lblAoPeDacruz_Click(object sender, EventArgs e)
        {
            frmMusic Play = new frmMusic("C://Program Files//Semana Santa 2022//Musicas//AO PE DA CRUZ.mp4", "Ao pé da Cruz");
            Play.ShowDialog();
        }

        private void lblResgateDeAmor_Click(object sender, EventArgs e)
        {
            frmMusic Play = new frmMusic("C://Program Files//Semana Santa 2022//Musicas//RESGATE DE AMOR.mp4", "Resgate de Amor");
            Play.ShowDialog();
        }

        private void lblAmorEscritoComSangue_Click(object sender, EventArgs e)
        {
            frmMusic Play = new frmMusic("C://Program Files//Semana Santa 2022//Musicas//AMOR ESCRITO COM SANGUE.mp4", "Amor escrito com sangue");
            Play.ShowDialog();
        }

        private void lblPorqueEleVive_Click(object sender, EventArgs e)
        {
            frmMusic Play = new frmMusic("C://Program Files//Semana Santa 2022//Musicas//PORQUE ELE VIVE.mp4", "Porque Ele vive");
            Play.ShowDialog();
        }

        private void lblNaoMaisEu_Click(object sender, EventArgs e)
        {
            frmMusic Play = new frmMusic("C://Program Files//Semana Santa 2022//Musicas//NAO MAIS EU.mp4", "Não mais eu");
            Play.ShowDialog();
        }

        private void lblOpoderDoAmor_Click(object sender, EventArgs e)
        {
            frmMusic Play = new frmMusic("C://Program Files//Semana Santa 2022//Musicas//O PODER DO AMOR.mp4", "O poder do Amor");
            Play.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            object sender2 = null;
            EventArgs e2 = null;
            lblOAmorVive_Click(sender2, e2);
        }
    }
}

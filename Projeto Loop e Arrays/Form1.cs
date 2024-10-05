using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Loop_e_Arrays
{
    public partial class Frm_Abertura : Form
    {
        public Frm_Abertura()
        {
            InitializeComponent();
        }

        private void Frm_Abertura_Load(object sender, EventArgs e)
        {
            Wmp_Video.URL = ""; //Buscando o Vídeo
            Wmp_Video.uiMode = "None"; //Tirando os Controles do Vídeo
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start(); //Iniciando o Tempo
            timer1.Stop(); //Parar o Tempo
            Frm_Tela2 tela2 = new Frm_Tela2(); //Instanciando o objeto tela2
            tela2.Show();
            Hide();
        }

        private void Wmp_Video_Enter(object sender, EventArgs e)
        {

        }

        private void Lbl_Titulo_Click(object sender, EventArgs e)
        {

        }
    }
}

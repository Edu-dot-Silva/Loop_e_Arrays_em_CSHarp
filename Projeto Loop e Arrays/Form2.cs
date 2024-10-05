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
    public partial class Frm_Tela2 : Form
    {
        public Frm_Tela2()
        {
            InitializeComponent();
        }

        private void Rad_Exemplos_CheckedChanged(object sender, EventArgs e)
        {
            Frm_Tela3 tela3 = new Frm_Tela3();
            tela3.Show();
            Hide();
        }

        private void Rad_Contagens_CheckedChanged(object sender, EventArgs e)
        {
            frm_contagem tela4 = new frm_contagem();
            tela4.Show();  
            Hide();
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            frm_vetores tela5 = new frm_vetores();
            tela5.Show();
            Hide();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void rad_Arrays_CheckedChanged(object sender, EventArgs e)
        {
            frm_matriz tela6 = new frm_matriz();
            tela6.Show();  
            Hide(); 
        }

        private void Frm_Tela2_Load(object sender, EventArgs e)
        {

        }

        private void rad_Atividades_CheckedChanged(object sender, EventArgs e)
        {
            frm_lacos tela7 = new frm_lacos();
            tela7.Show();
            Hide();
        }
    }
}

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
    public partial class frm_lacos : Form
    {
        public frm_lacos()
        {
            InitializeComponent();
        }

        private void lbl_vet_com_laco_Click(object sender, EventArgs e)
        {

        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Frm_Tela2 tela2 = new Frm_Tela2();
            tela2.Show();
            Hide();
        }
    }
}

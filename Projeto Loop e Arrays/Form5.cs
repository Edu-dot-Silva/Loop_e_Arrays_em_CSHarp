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
    public partial class frm_vetores : Form
    {
        public frm_vetores()
        {
            InitializeComponent();
        }

        private void lbl_vetores_Click(object sender, EventArgs e)
        {

        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Frm_Tela2 tela2 = new Frm_Tela2();
            tela2.Show();
            Hide();
        }

        private void frm_vetores_Load(object sender, EventArgs e)
        {
            int[] vetor1 = { 1,2,3,4,5}; //declaração de vetor com 5 elementos
            lst_vetor1.Items.Add("Vetor 1 - Na posicao 1 = " + vetor1[0]);
            lst_vetor1.Items.Add("Vetor 1 - Na posicao 2 = " + vetor1[1]);
            lst_vetor1.Items.Add("Vetor 1 - Na posicao 3 = " + vetor1[2]);
            lst_vetor1.Items.Add("Vetor 1 - Na posicao 4 = " + vetor1[3]);
            lst_vetor1.Items.Add("Vetor 1 - Na posicao 5 = " + vetor1[4]);

            int[] vetor2 = { 70,60,40,30,20,10,05};
            lst_vetor2.Items.Clear();

            for (int i = 0; i<= 6; i++)
            {
                lst_vetor2.Items.Add("Vetor 2 - [" + i +"] = " + vetor2[i]);
            }

            int[] vetor3 = new int[3];
            lst_vetor3.Items.Add(vetor3[0] = 15);
            lst_vetor3.Items.Add(vetor3[1] = 30); 
            lst_vetor3.Items.Add(vetor3[2] = 45);

            int[] vetor4 = new int[3] {88, 8 ,98};
            lst_vetor4.Items.Clear();
            for (int i = 0; i < vetor4.Length; i++)
            {
                lst_vetor4.Items.Add(vetor4[i]);
            }
        }
    }
}

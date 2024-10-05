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
    public partial class frm_matriz : Form
    {
        public frm_matriz()
        {
            InitializeComponent();
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            Frm_Abertura tela2 = new Frm_Abertura();
            tela2.Show();
            Hide();
        }

        private void frm_matriz_Load(object sender, EventArgs e)
        {
            int[,] matriz1 = { { 1 , 2 } , { 3 , 4} , { 5 , 6 } , { 7 , 8 } , { 9, 10 } }; //matriz com 5 elementos

            lst_matriz1.Items.Add("Matriz1 [0,0] = " + matriz1[0,0]); //mostrando cada elemento da matriz
            lst_matriz1.Items.Add("Matriz1 [0,1] = " + matriz1[0,1]); 
            lst_matriz1.Items.Add("Matriz1 [1,0] = " + matriz1[1,0]); 
            lst_matriz1.Items.Add("Matriz1 [1,1] = " + matriz1[1,1]);  
            lst_matriz1.Items.Add("Matriz1 [2,0] = " + matriz1[2,0]);  
            lst_matriz1.Items.Add("Matriz1 [2,1] = " + matriz1[2,1]);  
            lst_matriz1.Items.Add("Matriz1 [3,0] = " + matriz1[3,0]);  
            lst_matriz1.Items.Add("Matriz1 [3,1] = " + matriz1[3,1]);  
            lst_matriz1.Items.Add("Matriz1 [4,0] = " + matriz1[4,0]);  
            lst_matriz1.Items.Add("Matriz1 [4,1] = " + matriz1[4,1]);



            String[,] matriz2 = { { " S "}, { " E " }, { " N " }, { " A " }, { " C " } };
            lst_matriz2.Items.Add(matriz2[0,0]);
            lst_matriz2.Items.Add(matriz2[1,0]);
            lst_matriz2.Items.Add(matriz2[2,0]);
            lst_matriz2.Items.Add(matriz2[3,0]);
            lst_matriz2.Items.Add(matriz2[4,0]);

            //outro jeito de fazer
            String[,] matriz3 = new String[ 1 , 5 ]; //para palavra senac uma linha e 5 colunas que vao de 0 a 4 

            lst_matriz2.Items.Add(matriz3[0, 0] = "S");
            lst_matriz2.Items.Add(matriz3[0, 1] = "E");
            lst_matriz2.Items.Add(matriz3[0, 2] = "N");
            lst_matriz2.Items.Add(matriz3[0, 3] = "A");
            lst_matriz2.Items.Add(matriz3[0, 4] = "C");

        }
    }
}

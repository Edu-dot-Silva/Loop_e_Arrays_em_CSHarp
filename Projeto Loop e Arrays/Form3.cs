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
    public partial class Frm_Tela3 : Form
    {
        public Frm_Tela3()
        {
            InitializeComponent();
        }

        int numero, contador; //Declarando as variáveis

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            Frm_Tela2 tela2 = new Frm_Tela2();
            tela2.Show();
            Hide();
        }

        private void Chk_For_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_For.Checked) //Se a opção for selecionada
            {
                Grp_Tabuada1.Visible = true; //Mostrando a Tabuada 1
            }
            else //Se for desmarcada a opção
            { 
                Grp_Tabuada1.Visible = false; //Não Mostrar a Tabuada 1
            }

        }

        private void Txt_Numero1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Somente Números!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (e.KeyChar == 13) //Se pressionar a tecla ENTER
            {
                if (Txt_Numero1.Text != "") //Se for digitado o número
                {
                    numero=int.Parse(Txt_Numero1.Text); //A variável está recebendo o número digitado

                    List_Tabuada1.Items.Clear(); //Limpar os itens da Lista

                    for (contador = 0; contador <= 10; contador++) //Usando o Laço
                    {
                        List_Tabuada1.Items.Add(numero + " x " + contador + " = " + numero * contador); //Mostrando o Resultado da Tabuada
                    }
                }
            }

        }

        private void Txt_Numero1_TextChanged(object sender, EventArgs e)
        {
            if (Txt_Numero1.Text == "") //Se ficar vazia
            {
                List_Tabuada1.Items.Clear();//Limpar a Lista
            }
        }

        private void List_Tabuada2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Numero2_TextChanged(object sender, EventArgs e)
        {
            if (Txt_Numero2.Text == "") {
                List_Tabuada2.Items.Clear();
            }
        }
        //Aula 28/09/24
        private void Txt_Numero2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Somente Números!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (e.KeyChar == 13) //Se pressionar a tecla ENTER
            {
                if (Txt_Numero2.Text != "") //Se for digitado o número
                {
                    numero = int.Parse(Txt_Numero2.Text); //A variável está recebendo o número digitado

                    contador = 0;

                    List_Tabuada2.Items.Clear();

                    while (contador <= 10) {
                        List_Tabuada2.Items.Add(contador + " X " + numero + " = " + contador * numero);
                        contador++;
                    }
                }
            }
        }

        private void Chk_While_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_While.Checked) 
            {
                Grp_Tabuada2.Visible = true;
            }
            else
            {
                Grp_Tabuada2.Visible= false;
            }
        }
    }
}

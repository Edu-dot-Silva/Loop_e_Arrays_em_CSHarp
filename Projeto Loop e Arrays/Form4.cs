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
    public partial class frm_contagem : Form
    {
        public frm_contagem()
        {
            InitializeComponent();
        }

        int contador, numero;

        private void txt_numero1_TextChanged(object sender, EventArgs e)
        {
            if (txt_numero1.Text == "")
            {
                lst_contagem1.Items.Clear();

            }
        }

        private void txt_numero1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

                MessageBox.Show("Somente Numeros","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            if (e.KeyChar == 13) {
                if (txt_numero1.Text != "") {

                    numero = int.Parse(txt_numero1.Text);

                    lst_contagem1.Items.Clear();

                    for (contador = 1; contador <= numero; contador++)
                    {
                        lst_contagem1.Items.Add(contador.ToString());
                    }
                }
            }
        }

        private void txt_numero2_TextChanged(object sender, EventArgs e)
        {
            if (txt_numero2.Text == "")
            {
                lst_contagem2.Items.Clear();

            }
        }

        private void txt_numero2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

                MessageBox.Show("Somente Numeros", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (e.KeyChar == 13)
            {
                if (txt_numero2.Text != "")
                {

                    numero = int.Parse(txt_numero2.Text);

                    lst_contagem2.Items.Clear();

                    for (contador = numero; contador >= 0; contador--)
                    {
                        lst_contagem2.Items.Add(contador.ToString());
                    }
                }
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Frm_Tela2 tela2 = new Frm_Tela2();
            tela2.Show();
            Hide();
        }
    }
}

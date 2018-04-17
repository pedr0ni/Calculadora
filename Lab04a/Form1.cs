using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private Boolean isValido()
        {
            try
            {
                double.Parse(txt_n1.Text);
                double.Parse(txt_n2.Text);

                return true; //Se conseguir dar parse nos 2 valores retorna verdadeiro
            } catch {
                MessageBox.Show("Digite apenas números !");
                txt_result.BackColor = Color.Red;
                return false; //Se houver algum problema mostra a mensagem muda o BackColor e retorna falso
            }
        }

        private void btn_soma_Click(object sender, EventArgs e)
        {
            if (!isValido()) return; //Se não for válido o código abaixo não é executado

            double resultado = double.Parse(txt_n1.Text) + double.Parse(txt_n2.Text);
            txt_result.Text = resultado.ToString();
            txt_result.BackColor = Color.Green;
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            if (!isValido()) return;

            double resultado = double.Parse(txt_n1.Text) - double.Parse(txt_n2.Text);
            txt_result.Text = resultado.ToString();
            txt_result.BackColor = Color.Gray;
        }

        private void btn_multi_Click(object sender, EventArgs e)
        {
            if (!isValido()) return;

            double resultado = double.Parse(txt_n1.Text) * double.Parse(txt_n2.Text);
            txt_result.Text = resultado.ToString();
            txt_result.BackColor = Color.Blue;

        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            if (!isValido()) return;
            if (double.Parse(txt_n2.Text) == 0)
            {
                txt_result.Text = "erro:div";
                txt_result.BackColor = Color.Red;
                return;
            }

            double resultado = double.Parse(txt_n1.Text) / double.Parse(txt_n2.Text);
            txt_result.Text = resultado.ToString();
            txt_result.BackColor = Color.Red;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txt_n1.Clear();
            txt_n2.Clear();
            txt_result.Clear();
            txt_result.BackColor = Color.DodgerBlue;
        }
    }
}

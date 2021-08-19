using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculador_de_INSS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double st, inss,desc,sf;

            // os valores estão desatualizados não pesquisamos os novos mas é só alterar os valores

            if ( Double.TryParse(textBox1.Text,out st) == false || st <= 0 )
            {
                MessageBox.Show("Insira um Salário Váido", "Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                textBox1.Focus();
                return;
            }


            if (st <= 1556.94)
            {
                desc = 8;
            }

            else if (st > 1556.94 && st <= 2594.92)
            {
                desc = 9;
            }

            else if (st > 2594.92 /*&& st <= 5189.82 */)
            {
                desc = 11;
            }

            else
            {
                MessageBox.Show("Algo Errado Aconteceu :(", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                return;
            }

            inss = st / desc;

            sf = st - inss;


            MessageBox.Show("Seu Inss a Pagar é de: "+inss.ToString() + "\n Seu salário final é de: "+sf.ToString(), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            

        }
    }
}

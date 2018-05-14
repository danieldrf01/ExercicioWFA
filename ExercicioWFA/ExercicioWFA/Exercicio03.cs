using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioWFA
{
    public partial class Exercicio03 : Form
    {

        public Exercicio03()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(txtValor1.Text);
            int numero2 = Convert.ToInt32(txtValor2.Text);
            int soma = numero1 + numero2;
            int subtracao = numero1 - numero2;
            int multiplicacao = numero1 * numero2;
            int divisao = numero1 / numero2;
            int produto1 = numero1 * numero1;
            int produto2 = numero2 * numero2;
            MessageBox.Show("Soma = " + soma);
            MessageBox.Show("Subtração = " + subtracao);
            MessageBox.Show("Multiplicação = " + multiplicacao);
            MessageBox.Show("Divisão = " + divisao);
            MessageBox.Show("Produto1 = " + produto1 );
            MessageBox.Show("Produto2 = " + produto2);
        }
    }
}   
        
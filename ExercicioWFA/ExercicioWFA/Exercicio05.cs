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
    public partial class Exercicio05 : Form
    {
        public Exercicio05()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nomeCarro = txtNomeCarro.Text;
            double valorDoCarro = Convert.ToDouble(mtbValorCarro.Text);
            double valorDaParcela = Convert.ToDouble(mtbValorParcela.Text);
            int quantidadeParcelas = Convert.ToInt32(txtQuantidadeMeses);
            double valorTotalFinancimaneto = valorDaParcela * quantidadeParcelas;
            double diferençaValores = 

        }
    }
}

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
            int quantidadeParcelas = Convert.ToInt32(txtQuantidadeMeses.Text);
            double valorTotalFinancimaneto = valorDaParcela * quantidadeParcelas;
            double diferencaPreco = valorDoCarro - valorTotalFinancimaneto;

            string textao = string.Format("Nome do carro: {0}\r\nValor do carro: {1:n}\r\nValor da Parcela: {2:n}\r\nQuantidade de parcelas: {3:n}\r\nValor do financiamento: {4:}\r\nDiferença entre valor do financiamento {5:n}", nomeCarro, valorDoCarro, valorDaParcela, quantidadeParcelas, valorTotalFinancimaneto, diferencaPreco);  
            
            txtTextao.Text = textao;
        }
    }
}

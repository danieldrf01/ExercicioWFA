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
    public partial class Exercicio02 : Form
    {
        public Exercicio02()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {

            int quantidadeLitros = Convert.ToInt32(txtquantidadeLitros.Text);
            int quantidadeAnos = Convert.ToInt32(txtquantidadeAnos.Text);
            int quantidadeTotal = quantidadeAnos * 365 * quantidadeLitros;
            double valorLitro = Convert.ToDouble(mtbValor.Text);
            int quantidadeAnos1 = Convert.ToInt32(txtquantidadeAnos.Text);
            double quantidadeLitros1 = Convert.ToDouble(txtquantidadeLitros.Text);
            double valorTotal = valorLitro * quantidadeAnos1 * quantidadeLitros1 * 365;
            MessageBox.Show(string.Format("Valor total pago {0:n}", valorTotal));
            MessageBox.Show(string.Format("Quantidade de litros Consumidos {0:n}" + " L", quantidadeTotal));

            try
            {
                quantidadeLitros = Convert.ToInt32(txtquantidadeLitros.Text);
                quantidadeAnos = Convert.ToInt32(txtquantidadeAnos.Text);
                quantidadeTotal = quantidadeAnos * 365 * quantidadeLitros;
                valorLitro = Convert.ToDouble(mtbValor.Text);
                quantidadeAnos1 = Convert.ToInt32(txtquantidadeAnos.Text);
                quantidadeLitros1 = Convert.ToDouble(txtquantidadeLitros.Text);
                valorTotal = valorLitro * quantidadeAnos1 * quantidadeLitros1 * 365;

            }
            catch
            {
                MessageBox.Show("Somente NÚMEROS!!");
                throw;
            }

        }
    }
}

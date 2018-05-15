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
    public partial class Exercicio08 : Form
    {
        public Exercicio08()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double contaDaNet = Convert.ToDouble(txtContaDaNet.Text);
            double ContaDaVivo = Convert.ToDouble(txtContaDaVivo.Text);
            double ContaDaOi = Convert.ToDouble(txtContaDaOi.Text);
            double ipva = Convert.ToDouble(txtIpva.Text);
            double iptu = Convert.ToDouble(txtIpva.Text);
            double contaDeLuz = Convert.ToDouble(txtContaDeLuz.Text);
            double contaDeAgua = Convert.ToDouble(txtContaDeAgua.Text);
            double seguroDoCarro = Convert.ToDouble(txtSeguroDoCarro.Text);

            double contasDeTelefone = contaDaNet + ContaDaOi + ContaDaVivo;
            double impostos = ipva + iptu;
            double restanteDasContas = contaDeAgua + contaDeLuz + seguroDoCarro;
            double valorTotalDasContas = contasDeTelefone + impostos + restanteDasContas;

            try
            {
                 contaDaNet = Convert.ToDouble(txtContaDaNet.Text);
                 ContaDaVivo = Convert.ToDouble(txtContaDaVivo.Text);
                 ContaDaOi = Convert.ToDouble(txtContaDaOi.Text);
                 ipva = Convert.ToDouble(txtIpva.Text);
                 iptu = Convert.ToDouble(txtIpva.Text);
                 contaDeLuz = Convert.ToDouble(txtContaDeLuz.Text);
                 contaDeAgua = Convert.ToDouble(txtContaDeAgua.Text);
                 seguroDoCarro = Convert.ToDouble(txtSeguroDoCarro.Text);
            }
            catch 
            {
                MessageBox.Show("SOMENTE NÚMEROS!!");
                return;
            }

            string textao = string.Format("\r\nValor das contas de telefone: {0:n}\r\nValor dos impostos: {1:n}\r\nValor do restante das contas: {2:n}\r\nValor total de todas as contas: {3:n}", contasDeTelefone, impostos, restanteDasContas, valorTotalDasContas);

            txtTextao.Text = textao;

        }
    }
}

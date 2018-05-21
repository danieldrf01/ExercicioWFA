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
    public partial class Exercicio09 : Form
    {
        public Exercicio09()
        {
            InitializeComponent();
        }

        private void txtNumero2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(txtNumero1.Text);
            int numero2 = Convert.ToInt32(txtNumero2.Text);

            try
            {
                numero1 = Convert.ToInt32(txtNumero1.Text);
                numero2 = Convert.ToInt32(txtNumero2.Text);
            }
            catch 
            {
                MessageBox.Show("SOMENTE NÚMEROS!!");
                return;
            }

            string textao = string.Format("\r\n1° Número: {0}\r\n2° Número: {1}", numero2, numero1);

            txtTextao.Text = textao;
        }
    }
}

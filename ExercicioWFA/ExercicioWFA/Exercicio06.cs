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
    public partial class Exercicio06 : Form
    {
        public Exercicio06()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(txtNota1.Text);
            double numero2 = Convert.ToDouble(txtNota2.Text);
            double numero3 = Convert.ToDouble(txtNota3.Text);
            double numero4 = Convert.ToDouble(txtNota4.Text);
            double media = (numero1 + numero2 + numero3 + numero4) / 4;
            
            try
            {
                 numero1 = Convert.ToDouble(txtNota1.Text);
                 numero2 = Convert.ToDouble(txtNota2.Text);
                 numero3 = Convert.ToDouble(txtNota3.Text);
                 numero4 = Convert.ToDouble(txtNota4.Text);
                 

            }
            catch
            {
                MessageBox.Show("SOMENTE NÚMEROS!!");
                return;
            }

            string textao = string.Format("\r\nMédia: {0:n}", media);

            txtTextao.Text = textao;

        }
    }
}

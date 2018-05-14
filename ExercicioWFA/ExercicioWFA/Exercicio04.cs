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
    public partial class Exercicio04 : Form
    {
        public Exercicio04()
        {
            InitializeComponent();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {
                          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(txtNumero.Text);

            int tabuada0 = numero * 0;
            int tabuada1 = numero * 1;
            int tabuada2 = numero * 2;
            int tabuada3 = numero * 3;
            int tabuada4 = numero * 4;
            int tabuada5 = numero * 5;
            int tabuada6 = numero * 6;
            int tabuada7 = numero * 7;
            int tabuada8 = numero * 8;
            int tabuada9 = numero * 9;
            int tabuada10 = numero * 10;

            string textao = string.Format(numero + " X " + " 0 " + " = " + tabuada0);
            textao += string.Format("\r\n" + numero + " X " + " 1 " + " = " + tabuada1);
            textao += string.Format("\r\n" + numero + " X " + " 2 " + " = " + tabuada2);
            textao += string.Format("\r\n" + numero + " X " + " 3 " + " = " + tabuada3);
            textao += string.Format("\r\n" + numero + " X " + " 4 " + " = " + tabuada4);
            textao += string.Format("\r\n" + numero + " X " + " 5 " + " = " + tabuada5);
            textao += string.Format("\r\n" + numero + " X " + " 6 " + " = " + tabuada6);
            textao += string.Format("\r\n" + numero + " X " + " 7 " + " = " + tabuada7);
            textao += string.Format("\r\n" + numero + " X " + " 8 " + " = " + tabuada8);
            textao += string.Format("\r\n" + numero + " X " + " 9 " + " = " + tabuada9);
            textao += string.Format("\r\n" + numero + " X " + " 10 " + " = " + tabuada10);

            txtTextao.Text = textao;

        }
    }
}

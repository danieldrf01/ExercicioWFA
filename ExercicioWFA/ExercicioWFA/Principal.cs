﻿using System;
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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Exercicio02 exercicio02 = new Exercicio02();
            exercicio02.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Exercicio03 exercicio03 = new Exercicio03();
            exercicio03.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Exercicio04 exercicio04 = new Exercicio04();
            exercicio04.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Exercicio05 exercicio05 = new Exercicio05();
            exercicio05.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Exercicio06 exercicio06 = new Exercicio06();
            exercicio06.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Exercicio07 exercicio07 = new Exercicio07();
            exercicio07.Show();
        }

    }
}

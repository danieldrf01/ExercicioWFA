namespace ExercicioWFA
{
    partial class Exercicio05
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label01 = new System.Windows.Forms.Label();
            this.label02 = new System.Windows.Forms.Label();
            this.label03 = new System.Windows.Forms.Label();
            this.label04 = new System.Windows.Forms.Label();
            this.txtTextao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeCarro = new System.Windows.Forms.TextBox();
            this.mtbValorCarro = new System.Windows.Forms.MaskedTextBox();
            this.mtbValorParcela = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtQuantidadeMeses = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label01
            // 
            this.label01.AutoSize = true;
            this.label01.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label01.Location = new System.Drawing.Point(146, 22);
            this.label01.Name = "label01";
            this.label01.Size = new System.Drawing.Size(135, 19);
            this.label01.TabIndex = 0;
            this.label01.Text = "Nome Do Carro";
            // 
            // label02
            // 
            this.label02.AutoSize = true;
            this.label02.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label02.Location = new System.Drawing.Point(146, 71);
            this.label02.Name = "label02";
            this.label02.Size = new System.Drawing.Size(129, 19);
            this.label02.TabIndex = 1;
            this.label02.Text = "Valor do carro";
            // 
            // label03
            // 
            this.label03.AutoSize = true;
            this.label03.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label03.Location = new System.Drawing.Point(135, 116);
            this.label03.Name = "label03";
            this.label03.Size = new System.Drawing.Size(146, 19);
            this.label03.TabIndex = 2;
            this.label03.Text = "Valor Da Parcela";
            // 
            // label04
            // 
            this.label04.AutoSize = true;
            this.label04.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label04.Location = new System.Drawing.Point(12, 162);
            this.label04.Name = "label04";
            this.label04.Size = new System.Drawing.Size(328, 19);
            this.label04.TabIndex = 3;
            this.label04.Text = "Quantidade de Meses Do Financiamento";
            // 
            // txtTextao
            // 
            this.txtTextao.Location = new System.Drawing.Point(573, 299);
            this.txtTextao.Multiline = true;
            this.txtTextao.Name = "txtTextao";
            this.txtTextao.Size = new System.Drawing.Size(195, 158);
            this.txtTextao.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(619, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Resultado";
            // 
            // txtNomeCarro
            // 
            this.txtNomeCarro.Location = new System.Drawing.Point(364, 22);
            this.txtNomeCarro.Name = "txtNomeCarro";
            this.txtNomeCarro.Size = new System.Drawing.Size(100, 20);
            this.txtNomeCarro.TabIndex = 6;
            // 
            // mtbValorCarro
            // 
            this.mtbValorCarro.Location = new System.Drawing.Point(364, 70);
            this.mtbValorCarro.Name = "mtbValorCarro";
            this.mtbValorCarro.Size = new System.Drawing.Size(100, 20);
            this.mtbValorCarro.TabIndex = 7;
            // 
            // mtbValorParcela
            // 
            this.mtbValorParcela.Location = new System.Drawing.Point(364, 115);
            this.mtbValorParcela.Name = "mtbValorParcela";
            this.mtbValorParcela.Size = new System.Drawing.Size(100, 20);
            this.mtbValorParcela.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Geometr212 BkCn BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(364, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 64);
            this.button1.TabIndex = 9;
            this.button1.Text = "EXECUTAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtQuantidadeMeses
            // 
            this.txtQuantidadeMeses.Location = new System.Drawing.Point(364, 163);
            this.txtQuantidadeMeses.Name = "txtQuantidadeMeses";
            this.txtQuantidadeMeses.Size = new System.Drawing.Size(100, 20);
            this.txtQuantidadeMeses.TabIndex = 10;
            // 
            // Exercicio05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(770, 459);
            this.Controls.Add(this.txtQuantidadeMeses);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mtbValorParcela);
            this.Controls.Add(this.mtbValorCarro);
            this.Controls.Add(this.txtNomeCarro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTextao);
            this.Controls.Add(this.label04);
            this.Controls.Add(this.label03);
            this.Controls.Add(this.label02);
            this.Controls.Add(this.label01);
            this.Name = "Exercicio05";
            this.Text = "Exercicio05";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label01;
        private System.Windows.Forms.Label label02;
        private System.Windows.Forms.Label label03;
        private System.Windows.Forms.Label label04;
        private System.Windows.Forms.TextBox txtTextao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeCarro;
        private System.Windows.Forms.MaskedTextBox mtbValorCarro;
        private System.Windows.Forms.MaskedTextBox mtbValorParcela;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtQuantidadeMeses;
    }
}
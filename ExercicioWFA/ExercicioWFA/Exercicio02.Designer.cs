namespace ExercicioWFA
{
    partial class Exercicio02
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtquantidadeLitros = new System.Windows.Forms.TextBox();
            this.txtquantidadeAnos = new System.Windows.Forms.TextBox();
            this.mtbValor = new System.Windows.Forms.MaskedTextBox();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor por litro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(324, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantidade de anos  consumidos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantidade de litros ";
            // 
            // txtquantidadeLitros
            // 
            this.txtquantidadeLitros.Location = new System.Drawing.Point(365, 77);
            this.txtquantidadeLitros.Name = "txtquantidadeLitros";
            this.txtquantidadeLitros.Size = new System.Drawing.Size(100, 20);
            this.txtquantidadeLitros.TabIndex = 6;
            // 
            // txtquantidadeAnos
            // 
            this.txtquantidadeAnos.Location = new System.Drawing.Point(365, 135);
            this.txtquantidadeAnos.Name = "txtquantidadeAnos";
            this.txtquantidadeAnos.Size = new System.Drawing.Size(100, 20);
            this.txtquantidadeAnos.TabIndex = 7;
            // 
            // mtbValor
            // 
            this.mtbValor.Location = new System.Drawing.Point(365, 26);
            this.mtbValor.Mask = "000.00";
            this.mtbValor.Name = "mtbValor";
            this.mtbValor.Size = new System.Drawing.Size(100, 20);
            this.mtbValor.TabIndex = 8;
            // 
            // btnExecutar
            // 
            this.btnExecutar.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecutar.Location = new System.Drawing.Point(368, 190);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(97, 40);
            this.btnExecutar.TabIndex = 9;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // Exercício03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(730, 455);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.mtbValor);
            this.Controls.Add(this.txtquantidadeAnos);
            this.Controls.Add(this.txtquantidadeLitros);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Exercício03";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtquantidadeLitros;
        private System.Windows.Forms.TextBox txtquantidadeAnos;
        private System.Windows.Forms.MaskedTextBox mtbValor;
        private System.Windows.Forms.Button btnExecutar;
    }
}


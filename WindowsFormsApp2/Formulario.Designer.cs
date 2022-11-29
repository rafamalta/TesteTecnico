namespace WindowsFormsApp2
{
    partial class FrmFormulario
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Muliplicar = new System.Windows.Forms.Button();
            this.Dividir = new System.Windows.Forms.Button();
            this.Limpar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PrimeiroValor = new System.Windows.Forms.TextBox();
            this.SegundoValor = new System.Windows.Forms.TextBox();
            this.Resultado = new System.Windows.Forms.TextBox();
            this.textDescricao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Muliplicar
            // 
            this.Muliplicar.Location = new System.Drawing.Point(35, 243);
            this.Muliplicar.Margin = new System.Windows.Forms.Padding(2);
            this.Muliplicar.Name = "Muliplicar";
            this.Muliplicar.Size = new System.Drawing.Size(98, 19);
            this.Muliplicar.TabIndex = 0;
            this.Muliplicar.Text = "Multiplicar";
            this.Muliplicar.UseVisualStyleBackColor = true;
            this.Muliplicar.Click += new System.EventHandler(this.Muliplicar_Click);
            // 
            // Dividir
            // 
            this.Dividir.Location = new System.Drawing.Point(147, 243);
            this.Dividir.Margin = new System.Windows.Forms.Padding(2);
            this.Dividir.Name = "Dividir";
            this.Dividir.Size = new System.Drawing.Size(98, 19);
            this.Dividir.TabIndex = 1;
            this.Dividir.Text = "Dividir";
            this.Dividir.UseVisualStyleBackColor = true;
            this.Dividir.Click += new System.EventHandler(this.Dividir_Click);
            // 
            // Limpar
            // 
            this.Limpar.Location = new System.Drawing.Point(258, 243);
            this.Limpar.Margin = new System.Windows.Forms.Padding(2);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(98, 19);
            this.Limpar.TabIndex = 2;
            this.Limpar.Text = "Limpar";
            this.Limpar.UseVisualStyleBackColor = true;
            this.Limpar.Click += new System.EventHandler(this.Limpar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Valor A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Valor B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 184);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Resultado";
            // 
            // PrimeiroValor
            // 
            this.PrimeiroValor.Location = new System.Drawing.Point(95, 99);
            this.PrimeiroValor.Margin = new System.Windows.Forms.Padding(2);
            this.PrimeiroValor.Name = "PrimeiroValor";
            this.PrimeiroValor.Size = new System.Drawing.Size(206, 20);
            this.PrimeiroValor.TabIndex = 6;
            // 
            // SegundoValor
            // 
            this.SegundoValor.Location = new System.Drawing.Point(95, 148);
            this.SegundoValor.Margin = new System.Windows.Forms.Padding(2);
            this.SegundoValor.Name = "SegundoValor";
            this.SegundoValor.Size = new System.Drawing.Size(206, 20);
            this.SegundoValor.TabIndex = 7;
            // 
            // Resultado
            // 
            this.Resultado.Location = new System.Drawing.Point(95, 199);
            this.Resultado.Margin = new System.Windows.Forms.Padding(2);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(206, 20);
            this.Resultado.TabIndex = 8;
            // 
            // textDescricao
            // 
            this.textDescricao.Location = new System.Drawing.Point(95, 42);
            this.textDescricao.Margin = new System.Windows.Forms.Padding(2);
            this.textDescricao.Name = "textDescricao";
            this.textDescricao.Size = new System.Drawing.Size(206, 20);
            this.textDescricao.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Descrição";
            // 
            // FrmFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 324);
            this.Controls.Add(this.textDescricao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.SegundoValor);
            this.Controls.Add(this.PrimeiroValor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Limpar);
            this.Controls.Add(this.Dividir);
            this.Controls.Add(this.Muliplicar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmFormulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário";
            this.Load += new System.EventHandler(this.FrmFormulario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Muliplicar;
        private System.Windows.Forms.Button Dividir;
        private System.Windows.Forms.Button Limpar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PrimeiroValor;
        private System.Windows.Forms.TextBox SegundoValor;
        private System.Windows.Forms.TextBox Resultado;
        private System.Windows.Forms.TextBox textDescricao;
        private System.Windows.Forms.Label label4;
    }
}


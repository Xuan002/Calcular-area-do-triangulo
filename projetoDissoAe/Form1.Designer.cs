namespace projetoDissoAe
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.Valor1 = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.Valor2 = new System.Windows.Forms.Label();
            this.Resultado = new System.Windows.Forms.Label();
            this.Resu = new System.Windows.Forms.TextBox();
            this.textInicial = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(95)))), ((int)(((byte)(242)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(118, 319);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Valor1
            // 
            this.Valor1.AutoSize = true;
            this.Valor1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Valor1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Valor1.Location = new System.Drawing.Point(158, 135);
            this.Valor1.Name = "Valor1";
            this.Valor1.Size = new System.Drawing.Size(38, 16);
            this.Valor1.TabIndex = 1;
            this.Valor1.Text = "Base";
            this.Valor1.Click += new System.EventHandler(this.Valor1_Click);
            // 
            // txtAltura
            // 
            this.txtAltura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.txtAltura.Location = new System.Drawing.Point(102, 214);
            this.txtAltura.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(159, 22);
            this.txtAltura.TabIndex = 2;
            // 
            // txtBase
            // 
            this.txtBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.txtBase.Location = new System.Drawing.Point(102, 155);
            this.txtBase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(159, 22);
            this.txtBase.TabIndex = 3;
            // 
            // Valor2
            // 
            this.Valor2.AutoSize = true;
            this.Valor2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Valor2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Valor2.Location = new System.Drawing.Point(158, 194);
            this.Valor2.Name = "Valor2";
            this.Valor2.Size = new System.Drawing.Size(42, 16);
            this.Valor2.TabIndex = 5;
            this.Valor2.Text = "Altura";
            this.Valor2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Resultado
            // 
            this.Resultado.AutoSize = true;
            this.Resultado.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultado.Location = new System.Drawing.Point(145, 257);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(70, 17);
            this.Resultado.TabIndex = 7;
            this.Resultado.Text = "Resultado";
            // 
            // Resu
            // 
            this.Resu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.Resu.Location = new System.Drawing.Point(102, 278);
            this.Resu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Resu.Name = "Resu";
            this.Resu.ReadOnly = true;
            this.Resu.Size = new System.Drawing.Size(159, 22);
            this.Resu.TabIndex = 8;
            this.Resu.TextChanged += new System.EventHandler(this.Resu_TextChanged);
            // 
            // textInicial
            // 
            this.textInicial.AutoSize = true;
            this.textInicial.Font = new System.Drawing.Font("Arial", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textInicial.ForeColor = System.Drawing.Color.DimGray;
            this.textInicial.Location = new System.Drawing.Point(99, 75);
            this.textInicial.Name = "textInicial";
            this.textInicial.Size = new System.Drawing.Size(167, 19);
            this.textInicial.TabIndex = 9;
            this.textInicial.Text = "Calculadora de Área";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(132, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "do Triangulo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(369, 435);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textInicial);
            this.Controls.Add(this.Resu);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.Valor2);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.Valor1);
            this.Controls.Add(this.button1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Valor1;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.Label Valor2;
        private System.Windows.Forms.Label Resultado;
        private System.Windows.Forms.TextBox Resu;
        private System.Windows.Forms.Label textInicial;
        private System.Windows.Forms.Label label1;
    }
}


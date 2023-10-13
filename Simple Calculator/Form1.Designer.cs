
namespace Simple_Calculator
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
            this.labeltitulo = new System.Windows.Forms.Label();
            this.labelNumeroUm = new System.Windows.Forms.Label();
            this.labelNumeroDois = new System.Windows.Forms.Label();
            this.labelResultadoText = new System.Windows.Forms.Label();
            this.labelResultado = new System.Windows.Forms.Label();
            this.textBoxNumeroUm = new System.Windows.Forms.TextBox();
            this.textBoxNumeroDois = new System.Windows.Forms.TextBox();
            this.buttonSomar = new System.Windows.Forms.Button();
            this.buttonsSubtracao = new System.Windows.Forms.Button();
            this.buttonMulti = new System.Windows.Forms.Button();
            this.buttonDivisao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labeltitulo
            // 
            this.labeltitulo.AutoSize = true;
            this.labeltitulo.Location = new System.Drawing.Point(136, 13);
            this.labeltitulo.Name = "labeltitulo";
            this.labeltitulo.Size = new System.Drawing.Size(63, 13);
            this.labeltitulo.TabIndex = 0;
            this.labeltitulo.Text = "Calculadora";
            this.labeltitulo.Click += new System.EventHandler(this.labeltitulo_Click);
            // 
            // labelNumeroUm
            // 
            this.labelNumeroUm.AutoSize = true;
            this.labelNumeroUm.Location = new System.Drawing.Point(13, 50);
            this.labelNumeroUm.Name = "labelNumeroUm";
            this.labelNumeroUm.Size = new System.Drawing.Size(84, 13);
            this.labelNumeroUm.TabIndex = 1;
            this.labelNumeroUm.Text = "Primeiro Número";
            // 
            // labelNumeroDois
            // 
            this.labelNumeroDois.AutoSize = true;
            this.labelNumeroDois.Location = new System.Drawing.Point(13, 113);
            this.labelNumeroDois.Name = "labelNumeroDois";
            this.labelNumeroDois.Size = new System.Drawing.Size(90, 13);
            this.labelNumeroDois.TabIndex = 2;
            this.labelNumeroDois.Text = "Segundo Número";
            // 
            // labelResultadoText
            // 
            this.labelResultadoText.AutoSize = true;
            this.labelResultadoText.Location = new System.Drawing.Point(19, 192);
            this.labelResultadoText.Name = "labelResultadoText";
            this.labelResultadoText.Size = new System.Drawing.Size(58, 13);
            this.labelResultadoText.TabIndex = 3;
            this.labelResultadoText.Text = "Resultado:";
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Location = new System.Drawing.Point(78, 192);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(13, 13);
            this.labelResultado.TabIndex = 4;
            this.labelResultado.Text = "0";
            // 
            // textBoxNumeroUm
            // 
            this.textBoxNumeroUm.Location = new System.Drawing.Point(16, 66);
            this.textBoxNumeroUm.Name = "textBoxNumeroUm";
            this.textBoxNumeroUm.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumeroUm.TabIndex = 5;
            // 
            // textBoxNumeroDois
            // 
            this.textBoxNumeroDois.Location = new System.Drawing.Point(16, 130);
            this.textBoxNumeroDois.Name = "textBoxNumeroDois";
            this.textBoxNumeroDois.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumeroDois.TabIndex = 6;
            // 
            // buttonSomar
            // 
            this.buttonSomar.Location = new System.Drawing.Point(16, 156);
            this.buttonSomar.Name = "buttonSomar";
            this.buttonSomar.Size = new System.Drawing.Size(75, 23);
            this.buttonSomar.TabIndex = 7;
            this.buttonSomar.Text = "ADIÇÃO";
            this.buttonSomar.UseVisualStyleBackColor = true;
            this.buttonSomar.Click += new System.EventHandler(this.buttonSomar_Click);
            // 
            // buttonsSubtracao
            // 
            this.buttonsSubtracao.Location = new System.Drawing.Point(97, 156);
            this.buttonsSubtracao.Name = "buttonsSubtracao";
            this.buttonsSubtracao.Size = new System.Drawing.Size(83, 23);
            this.buttonsSubtracao.TabIndex = 8;
            this.buttonsSubtracao.Text = "SUBTRAÇÃO";
            this.buttonsSubtracao.UseVisualStyleBackColor = true;
            this.buttonsSubtracao.Click += new System.EventHandler(this.buttonsSubtracao_Click);
            // 
            // buttonMulti
            // 
            this.buttonMulti.Location = new System.Drawing.Point(186, 156);
            this.buttonMulti.Name = "buttonMulti";
            this.buttonMulti.Size = new System.Drawing.Size(104, 23);
            this.buttonMulti.TabIndex = 9;
            this.buttonMulti.Text = "MULTIPLICAÇÃO";
            this.buttonMulti.UseVisualStyleBackColor = true;
            this.buttonMulti.Click += new System.EventHandler(this.buttonMulti_Click);
            // 
            // buttonDivisao
            // 
            this.buttonDivisao.Location = new System.Drawing.Point(296, 156);
            this.buttonDivisao.Name = "buttonDivisao";
            this.buttonDivisao.Size = new System.Drawing.Size(75, 23);
            this.buttonDivisao.TabIndex = 10;
            this.buttonDivisao.Text = "DIVISÃO";
            this.buttonDivisao.UseVisualStyleBackColor = true;
            this.buttonDivisao.Click += new System.EventHandler(this.buttonDivisao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 278);
            this.Controls.Add(this.buttonDivisao);
            this.Controls.Add(this.buttonMulti);
            this.Controls.Add(this.buttonsSubtracao);
            this.Controls.Add(this.buttonSomar);
            this.Controls.Add(this.textBoxNumeroDois);
            this.Controls.Add(this.textBoxNumeroUm);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.labelResultadoText);
            this.Controls.Add(this.labelNumeroDois);
            this.Controls.Add(this.labelNumeroUm);
            this.Controls.Add(this.labeltitulo);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labeltitulo;
        private System.Windows.Forms.Label labelNumeroUm;
        private System.Windows.Forms.Label labelNumeroDois;
        private System.Windows.Forms.Label labelResultadoText;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.TextBox textBoxNumeroUm;
        private System.Windows.Forms.TextBox textBoxNumeroDois;
        private System.Windows.Forms.Button buttonSomar;
        private System.Windows.Forms.Button buttonsSubtracao;
        private System.Windows.Forms.Button buttonMulti;
        private System.Windows.Forms.Button buttonDivisao;
    }
}


namespace Atividade4
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSalBruto = new System.Windows.Forms.Label();
            this.lblFilhos = new System.Windows.Forms.Label();
            this.mskbxNome = new System.Windows.Forms.MaskedTextBox();
            this.mskbxSalario = new System.Windows.Forms.MaskedTextBox();
            this.mskbxFilhos = new System.Windows.Forms.MaskedTextBox();
            this.gbxGenero = new System.Windows.Forms.GroupBox();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.rbtnFemino = new System.Windows.Forms.RadioButton();
            this.btnDesconto = new System.Windows.Forms.Button();
            this.chbxCasado = new System.Windows.Forms.CheckBox();
            this.lblTexto = new System.Windows.Forms.Label();
            this.lblAINSS = new System.Windows.Forms.Label();
            this.lblAIRPF = new System.Windows.Forms.Label();
            this.lblSalL = new System.Windows.Forms.Label();
            this.mskbxAliqINSS = new System.Windows.Forms.MaskedTextBox();
            this.mskbxAliqIRPF = new System.Windows.Forms.MaskedTextBox();
            this.mskbxSalarioF = new System.Windows.Forms.MaskedTextBox();
            this.lblSalF = new System.Windows.Forms.Label();
            this.lblDescINSS = new System.Windows.Forms.Label();
            this.lblDescIRPF = new System.Windows.Forms.Label();
            this.mskbxSalarioLiq = new System.Windows.Forms.MaskedTextBox();
            this.mskbxDescINSS = new System.Windows.Forms.MaskedTextBox();
            this.mskbxDescIRPF = new System.Windows.Forms.MaskedTextBox();
            this.gbxGenero.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(16, 32);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(127, 19);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome funcionário";
            // 
            // lblSalBruto
            // 
            this.lblSalBruto.AutoSize = true;
            this.lblSalBruto.Location = new System.Drawing.Point(16, 65);
            this.lblSalBruto.Name = "lblSalBruto";
            this.lblSalBruto.Size = new System.Drawing.Size(98, 19);
            this.lblSalBruto.TabIndex = 1;
            this.lblSalBruto.Text = "Salário Bruto";
            // 
            // lblFilhos
            // 
            this.lblFilhos.AutoSize = true;
            this.lblFilhos.Location = new System.Drawing.Point(16, 101);
            this.lblFilhos.Name = "lblFilhos";
            this.lblFilhos.Size = new System.Drawing.Size(123, 19);
            this.lblFilhos.TabIndex = 2;
            this.lblFilhos.Text = "Número de filhos";
            // 
            // mskbxNome
            // 
            this.mskbxNome.Location = new System.Drawing.Point(151, 32);
            this.mskbxNome.Name = "mskbxNome";
            this.mskbxNome.Size = new System.Drawing.Size(482, 26);
            this.mskbxNome.TabIndex = 3;
            // 
            // mskbxSalario
            // 
            this.mskbxSalario.Location = new System.Drawing.Point(151, 63);
            this.mskbxSalario.Mask = "000000,00";
            this.mskbxSalario.Name = "mskbxSalario";
            this.mskbxSalario.Size = new System.Drawing.Size(170, 26);
            this.mskbxSalario.TabIndex = 4;
            // 
            // mskbxFilhos
            // 
            this.mskbxFilhos.Location = new System.Drawing.Point(151, 99);
            this.mskbxFilhos.Mask = "00";
            this.mskbxFilhos.Name = "mskbxFilhos";
            this.mskbxFilhos.Size = new System.Drawing.Size(170, 26);
            this.mskbxFilhos.TabIndex = 5;
            // 
            // gbxGenero
            // 
            this.gbxGenero.Controls.Add(this.rbtnMasculino);
            this.gbxGenero.Controls.Add(this.rbtnFemino);
            this.gbxGenero.Location = new System.Drawing.Point(346, 63);
            this.gbxGenero.Name = "gbxGenero";
            this.gbxGenero.Size = new System.Drawing.Size(287, 62);
            this.gbxGenero.TabIndex = 6;
            this.gbxGenero.TabStop = false;
            this.gbxGenero.Text = "Gênero";
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.Location = new System.Drawing.Point(152, 25);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(97, 23);
            this.rbtnMasculino.TabIndex = 1;
            this.rbtnMasculino.Text = "Masculino";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // rbtnFemino
            // 
            this.rbtnFemino.AutoSize = true;
            this.rbtnFemino.Checked = true;
            this.rbtnFemino.Location = new System.Drawing.Point(31, 25);
            this.rbtnFemino.Name = "rbtnFemino";
            this.rbtnFemino.Size = new System.Drawing.Size(88, 23);
            this.rbtnFemino.TabIndex = 0;
            this.rbtnFemino.TabStop = true;
            this.rbtnFemino.Text = "Feminino";
            this.rbtnFemino.UseVisualStyleBackColor = true;
            // 
            // btnDesconto
            // 
            this.btnDesconto.Location = new System.Drawing.Point(20, 145);
            this.btnDesconto.Name = "btnDesconto";
            this.btnDesconto.Size = new System.Drawing.Size(166, 33);
            this.btnDesconto.TabIndex = 7;
            this.btnDesconto.Text = "DESCONTO";
            this.btnDesconto.UseVisualStyleBackColor = true;
            this.btnDesconto.Click += new System.EventHandler(this.button1_Click);
            // 
            // chbxCasado
            // 
            this.chbxCasado.AutoSize = true;
            this.chbxCasado.Location = new System.Drawing.Point(346, 145);
            this.chbxCasado.Name = "chbxCasado";
            this.chbxCasado.Size = new System.Drawing.Size(78, 23);
            this.chbxCasado.TabIndex = 8;
            this.chbxCasado.Text = "Casado";
            this.chbxCasado.UseVisualStyleBackColor = true;
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Location = new System.Drawing.Point(20, 206);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(21, 19);
            this.lblTexto.TabIndex = 9;
            this.lblTexto.Text = "   ";
            // 
            // lblAINSS
            // 
            this.lblAINSS.AutoSize = true;
            this.lblAINSS.Location = new System.Drawing.Point(20, 255);
            this.lblAINSS.Name = "lblAINSS";
            this.lblAINSS.Size = new System.Drawing.Size(105, 19);
            this.lblAINSS.TabIndex = 10;
            this.lblAINSS.Text = "Alíquota INSS";
            // 
            // lblAIRPF
            // 
            this.lblAIRPF.AutoSize = true;
            this.lblAIRPF.Location = new System.Drawing.Point(20, 291);
            this.lblAIRPF.Name = "lblAIRPF";
            this.lblAIRPF.Size = new System.Drawing.Size(105, 19);
            this.lblAIRPF.TabIndex = 11;
            this.lblAIRPF.Text = "Alíquota IRPF";
            // 
            // lblSalL
            // 
            this.lblSalL.AutoSize = true;
            this.lblSalL.Location = new System.Drawing.Point(346, 259);
            this.lblSalL.Name = "lblSalL";
            this.lblSalL.Size = new System.Drawing.Size(110, 19);
            this.lblSalL.TabIndex = 12;
            this.lblSalL.Text = "Salário Líquido";
            // 
            // mskbxAliqINSS
            // 
            this.mskbxAliqINSS.Enabled = false;
            this.mskbxAliqINSS.Location = new System.Drawing.Point(151, 252);
            this.mskbxAliqINSS.Name = "mskbxAliqINSS";
            this.mskbxAliqINSS.Size = new System.Drawing.Size(170, 26);
            this.mskbxAliqINSS.TabIndex = 13;
            // 
            // mskbxAliqIRPF
            // 
            this.mskbxAliqIRPF.Enabled = false;
            this.mskbxAliqIRPF.Location = new System.Drawing.Point(151, 284);
            this.mskbxAliqIRPF.Name = "mskbxAliqIRPF";
            this.mskbxAliqIRPF.Size = new System.Drawing.Size(170, 26);
            this.mskbxAliqIRPF.TabIndex = 14;
            // 
            // mskbxSalarioF
            // 
            this.mskbxSalarioF.Enabled = false;
            this.mskbxSalarioF.Location = new System.Drawing.Point(151, 317);
            this.mskbxSalarioF.Name = "mskbxSalarioF";
            this.mskbxSalarioF.Size = new System.Drawing.Size(170, 26);
            this.mskbxSalarioF.TabIndex = 15;
            // 
            // lblSalF
            // 
            this.lblSalF.AutoSize = true;
            this.lblSalF.Location = new System.Drawing.Point(20, 324);
            this.lblSalF.Name = "lblSalF";
            this.lblSalF.Size = new System.Drawing.Size(105, 19);
            this.lblSalF.TabIndex = 16;
            this.lblSalF.Text = "Salário família";
            // 
            // lblDescINSS
            // 
            this.lblDescINSS.AutoSize = true;
            this.lblDescINSS.Location = new System.Drawing.Point(344, 291);
            this.lblDescINSS.Name = "lblDescINSS";
            this.lblDescINSS.Size = new System.Drawing.Size(112, 19);
            this.lblDescINSS.TabIndex = 17;
            this.lblDescINSS.Text = "Desconto INSS";
            // 
            // lblDescIRPF
            // 
            this.lblDescIRPF.AutoSize = true;
            this.lblDescIRPF.Location = new System.Drawing.Point(344, 320);
            this.lblDescIRPF.Name = "lblDescIRPF";
            this.lblDescIRPF.Size = new System.Drawing.Size(112, 19);
            this.lblDescIRPF.TabIndex = 18;
            this.lblDescIRPF.Text = "Desconto IRPF";
            // 
            // mskbxSalarioLiq
            // 
            this.mskbxSalarioLiq.Enabled = false;
            this.mskbxSalarioLiq.Location = new System.Drawing.Point(475, 252);
            this.mskbxSalarioLiq.Name = "mskbxSalarioLiq";
            this.mskbxSalarioLiq.Size = new System.Drawing.Size(158, 26);
            this.mskbxSalarioLiq.TabIndex = 19;
            // 
            // mskbxDescINSS
            // 
            this.mskbxDescINSS.Enabled = false;
            this.mskbxDescINSS.Location = new System.Drawing.Point(475, 284);
            this.mskbxDescINSS.Name = "mskbxDescINSS";
            this.mskbxDescINSS.Size = new System.Drawing.Size(158, 26);
            this.mskbxDescINSS.TabIndex = 20;
            // 
            // mskbxDescIRPF
            // 
            this.mskbxDescIRPF.Enabled = false;
            this.mskbxDescIRPF.Location = new System.Drawing.Point(475, 317);
            this.mskbxDescIRPF.Name = "mskbxDescIRPF";
            this.mskbxDescIRPF.Size = new System.Drawing.Size(158, 26);
            this.mskbxDescIRPF.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 368);
            this.Controls.Add(this.mskbxDescIRPF);
            this.Controls.Add(this.mskbxDescINSS);
            this.Controls.Add(this.mskbxSalarioLiq);
            this.Controls.Add(this.lblDescIRPF);
            this.Controls.Add(this.lblDescINSS);
            this.Controls.Add(this.lblSalF);
            this.Controls.Add(this.mskbxSalarioF);
            this.Controls.Add(this.mskbxAliqIRPF);
            this.Controls.Add(this.mskbxAliqINSS);
            this.Controls.Add(this.lblSalL);
            this.Controls.Add(this.lblAIRPF);
            this.Controls.Add(this.lblAINSS);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.chbxCasado);
            this.Controls.Add(this.btnDesconto);
            this.Controls.Add(this.gbxGenero);
            this.Controls.Add(this.mskbxFilhos);
            this.Controls.Add(this.mskbxSalario);
            this.Controls.Add(this.mskbxNome);
            this.Controls.Add(this.lblFilhos);
            this.Controls.Add(this.lblSalBruto);
            this.Controls.Add(this.lblNome);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxGenero.ResumeLayout(false);
            this.gbxGenero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSalBruto;
        private System.Windows.Forms.Label lblFilhos;
        private System.Windows.Forms.MaskedTextBox mskbxNome;
        private System.Windows.Forms.MaskedTextBox mskbxSalario;
        private System.Windows.Forms.MaskedTextBox mskbxFilhos;
        private System.Windows.Forms.GroupBox gbxGenero;
        private System.Windows.Forms.RadioButton rbtnMasculino;
        private System.Windows.Forms.RadioButton rbtnFemino;
        private System.Windows.Forms.Button btnDesconto;
        private System.Windows.Forms.CheckBox chbxCasado;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Label lblAINSS;
        private System.Windows.Forms.Label lblAIRPF;
        private System.Windows.Forms.Label lblSalL;
        private System.Windows.Forms.MaskedTextBox mskbxAliqINSS;
        private System.Windows.Forms.MaskedTextBox mskbxAliqIRPF;
        private System.Windows.Forms.MaskedTextBox mskbxSalarioF;
        private System.Windows.Forms.Label lblSalF;
        private System.Windows.Forms.Label lblDescINSS;
        private System.Windows.Forms.Label lblDescIRPF;
        private System.Windows.Forms.MaskedTextBox mskbxSalarioLiq;
        private System.Windows.Forms.MaskedTextBox mskbxDescINSS;
        private System.Windows.Forms.MaskedTextBox mskbxDescIRPF;
    }
}


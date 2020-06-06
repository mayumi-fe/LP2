namespace Atividade7
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
            this.btnExercicio1 = new System.Windows.Forms.Button();
            this.btnExercicio2 = new System.Windows.Forms.Button();
            this.btnExercicio4 = new System.Windows.Forms.Button();
            this.btnExercicio5 = new System.Windows.Forms.Button();
            this.btnExercicio3 = new System.Windows.Forms.Button();
            this.btnExercicio6 = new System.Windows.Forms.Button();
            this.btnExercicio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExercicio1
            // 
            this.btnExercicio1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExercicio1.Location = new System.Drawing.Point(44, 23);
            this.btnExercicio1.Name = "btnExercicio1";
            this.btnExercicio1.Size = new System.Drawing.Size(119, 65);
            this.btnExercicio1.TabIndex = 0;
            this.btnExercicio1.Text = "Ler 20 números e inverter";
            this.btnExercicio1.UseVisualStyleBackColor = true;
            this.btnExercicio1.Click += new System.EventHandler(this.btnExercicio1_Click);
            // 
            // btnExercicio2
            // 
            this.btnExercicio2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExercicio2.Location = new System.Drawing.Point(44, 104);
            this.btnExercicio2.Name = "btnExercicio2";
            this.btnExercicio2.Size = new System.Drawing.Size(119, 65);
            this.btnExercicio2.TabIndex = 1;
            this.btnExercicio2.Text = "Ler 20 números e inverter (reverse)";
            this.btnExercicio2.UseVisualStyleBackColor = true;
            this.btnExercicio2.Click += new System.EventHandler(this.btnExercicio2_Click);
            // 
            // btnExercicio4
            // 
            this.btnExercicio4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExercicio4.Location = new System.Drawing.Point(211, 23);
            this.btnExercicio4.Name = "btnExercicio4";
            this.btnExercicio4.Size = new System.Drawing.Size(119, 65);
            this.btnExercicio4.TabIndex = 2;
            this.btnExercicio4.Text = "Alunos Total";
            this.btnExercicio4.UseVisualStyleBackColor = true;
            this.btnExercicio4.Click += new System.EventHandler(this.btnExercicio4_Click);
            // 
            // btnExercicio5
            // 
            this.btnExercicio5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExercicio5.Location = new System.Drawing.Point(211, 104);
            this.btnExercicio5.Name = "btnExercicio5";
            this.btnExercicio5.Size = new System.Drawing.Size(119, 65);
            this.btnExercicio5.TabIndex = 3;
            this.btnExercicio5.Text = "Lista Alunos";
            this.btnExercicio5.UseVisualStyleBackColor = true;
            this.btnExercicio5.Click += new System.EventHandler(this.btnExercicio5_Click);
            // 
            // btnExercicio3
            // 
            this.btnExercicio3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExercicio3.Location = new System.Drawing.Point(44, 185);
            this.btnExercicio3.Name = "btnExercicio3";
            this.btnExercicio3.Size = new System.Drawing.Size(119, 65);
            this.btnExercicio3.TabIndex = 4;
            this.btnExercicio3.Text = "Faturamento Mensal";
            this.btnExercicio3.UseVisualStyleBackColor = true;
            this.btnExercicio3.Click += new System.EventHandler(this.btnExercicio3_Click);
            // 
            // btnExercicio6
            // 
            this.btnExercicio6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExercicio6.Location = new System.Drawing.Point(211, 185);
            this.btnExercicio6.Name = "btnExercicio6";
            this.btnExercicio6.Size = new System.Drawing.Size(119, 65);
            this.btnExercicio6.TabIndex = 5;
            this.btnExercicio6.Text = "Notas Alunos";
            this.btnExercicio6.UseVisualStyleBackColor = true;
            this.btnExercicio6.Click += new System.EventHandler(this.btnExercicio6_Click);
            // 
            // btnExercicio
            // 
            this.btnExercicio.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExercicio.Location = new System.Drawing.Point(129, 266);
            this.btnExercicio.Name = "btnExercicio";
            this.btnExercicio.Size = new System.Drawing.Size(119, 65);
            this.btnExercicio.TabIndex = 6;
            this.btnExercicio.Text = "Tamanho dos nomes";
            this.btnExercicio.UseVisualStyleBackColor = true;
            this.btnExercicio.Click += new System.EventHandler(this.btnExercicio_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 338);
            this.Controls.Add(this.btnExercicio);
            this.Controls.Add(this.btnExercicio6);
            this.Controls.Add(this.btnExercicio3);
            this.Controls.Add(this.btnExercicio5);
            this.Controls.Add(this.btnExercicio4);
            this.Controls.Add(this.btnExercicio2);
            this.Controls.Add(this.btnExercicio1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExercicio1;
        private System.Windows.Forms.Button btnExercicio2;
        private System.Windows.Forms.Button btnExercicio4;
        private System.Windows.Forms.Button btnExercicio5;
        private System.Windows.Forms.Button btnExercicio3;
        private System.Windows.Forms.Button btnExercicio6;
        private System.Windows.Forms.Button btnExercicio;
    }
}


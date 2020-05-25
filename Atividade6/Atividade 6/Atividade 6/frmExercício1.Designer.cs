namespace Atividade_6
{
    partial class frmExercício1
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
            this.rchtxtFrase = new System.Windows.Forms.RichTextBox();
            this.btnBranco = new System.Windows.Forms.Button();
            this.btnRs = new System.Windows.Forms.Button();
            this.btnParesLetras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchtxtFrase
            // 
            this.rchtxtFrase.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchtxtFrase.Location = new System.Drawing.Point(12, 23);
            this.rchtxtFrase.Name = "rchtxtFrase";
            this.rchtxtFrase.Size = new System.Drawing.Size(370, 228);
            this.rchtxtFrase.TabIndex = 0;
            this.rchtxtFrase.Text = "";
            // 
            // btnBranco
            // 
            this.btnBranco.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBranco.Location = new System.Drawing.Point(388, 23);
            this.btnBranco.Name = "btnBranco";
            this.btnBranco.Size = new System.Drawing.Size(174, 27);
            this.btnBranco.TabIndex = 1;
            this.btnBranco.Text = "Espaços em branco";
            this.btnBranco.UseVisualStyleBackColor = true;
            this.btnBranco.Click += new System.EventHandler(this.btnBranco_Click);
            // 
            // btnRs
            // 
            this.btnRs.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRs.Location = new System.Drawing.Point(388, 62);
            this.btnRs.Name = "btnRs";
            this.btnRs.Size = new System.Drawing.Size(174, 27);
            this.btnRs.TabIndex = 2;
            this.btnRs.Text = "Número de R(s)";
            this.btnRs.UseVisualStyleBackColor = true;
            this.btnRs.Click += new System.EventHandler(this.btnRs_Click);
            // 
            // btnParesLetras
            // 
            this.btnParesLetras.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParesLetras.Location = new System.Drawing.Point(388, 101);
            this.btnParesLetras.Name = "btnParesLetras";
            this.btnParesLetras.Size = new System.Drawing.Size(174, 27);
            this.btnParesLetras.TabIndex = 3;
            this.btnParesLetras.Text = "Pares de letras";
            this.btnParesLetras.UseVisualStyleBackColor = true;
            this.btnParesLetras.Click += new System.EventHandler(this.btnParesLetras_Click);
            // 
            // frmExercício1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 271);
            this.Controls.Add(this.btnParesLetras);
            this.Controls.Add(this.btnRs);
            this.Controls.Add(this.btnBranco);
            this.Controls.Add(this.rchtxtFrase);
            this.Name = "frmExercício1";
            this.Text = "frmExercício1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchtxtFrase;
        private System.Windows.Forms.Button btnBranco;
        private System.Windows.Forms.Button btnRs;
        private System.Windows.Forms.Button btnParesLetras;
    }
}
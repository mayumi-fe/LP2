namespace Atividade_5___Metodo
{
    partial class frmExercício4
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
            this.rchtxtTexto = new System.Windows.Forms.RichTextBox();
            this.btnNuméricos = new System.Windows.Forms.Button();
            this.btnAlfabeticos = new System.Windows.Forms.Button();
            this.btnBranco = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchtxtTexto
            // 
            this.rchtxtTexto.Location = new System.Drawing.Point(12, 12);
            this.rchtxtTexto.Name = "rchtxtTexto";
            this.rchtxtTexto.Size = new System.Drawing.Size(481, 159);
            this.rchtxtTexto.TabIndex = 0;
            this.rchtxtTexto.Text = "";
            // 
            // btnNuméricos
            // 
            this.btnNuméricos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuméricos.Location = new System.Drawing.Point(12, 204);
            this.btnNuméricos.Name = "btnNuméricos";
            this.btnNuméricos.Size = new System.Drawing.Size(122, 61);
            this.btnNuméricos.TabIndex = 1;
            this.btnNuméricos.Text = "Caracteres Numéricos";
            this.btnNuméricos.UseVisualStyleBackColor = true;
            this.btnNuméricos.Click += new System.EventHandler(this.btnNuméricos_Click);
            // 
            // btnAlfabeticos
            // 
            this.btnAlfabeticos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlfabeticos.Location = new System.Drawing.Point(380, 204);
            this.btnAlfabeticos.Name = "btnAlfabeticos";
            this.btnAlfabeticos.Size = new System.Drawing.Size(113, 61);
            this.btnAlfabeticos.TabIndex = 2;
            this.btnAlfabeticos.Text = "Caracteres alfabéticos";
            this.btnAlfabeticos.UseVisualStyleBackColor = true;
            this.btnAlfabeticos.Click += new System.EventHandler(this.btnAlfabeticos_Click);
            // 
            // btnBranco
            // 
            this.btnBranco.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBranco.Location = new System.Drawing.Point(198, 204);
            this.btnBranco.Name = "btnBranco";
            this.btnBranco.Size = new System.Drawing.Size(120, 61);
            this.btnBranco.TabIndex = 3;
            this.btnBranco.Text = "Primeiro Branco";
            this.btnBranco.UseVisualStyleBackColor = true;
            this.btnBranco.Click += new System.EventHandler(this.btnBranco_Click);
            // 
            // frmExercício4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 276);
            this.Controls.Add(this.btnBranco);
            this.Controls.Add(this.btnAlfabeticos);
            this.Controls.Add(this.btnNuméricos);
            this.Controls.Add(this.rchtxtTexto);
            this.Name = "frmExercício4";
            this.Text = "frmExercício4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchtxtTexto;
        private System.Windows.Forms.Button btnNuméricos;
        private System.Windows.Forms.Button btnAlfabeticos;
        private System.Windows.Forms.Button btnBranco;
    }
}
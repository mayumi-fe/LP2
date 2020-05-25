namespace Atividade_6
{
    partial class frmExercício3
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
            this.btnVerificar = new System.Windows.Forms.Button();
            this.lblSequencia = new System.Windows.Forms.Label();
            this.txtSequencia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnVerificar
            // 
            this.btnVerificar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificar.Location = new System.Drawing.Point(469, 29);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(116, 48);
            this.btnVerificar.TabIndex = 0;
            this.btnVerificar.Text = "Verificar (palíndromo)";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // lblSequencia
            // 
            this.lblSequencia.AutoSize = true;
            this.lblSequencia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSequencia.Location = new System.Drawing.Point(23, 29);
            this.lblSequencia.Name = "lblSequencia";
            this.lblSequencia.Size = new System.Drawing.Size(224, 19);
            this.lblSequencia.TabIndex = 1;
            this.lblSequencia.Text = "Digite uma sequência de caracteres:";
            // 
            // txtSequencia
            // 
            this.txtSequencia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSequencia.Location = new System.Drawing.Point(27, 51);
            this.txtSequencia.Name = "txtSequencia";
            this.txtSequencia.Size = new System.Drawing.Size(404, 26);
            this.txtSequencia.TabIndex = 2;
            // 
            // frmExercício3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 103);
            this.Controls.Add(this.txtSequencia);
            this.Controls.Add(this.lblSequencia);
            this.Controls.Add(this.btnVerificar);
            this.Name = "frmExercício3";
            this.Text = "frmExercício3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label lblSequencia;
        private System.Windows.Forms.TextBox txtSequencia;
    }
}
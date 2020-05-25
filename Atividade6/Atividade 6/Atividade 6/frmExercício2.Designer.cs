namespace Atividade_6
{
    partial class frmExercício2
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
            this.lblNumeroN = new System.Windows.Forms.Label();
            this.lblNumeroH = new System.Windows.Forms.Label();
            this.txtNumeroN = new System.Windows.Forms.TextBox();
            this.txtNumeroH = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumeroN
            // 
            this.lblNumeroN.AutoSize = true;
            this.lblNumeroN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroN.Location = new System.Drawing.Point(33, 28);
            this.lblNumeroN.Name = "lblNumeroN";
            this.lblNumeroN.Size = new System.Drawing.Size(75, 19);
            this.lblNumeroN.TabIndex = 0;
            this.lblNumeroN.Text = "Número N";
            // 
            // lblNumeroH
            // 
            this.lblNumeroH.AutoSize = true;
            this.lblNumeroH.Enabled = false;
            this.lblNumeroH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroH.Location = new System.Drawing.Point(33, 64);
            this.lblNumeroH.Name = "lblNumeroH";
            this.lblNumeroH.Size = new System.Drawing.Size(74, 19);
            this.lblNumeroH.TabIndex = 1;
            this.lblNumeroH.Text = "Número H";
            // 
            // txtNumeroN
            // 
            this.txtNumeroN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroN.Location = new System.Drawing.Point(114, 25);
            this.txtNumeroN.Name = "txtNumeroN";
            this.txtNumeroN.Size = new System.Drawing.Size(100, 26);
            this.txtNumeroN.TabIndex = 2;
            // 
            // txtNumeroH
            // 
            this.txtNumeroH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroH.Location = new System.Drawing.Point(114, 61);
            this.txtNumeroH.Name = "txtNumeroH";
            this.txtNumeroH.Size = new System.Drawing.Size(100, 26);
            this.txtNumeroH.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(255, 40);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(91, 30);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // frmExercício2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 104);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtNumeroH);
            this.Controls.Add(this.txtNumeroN);
            this.Controls.Add(this.lblNumeroH);
            this.Controls.Add(this.lblNumeroN);
            this.Name = "frmExercício2";
            this.Text = "frmExercício2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumeroN;
        private System.Windows.Forms.Label lblNumeroH;
        private System.Windows.Forms.TextBox txtNumeroN;
        private System.Windows.Forms.TextBox txtNumeroH;
        private System.Windows.Forms.Button btnCalcular;
    }
}
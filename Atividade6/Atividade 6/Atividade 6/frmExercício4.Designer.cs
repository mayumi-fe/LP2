namespace Atividade_6
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblInscrição = new System.Windows.Forms.Label();
            this.lblProdução = new System.Windows.Forms.Label();
            this.lblSalário = new System.Windows.Forms.Label();
            this.lblGratificação = new System.Windows.Forms.Label();
            this.lblSalarioBruto = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.txtInscrição = new System.Windows.Forms.TextBox();
            this.txtProdução = new System.Windows.Forms.TextBox();
            this.txtSalário = new System.Windows.Forms.TextBox();
            this.txtGratificação = new System.Windows.Forms.TextBox();
            this.txtSalarioBruto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(418, 131);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(112, 61);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular Salário Bruto";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(22, 34);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(47, 19);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(22, 67);
            this.lblCargo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(47, 19);
            this.lblCargo.TabIndex = 2;
            this.lblCargo.Text = "Cargo";
            // 
            // lblInscrição
            // 
            this.lblInscrição.AutoSize = true;
            this.lblInscrição.Location = new System.Drawing.Point(22, 104);
            this.lblInscrição.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInscrição.Name = "lblInscrição";
            this.lblInscrição.Size = new System.Drawing.Size(84, 19);
            this.lblInscrição.TabIndex = 3;
            this.lblInscrição.Text = "N. Inscrição";
            // 
            // lblProdução
            // 
            this.lblProdução.AutoSize = true;
            this.lblProdução.Location = new System.Drawing.Point(22, 135);
            this.lblProdução.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProdução.Name = "lblProdução";
            this.lblProdução.Size = new System.Drawing.Size(68, 19);
            this.lblProdução.TabIndex = 4;
            this.lblProdução.Text = "Produção";
            // 
            // lblSalário
            // 
            this.lblSalário.AutoSize = true;
            this.lblSalário.Location = new System.Drawing.Point(22, 169);
            this.lblSalário.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalário.Name = "lblSalário";
            this.lblSalário.Size = new System.Drawing.Size(51, 19);
            this.lblSalário.TabIndex = 5;
            this.lblSalário.Text = "Salário";
            // 
            // lblGratificação
            // 
            this.lblGratificação.AutoSize = true;
            this.lblGratificação.Location = new System.Drawing.Point(22, 203);
            this.lblGratificação.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGratificação.Name = "lblGratificação";
            this.lblGratificação.Size = new System.Drawing.Size(82, 19);
            this.lblGratificação.TabIndex = 6;
            this.lblGratificação.Text = "Gratificação";
            // 
            // lblSalarioBruto
            // 
            this.lblSalarioBruto.AutoSize = true;
            this.lblSalarioBruto.Location = new System.Drawing.Point(22, 237);
            this.lblSalarioBruto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalarioBruto.Name = "lblSalarioBruto";
            this.lblSalarioBruto.Size = new System.Drawing.Size(89, 19);
            this.lblSalarioBruto.TabIndex = 7;
            this.lblSalarioBruto.Text = "Salário Bruto";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(119, 31);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(445, 26);
            this.txtNome.TabIndex = 8;
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(119, 67);
            this.txtCargo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(231, 26);
            this.txtCargo.TabIndex = 9;
            // 
            // txtInscrição
            // 
            this.txtInscrição.Location = new System.Drawing.Point(119, 101);
            this.txtInscrição.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInscrição.Name = "txtInscrição";
            this.txtInscrição.Size = new System.Drawing.Size(231, 26);
            this.txtInscrição.TabIndex = 10;
            // 
            // txtProdução
            // 
            this.txtProdução.Location = new System.Drawing.Point(119, 132);
            this.txtProdução.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProdução.Name = "txtProdução";
            this.txtProdução.Size = new System.Drawing.Size(231, 26);
            this.txtProdução.TabIndex = 11;
            // 
            // txtSalário
            // 
            this.txtSalário.Location = new System.Drawing.Point(119, 166);
            this.txtSalário.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSalário.Name = "txtSalário";
            this.txtSalário.Size = new System.Drawing.Size(231, 26);
            this.txtSalário.TabIndex = 12;
            // 
            // txtGratificação
            // 
            this.txtGratificação.Location = new System.Drawing.Point(119, 200);
            this.txtGratificação.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGratificação.Name = "txtGratificação";
            this.txtGratificação.Size = new System.Drawing.Size(231, 26);
            this.txtGratificação.TabIndex = 13;
            // 
            // txtSalarioBruto
            // 
            this.txtSalarioBruto.Enabled = false;
            this.txtSalarioBruto.Location = new System.Drawing.Point(119, 234);
            this.txtSalarioBruto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSalarioBruto.Name = "txtSalarioBruto";
            this.txtSalarioBruto.Size = new System.Drawing.Size(231, 26);
            this.txtSalarioBruto.TabIndex = 14;
            // 
            // frmExercício4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 283);
            this.Controls.Add(this.txtSalarioBruto);
            this.Controls.Add(this.txtGratificação);
            this.Controls.Add(this.txtSalário);
            this.Controls.Add(this.txtProdução);
            this.Controls.Add(this.txtInscrição);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblSalarioBruto);
            this.Controls.Add(this.lblGratificação);
            this.Controls.Add(this.lblSalário);
            this.Controls.Add(this.lblProdução);
            this.Controls.Add(this.lblInscrição);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnCalcular);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmExercício4";
            this.Text = "frmExercício4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblInscrição;
        private System.Windows.Forms.Label lblProdução;
        private System.Windows.Forms.Label lblSalário;
        private System.Windows.Forms.Label lblGratificação;
        private System.Windows.Forms.Label lblSalarioBruto;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtInscrição;
        private System.Windows.Forms.TextBox txtProdução;
        private System.Windows.Forms.TextBox txtSalário;
        private System.Windows.Forms.TextBox txtGratificação;
        private System.Windows.Forms.TextBox txtSalarioBruto;
    }
}
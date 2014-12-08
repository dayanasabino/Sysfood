namespace SysFood.Forms
{
    partial class FrmFinalizadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFinalizadora));
            this.CmbFinalizadora = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.LblParcelas = new System.Windows.Forms.Label();
            this.TxtParcelas = new System.Windows.Forms.TextBox();
            this.LblValor = new System.Windows.Forms.Label();
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CmbFinalizadora
            // 
            this.CmbFinalizadora.FormattingEnabled = true;
            this.CmbFinalizadora.Location = new System.Drawing.Point(96, 47);
            this.CmbFinalizadora.Name = "CmbFinalizadora";
            this.CmbFinalizadora.Size = new System.Drawing.Size(206, 21);
            this.CmbFinalizadora.TabIndex = 0;
            this.CmbFinalizadora.SelectedIndexChanged += new System.EventHandler(this.CmbFinalizadora_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Finalizadora:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(113, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 126;
            this.label6.Text = "Total:";
            // 
            // TxtTotal
            // 
            this.TxtTotal.Enabled = false;
            this.TxtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotal.Location = new System.Drawing.Point(167, 164);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(135, 26);
            this.TxtTotal.TabIndex = 125;
            this.TxtTotal.Text = "0";
            this.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.BackColor = System.Drawing.SystemColors.Control;
            this.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSalvar.Location = new System.Drawing.Point(100, 213);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(98, 23);
            this.BtnSalvar.TabIndex = 127;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = false;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCancelar.Location = new System.Drawing.Point(204, 213);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(98, 23);
            this.BtnCancelar.TabIndex = 128;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            // 
            // LblParcelas
            // 
            this.LblParcelas.AutoSize = true;
            this.LblParcelas.Location = new System.Drawing.Point(39, 107);
            this.LblParcelas.Name = "LblParcelas";
            this.LblParcelas.Size = new System.Drawing.Size(51, 13);
            this.LblParcelas.TabIndex = 129;
            this.LblParcelas.Text = "Parcelas:";
            // 
            // TxtParcelas
            // 
            this.TxtParcelas.Location = new System.Drawing.Point(96, 104);
            this.TxtParcelas.Name = "TxtParcelas";
            this.TxtParcelas.Size = new System.Drawing.Size(80, 20);
            this.TxtParcelas.TabIndex = 130;
            this.TxtParcelas.Text = "1";
            this.TxtParcelas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtParcelas.TextChanged += new System.EventHandler(this.TxtParcelas_TextChanged);
            // 
            // LblValor
            // 
            this.LblValor.AutoSize = true;
            this.LblValor.Location = new System.Drawing.Point(182, 107);
            this.LblValor.Name = "LblValor";
            this.LblValor.Size = new System.Drawing.Size(34, 13);
            this.LblValor.TabIndex = 131;
            this.LblValor.Text = "Valor:";
            // 
            // TxtValor
            // 
            this.TxtValor.Location = new System.Drawing.Point(222, 104);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(80, 20);
            this.TxtValor.TabIndex = 132;
            this.TxtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FrmFinalizadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(321, 271);
            this.Controls.Add(this.TxtValor);
            this.Controls.Add(this.LblValor);
            this.Controls.Add(this.TxtParcelas);
            this.Controls.Add(this.LblParcelas);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbFinalizadora);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmFinalizadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forma de Pagamento";
            this.Load += new System.EventHandler(this.FrmFinalizadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbFinalizadora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Label LblParcelas;
        private System.Windows.Forms.TextBox TxtParcelas;
        private System.Windows.Forms.Label LblValor;
        private System.Windows.Forms.TextBox TxtValor;
    }
}
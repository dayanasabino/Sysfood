namespace SysFood.Forms
{
    partial class FrmRecebimentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRecebimentos));
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.CkbStatus = new System.Windows.Forms.CheckBox();
            this.DtpDataCadastro = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnBuscaCliente = new System.Windows.Forms.Button();
            this.CmbCliente = new System.Windows.Forms.ComboBox();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtDescricao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbQuitado = new System.Windows.Forms.ComboBox();
            this.TxtVenda = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtFinalizadora = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtParcelas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.BackColor = System.Drawing.SystemColors.Control;
            this.BtnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnExcluir.Location = new System.Drawing.Point(246, 194);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(98, 23);
            this.BtnExcluir.TabIndex = 121;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = false;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCancelar.Location = new System.Drawing.Point(350, 194);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(98, 23);
            this.BtnCancelar.TabIndex = 120;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBuscar.Location = new System.Drawing.Point(142, 194);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(98, 23);
            this.BtnBuscar.TabIndex = 119;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.BackColor = System.Drawing.SystemColors.Control;
            this.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSalvar.Location = new System.Drawing.Point(38, 194);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(98, 23);
            this.BtnSalvar.TabIndex = 118;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = false;
            // 
            // CkbStatus
            // 
            this.CkbStatus.AutoSize = true;
            this.CkbStatus.Checked = true;
            this.CkbStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CkbStatus.Enabled = false;
            this.CkbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CkbStatus.Location = new System.Drawing.Point(402, 20);
            this.CkbStatus.Name = "CkbStatus";
            this.CkbStatus.Size = new System.Drawing.Size(48, 17);
            this.CkbStatus.TabIndex = 117;
            this.CkbStatus.Text = "Ativo";
            this.CkbStatus.UseVisualStyleBackColor = true;
            // 
            // DtpDataCadastro
            // 
            this.DtpDataCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDataCadastro.Location = new System.Drawing.Point(322, 47);
            this.DtpDataCadastro.Name = "DtpDataCadastro";
            this.DtpDataCadastro.Size = new System.Drawing.Size(128, 20);
            this.DtpDataCadastro.TabIndex = 116;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 115;
            this.label2.Text = "Data Cadastro:";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Enabled = false;
            this.TxtCodigo.Location = new System.Drawing.Point(74, 47);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(85, 20);
            this.TxtCodigo.TabIndex = 114;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 113;
            this.label1.Text = "Código:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 124;
            this.label3.Text = "Cliente:";
            // 
            // BtnBuscaCliente
            // 
            this.BtnBuscaCliente.BackColor = System.Drawing.SystemColors.Control;
            this.BtnBuscaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBuscaCliente.Location = new System.Drawing.Point(414, 99);
            this.BtnBuscaCliente.Name = "BtnBuscaCliente";
            this.BtnBuscaCliente.Size = new System.Drawing.Size(36, 23);
            this.BtnBuscaCliente.TabIndex = 123;
            this.BtnBuscaCliente.Text = "...";
            this.BtnBuscaCliente.UseVisualStyleBackColor = false;
            // 
            // CmbCliente
            // 
            this.CmbCliente.FormattingEnabled = true;
            this.CmbCliente.Location = new System.Drawing.Point(74, 99);
            this.CmbCliente.Name = "CmbCliente";
            this.CmbCliente.Size = new System.Drawing.Size(335, 21);
            this.CmbCliente.TabIndex = 122;
            // 
            // TxtTotal
            // 
            this.TxtTotal.Enabled = false;
            this.TxtTotal.Location = new System.Drawing.Point(350, 152);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(100, 20);
            this.TxtTotal.TabIndex = 126;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(280, 155);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 125;
            this.label13.Text = "Valor Total:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 128;
            this.label5.Text = "Descrição:";
            // 
            // TxtDescricao
            // 
            this.TxtDescricao.Enabled = false;
            this.TxtDescricao.Location = new System.Drawing.Point(74, 126);
            this.TxtDescricao.Name = "TxtDescricao";
            this.TxtDescricao.Size = new System.Drawing.Size(376, 20);
            this.TxtDescricao.TabIndex = 127;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 129;
            this.label4.Text = "Quitado?";
            // 
            // CmbQuitado
            // 
            this.CmbQuitado.FormattingEnabled = true;
            this.CmbQuitado.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.CmbQuitado.Location = new System.Drawing.Point(74, 152);
            this.CmbQuitado.Name = "CmbQuitado";
            this.CmbQuitado.Size = new System.Drawing.Size(85, 21);
            this.CmbQuitado.TabIndex = 130;
            // 
            // TxtVenda
            // 
            this.TxtVenda.Location = new System.Drawing.Point(74, 73);
            this.TxtVenda.Name = "TxtVenda";
            this.TxtVenda.Size = new System.Drawing.Size(107, 20);
            this.TxtVenda.TabIndex = 134;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 133;
            this.label6.Text = "Nº Nota:";
            // 
            // TxtFinalizadora
            // 
            this.TxtFinalizadora.Enabled = false;
            this.TxtFinalizadora.Location = new System.Drawing.Point(343, 73);
            this.TxtFinalizadora.Name = "TxtFinalizadora";
            this.TxtFinalizadora.Size = new System.Drawing.Size(107, 20);
            this.TxtFinalizadora.TabIndex = 135;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(271, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 136;
            this.label7.Text = "Finalizadora:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(165, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 137;
            this.label8.Text = "Parcelas:";
            // 
            // TxtParcelas
            // 
            this.TxtParcelas.Enabled = false;
            this.TxtParcelas.Location = new System.Drawing.Point(216, 152);
            this.TxtParcelas.Name = "TxtParcelas";
            this.TxtParcelas.Size = new System.Drawing.Size(58, 20);
            this.TxtParcelas.TabIndex = 138;
            // 
            // FrmRecebimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(474, 243);
            this.Controls.Add(this.TxtParcelas);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtFinalizadora);
            this.Controls.Add(this.TxtVenda);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CmbQuitado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtDescricao);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnBuscaCliente);
            this.Controls.Add(this.CmbCliente);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.CkbStatus);
            this.Controls.Add(this.DtpDataCadastro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRecebimentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contas a Receber";
            this.Load += new System.EventHandler(this.FrmRecebimentos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.CheckBox CkbStatus;
        private System.Windows.Forms.DateTimePicker DtpDataCadastro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnBuscaCliente;
        private System.Windows.Forms.ComboBox CmbCliente;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtDescricao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbQuitado;
        private System.Windows.Forms.TextBox TxtVenda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtFinalizadora;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtParcelas;
    }
}
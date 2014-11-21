namespace SysFood.Forms
{
    partial class FrmPerfilUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPerfilUsuario));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtDescricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CkbRelatorios = new System.Windows.Forms.CheckBox();
            this.CkbContasaReceber = new System.Windows.Forms.CheckBox();
            this.CkbTelefone = new System.Windows.Forms.CheckBox();
            this.CkbComanda = new System.Windows.Forms.CheckBox();
            this.CkbUsuario = new System.Windows.Forms.CheckBox();
            this.CkbMercadoria = new System.Windows.Forms.CheckBox();
            this.CkbPerfildeUsuario = new System.Windows.Forms.CheckBox();
            this.CkbGrupo = new System.Windows.Forms.CheckBox();
            this.CkbFormadePagamento = new System.Windows.Forms.CheckBox();
            this.CkbEmpresa = new System.Windows.Forms.CheckBox();
            this.CkbCliente = new System.Windows.Forms.CheckBox();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.CkbStatus = new System.Windows.Forms.CheckBox();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CkbStatus);
            this.groupBox1.Controls.Add(this.TxtCodigo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtDescricao);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 93);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Perfil";
            // 
            // TxtDescricao
            // 
            this.TxtDescricao.Location = new System.Drawing.Point(70, 53);
            this.TxtDescricao.Name = "TxtDescricao";
            this.TxtDescricao.Size = new System.Drawing.Size(239, 20);
            this.TxtDescricao.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CkbRelatorios);
            this.groupBox2.Controls.Add(this.CkbContasaReceber);
            this.groupBox2.Controls.Add(this.CkbTelefone);
            this.groupBox2.Controls.Add(this.CkbComanda);
            this.groupBox2.Controls.Add(this.CkbUsuario);
            this.groupBox2.Controls.Add(this.CkbMercadoria);
            this.groupBox2.Controls.Add(this.CkbPerfildeUsuario);
            this.groupBox2.Controls.Add(this.CkbGrupo);
            this.groupBox2.Controls.Add(this.CkbFormadePagamento);
            this.groupBox2.Controls.Add(this.CkbEmpresa);
            this.groupBox2.Controls.Add(this.CkbCliente);
            this.groupBox2.Location = new System.Drawing.Point(12, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 207);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Permissões";
            // 
            // CkbRelatorios
            // 
            this.CkbRelatorios.AutoSize = true;
            this.CkbRelatorios.Location = new System.Drawing.Point(197, 104);
            this.CkbRelatorios.Name = "CkbRelatorios";
            this.CkbRelatorios.Size = new System.Drawing.Size(73, 17);
            this.CkbRelatorios.TabIndex = 10;
            this.CkbRelatorios.Text = "Relatórios";
            this.CkbRelatorios.UseVisualStyleBackColor = true;
            // 
            // CkbContasaReceber
            // 
            this.CkbContasaReceber.AutoSize = true;
            this.CkbContasaReceber.Location = new System.Drawing.Point(197, 81);
            this.CkbContasaReceber.Name = "CkbContasaReceber";
            this.CkbContasaReceber.Size = new System.Drawing.Size(94, 17);
            this.CkbContasaReceber.TabIndex = 9;
            this.CkbContasaReceber.Text = "Recebimentos";
            this.CkbContasaReceber.UseVisualStyleBackColor = true;
            // 
            // CkbTelefone
            // 
            this.CkbTelefone.AutoSize = true;
            this.CkbTelefone.Location = new System.Drawing.Point(197, 58);
            this.CkbTelefone.Name = "CkbTelefone";
            this.CkbTelefone.Size = new System.Drawing.Size(68, 17);
            this.CkbTelefone.TabIndex = 8;
            this.CkbTelefone.Text = "Telefone";
            this.CkbTelefone.UseVisualStyleBackColor = true;
            // 
            // CkbComanda
            // 
            this.CkbComanda.AutoSize = true;
            this.CkbComanda.Location = new System.Drawing.Point(197, 35);
            this.CkbComanda.Name = "CkbComanda";
            this.CkbComanda.Size = new System.Drawing.Size(71, 17);
            this.CkbComanda.TabIndex = 7;
            this.CkbComanda.Text = "Comanda";
            this.CkbComanda.UseVisualStyleBackColor = true;
            // 
            // CkbUsuario
            // 
            this.CkbUsuario.AutoSize = true;
            this.CkbUsuario.Location = new System.Drawing.Point(31, 173);
            this.CkbUsuario.Name = "CkbUsuario";
            this.CkbUsuario.Size = new System.Drawing.Size(62, 17);
            this.CkbUsuario.TabIndex = 6;
            this.CkbUsuario.Text = "Usuário";
            this.CkbUsuario.UseVisualStyleBackColor = true;
            // 
            // CkbMercadoria
            // 
            this.CkbMercadoria.AutoSize = true;
            this.CkbMercadoria.Location = new System.Drawing.Point(31, 150);
            this.CkbMercadoria.Name = "CkbMercadoria";
            this.CkbMercadoria.Size = new System.Drawing.Size(79, 17);
            this.CkbMercadoria.TabIndex = 5;
            this.CkbMercadoria.Text = "Mercadoria";
            this.CkbMercadoria.UseVisualStyleBackColor = true;
            // 
            // CkbPerfildeUsuario
            // 
            this.CkbPerfildeUsuario.AutoSize = true;
            this.CkbPerfildeUsuario.Location = new System.Drawing.Point(31, 127);
            this.CkbPerfildeUsuario.Name = "CkbPerfildeUsuario";
            this.CkbPerfildeUsuario.Size = new System.Drawing.Size(103, 17);
            this.CkbPerfildeUsuario.TabIndex = 4;
            this.CkbPerfildeUsuario.Text = "Perfil de Usuário";
            this.CkbPerfildeUsuario.UseVisualStyleBackColor = true;
            // 
            // CkbGrupo
            // 
            this.CkbGrupo.AutoSize = true;
            this.CkbGrupo.Location = new System.Drawing.Point(31, 104);
            this.CkbGrupo.Name = "CkbGrupo";
            this.CkbGrupo.Size = new System.Drawing.Size(55, 17);
            this.CkbGrupo.TabIndex = 3;
            this.CkbGrupo.Text = "Grupo";
            this.CkbGrupo.UseVisualStyleBackColor = true;
            // 
            // CkbFormadePagamento
            // 
            this.CkbFormadePagamento.AutoSize = true;
            this.CkbFormadePagamento.Location = new System.Drawing.Point(31, 81);
            this.CkbFormadePagamento.Name = "CkbFormadePagamento";
            this.CkbFormadePagamento.Size = new System.Drawing.Size(127, 17);
            this.CkbFormadePagamento.TabIndex = 2;
            this.CkbFormadePagamento.Text = "Forma de Pagamento";
            this.CkbFormadePagamento.UseVisualStyleBackColor = true;
            // 
            // CkbEmpresa
            // 
            this.CkbEmpresa.AutoSize = true;
            this.CkbEmpresa.Location = new System.Drawing.Point(31, 58);
            this.CkbEmpresa.Name = "CkbEmpresa";
            this.CkbEmpresa.Size = new System.Drawing.Size(67, 17);
            this.CkbEmpresa.TabIndex = 1;
            this.CkbEmpresa.Text = "Empresa";
            this.CkbEmpresa.UseVisualStyleBackColor = true;
            // 
            // CkbCliente
            // 
            this.CkbCliente.AutoSize = true;
            this.CkbCliente.Location = new System.Drawing.Point(31, 35);
            this.CkbCliente.Name = "CkbCliente";
            this.CkbCliente.Size = new System.Drawing.Size(58, 17);
            this.CkbCliente.TabIndex = 0;
            this.CkbCliente.Text = "Cliente";
            this.CkbCliente.UseVisualStyleBackColor = true;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.BackColor = System.Drawing.SystemColors.Control;
            this.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSalvar.Location = new System.Drawing.Point(12, 335);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(98, 23);
            this.BtnSalvar.TabIndex = 5;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = false;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBuscar.Location = new System.Drawing.Point(126, 335);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(98, 23);
            this.BtnBuscar.TabIndex = 6;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCancelar.Location = new System.Drawing.Point(240, 335);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(98, 23);
            this.BtnCancelar.TabIndex = 7;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // CkbStatus
            // 
            this.CkbStatus.AutoSize = true;
            this.CkbStatus.Checked = true;
            this.CkbStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CkbStatus.Enabled = false;
            this.CkbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CkbStatus.Location = new System.Drawing.Point(261, 26);
            this.CkbStatus.Name = "CkbStatus";
            this.CkbStatus.Size = new System.Drawing.Size(48, 17);
            this.CkbStatus.TabIndex = 8;
            this.CkbStatus.Text = "Ativo";
            this.CkbStatus.UseVisualStyleBackColor = true;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Enabled = false;
            this.TxtCodigo.Location = new System.Drawing.Point(70, 27);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(85, 20);
            this.TxtCodigo.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Código:";
            // 
            // FrmPerfilUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(350, 379);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPerfilUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuração de Perfil de Usuário";
            this.Load += new System.EventHandler(this.FrmPerfilUsuario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtDescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox CkbCliente;
        private System.Windows.Forms.CheckBox CkbEmpresa;
        private System.Windows.Forms.CheckBox CkbMercadoria;
        private System.Windows.Forms.CheckBox CkbPerfildeUsuario;
        private System.Windows.Forms.CheckBox CkbGrupo;
        private System.Windows.Forms.CheckBox CkbFormadePagamento;
        private System.Windows.Forms.CheckBox CkbTelefone;
        private System.Windows.Forms.CheckBox CkbComanda;
        private System.Windows.Forms.CheckBox CkbUsuario;
        private System.Windows.Forms.CheckBox CkbRelatorios;
        private System.Windows.Forms.CheckBox CkbContasaReceber;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.CheckBox CkbStatus;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label2;
    }
}
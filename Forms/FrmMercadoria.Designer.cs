namespace SysFood.Forms
{
    partial class FrmMercadoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMercadoria));
            this.CkbStatus = new System.Windows.Forms.CheckBox();
            this.DtpDataCadastro = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCodigoBarras = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtDescricao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CmbGrupo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtPrecoCusto = new System.Windows.Forms.TextBox();
            this.TxtPrecoVenda = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtEstoque = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CmbTipoItem = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtUnidade = new System.Windows.Forms.TextBox();
            this.TxtValidade = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtMarca = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtObservacao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CkbStatus
            // 
            this.CkbStatus.AutoSize = true;
            this.CkbStatus.Checked = true;
            this.CkbStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CkbStatus.Enabled = false;
            this.CkbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CkbStatus.Location = new System.Drawing.Point(374, 17);
            this.CkbStatus.Name = "CkbStatus";
            this.CkbStatus.Size = new System.Drawing.Size(48, 17);
            this.CkbStatus.TabIndex = 130;
            this.CkbStatus.Text = "Ativo";
            this.CkbStatus.UseVisualStyleBackColor = true;
            // 
            // DtpDataCadastro
            // 
            this.DtpDataCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDataCadastro.Location = new System.Drawing.Point(294, 44);
            this.DtpDataCadastro.Name = "DtpDataCadastro";
            this.DtpDataCadastro.Size = new System.Drawing.Size(128, 20);
            this.DtpDataCadastro.TabIndex = 129;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 128;
            this.label2.Text = "Data Cadastro:";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Enabled = false;
            this.TxtCodigo.Location = new System.Drawing.Point(80, 44);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(85, 20);
            this.TxtCodigo.TabIndex = 127;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 126;
            this.label1.Text = "Código:";
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.BackColor = System.Drawing.SystemColors.Control;
            this.BtnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnExcluir.Location = new System.Drawing.Point(226, 338);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(98, 23);
            this.BtnExcluir.TabIndex = 125;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = false;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCancelar.Location = new System.Drawing.Point(330, 338);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(98, 23);
            this.BtnCancelar.TabIndex = 124;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBuscar.Location = new System.Drawing.Point(122, 338);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(98, 23);
            this.BtnBuscar.TabIndex = 123;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.BackColor = System.Drawing.SystemColors.Control;
            this.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSalvar.Location = new System.Drawing.Point(18, 338);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(98, 23);
            this.BtnSalvar.TabIndex = 122;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = false;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 131;
            this.label3.Text = "Código de Barras:";
            // 
            // TxtCodigoBarras
            // 
            this.TxtCodigoBarras.Location = new System.Drawing.Point(123, 84);
            this.TxtCodigoBarras.Name = "TxtCodigoBarras";
            this.TxtCodigoBarras.Size = new System.Drawing.Size(100, 20);
            this.TxtCodigoBarras.TabIndex = 132;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 133;
            this.label4.Text = "Descrição:";
            // 
            // TxtDescricao
            // 
            this.TxtDescricao.Location = new System.Drawing.Point(123, 110);
            this.TxtDescricao.Name = "TxtDescricao";
            this.TxtDescricao.Size = new System.Drawing.Size(299, 20);
            this.TxtDescricao.TabIndex = 134;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 135;
            this.label5.Text = "Grupo:";
            // 
            // CmbGrupo
            // 
            this.CmbGrupo.FormattingEnabled = true;
            this.CmbGrupo.Location = new System.Drawing.Point(274, 83);
            this.CmbGrupo.Name = "CmbGrupo";
            this.CmbGrupo.Size = new System.Drawing.Size(148, 21);
            this.CmbGrupo.TabIndex = 136;
            this.CmbGrupo.SelectedIndexChanged += new System.EventHandler(this.CmbGrupo_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 137;
            this.label6.Text = "Preço de Custo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(229, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 138;
            this.label7.Text = "Preço de Venda:";
            // 
            // TxtPrecoCusto
            // 
            this.TxtPrecoCusto.Location = new System.Drawing.Point(123, 136);
            this.TxtPrecoCusto.Name = "TxtPrecoCusto";
            this.TxtPrecoCusto.Size = new System.Drawing.Size(100, 20);
            this.TxtPrecoCusto.TabIndex = 139;
            // 
            // TxtPrecoVenda
            // 
            this.TxtPrecoVenda.Location = new System.Drawing.Point(322, 136);
            this.TxtPrecoVenda.Name = "TxtPrecoVenda";
            this.TxtPrecoVenda.Size = new System.Drawing.Size(100, 20);
            this.TxtPrecoVenda.TabIndex = 140;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(68, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 141;
            this.label8.Text = "Estoque:";
            // 
            // TxtEstoque
            // 
            this.TxtEstoque.Location = new System.Drawing.Point(123, 162);
            this.TxtEstoque.Name = "TxtEstoque";
            this.TxtEstoque.Size = new System.Drawing.Size(100, 20);
            this.TxtEstoque.TabIndex = 142;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(229, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 143;
            this.label9.Text = "Tipo de Item:";
            // 
            // CmbTipoItem
            // 
            this.CmbTipoItem.FormattingEnabled = true;
            this.CmbTipoItem.Items.AddRange(new object[] {
            "Revenda",
            "Uso e Consumo"});
            this.CmbTipoItem.Location = new System.Drawing.Point(303, 162);
            this.CmbTipoItem.Name = "CmbTipoItem";
            this.CmbTipoItem.Size = new System.Drawing.Size(119, 21);
            this.CmbTipoItem.TabIndex = 144;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(67, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 145;
            this.label10.Text = "Unidade:";
            // 
            // TxtUnidade
            // 
            this.TxtUnidade.Location = new System.Drawing.Point(123, 188);
            this.TxtUnidade.Name = "TxtUnidade";
            this.TxtUnidade.Size = new System.Drawing.Size(100, 20);
            this.TxtUnidade.TabIndex = 146;
            // 
            // TxtValidade
            // 
            this.TxtValidade.Location = new System.Drawing.Point(322, 188);
            this.TxtValidade.Name = "TxtValidade";
            this.TxtValidade.Size = new System.Drawing.Size(100, 20);
            this.TxtValidade.TabIndex = 147;
            this.TxtValidade.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(237, 191);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 13);
            this.label11.TabIndex = 148;
            this.label11.Text = "Validade (dias):";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(77, 217);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 149;
            this.label12.Text = "Marca:";
            // 
            // TxtMarca
            // 
            this.TxtMarca.Location = new System.Drawing.Point(123, 214);
            this.TxtMarca.Name = "TxtMarca";
            this.TxtMarca.Size = new System.Drawing.Size(299, 20);
            this.TxtMarca.TabIndex = 150;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(49, 245);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 13);
            this.label13.TabIndex = 151;
            this.label13.Text = "Observação:";
            // 
            // TxtObservacao
            // 
            this.TxtObservacao.Location = new System.Drawing.Point(123, 242);
            this.TxtObservacao.Multiline = true;
            this.TxtObservacao.Name = "TxtObservacao";
            this.TxtObservacao.Size = new System.Drawing.Size(299, 70);
            this.TxtObservacao.TabIndex = 152;
            // 
            // FrmMercadoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(447, 382);
            this.Controls.Add(this.TxtObservacao);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TxtMarca);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TxtValidade);
            this.Controls.Add(this.TxtUnidade);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CmbTipoItem);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtEstoque);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtPrecoVenda);
            this.Controls.Add(this.TxtPrecoCusto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CmbGrupo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtDescricao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtCodigoBarras);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CkbStatus);
            this.Controls.Add(this.DtpDataCadastro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.BtnSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMercadoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mercadoria";
            this.Load += new System.EventHandler(this.FrmMercadoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CkbStatus;
        private System.Windows.Forms.DateTimePicker DtpDataCadastro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtCodigoBarras;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtDescricao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CmbGrupo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtPrecoCusto;
        private System.Windows.Forms.TextBox TxtPrecoVenda;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtEstoque;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CmbTipoItem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtUnidade;
        private System.Windows.Forms.TextBox TxtValidade;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtMarca;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtObservacao;
    }
}
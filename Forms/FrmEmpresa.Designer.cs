namespace SysFood.Forms
{
    partial class FrmEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmpresa));
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.CkbStatus = new System.Windows.Forms.CheckBox();
            this.DtpDataCadastro = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtIe = new System.Windows.Forms.TextBox();
            this.MtbCnpj = new System.Windows.Forms.MaskedTextBox();
            this.TxtCnae = new System.Windows.Forms.TextBox();
            this.TxtIm = new System.Windows.Forms.TextBox();
            this.TxtObservacao = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.MtbFax = new System.Windows.Forms.MaskedTextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.MtbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.TxtComplemento = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.MtbCep = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.CmbCidade = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.CmbEstado = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TxtBairro = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtEndereco = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtRazaoSocial = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtNomeFantasia = new System.Windows.Forms.TextBox();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCancelar.Location = new System.Drawing.Point(345, 398);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(98, 23);
            this.BtnCancelar.TabIndex = 22;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBuscar.Location = new System.Drawing.Point(137, 398);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(98, 23);
            this.BtnBuscar.TabIndex = 21;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.BackColor = System.Drawing.SystemColors.Control;
            this.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSalvar.Location = new System.Drawing.Point(33, 398);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(98, 23);
            this.BtnSalvar.TabIndex = 20;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = false;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // CkbStatus
            // 
            this.CkbStatus.AutoSize = true;
            this.CkbStatus.Checked = true;
            this.CkbStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CkbStatus.Enabled = false;
            this.CkbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CkbStatus.Location = new System.Drawing.Point(394, 23);
            this.CkbStatus.Name = "CkbStatus";
            this.CkbStatus.Size = new System.Drawing.Size(48, 17);
            this.CkbStatus.TabIndex = 19;
            this.CkbStatus.Text = "Ativo";
            this.CkbStatus.UseVisualStyleBackColor = true;
            // 
            // DtpDataCadastro
            // 
            this.DtpDataCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDataCadastro.Location = new System.Drawing.Point(314, 50);
            this.DtpDataCadastro.Name = "DtpDataCadastro";
            this.DtpDataCadastro.Size = new System.Drawing.Size(128, 20);
            this.DtpDataCadastro.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Data Cadastro:";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Enabled = false;
            this.TxtCodigo.Location = new System.Drawing.Point(109, 50);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(85, 20);
            this.TxtCodigo.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Código:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "CNPJ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Insc. Estadual:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(246, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Insc. Municipal:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "CNAE:";
            // 
            // TxtIe
            // 
            this.TxtIe.Location = new System.Drawing.Point(329, 82);
            this.TxtIe.Name = "TxtIe";
            this.TxtIe.Size = new System.Drawing.Size(113, 20);
            this.TxtIe.TabIndex = 28;
            // 
            // MtbCnpj
            // 
            this.MtbCnpj.Location = new System.Drawing.Point(109, 82);
            this.MtbCnpj.Mask = "00.000.000/0000-00";
            this.MtbCnpj.Name = "MtbCnpj";
            this.MtbCnpj.Size = new System.Drawing.Size(120, 20);
            this.MtbCnpj.TabIndex = 29;
            // 
            // TxtCnae
            // 
            this.TxtCnae.Location = new System.Drawing.Point(109, 108);
            this.TxtCnae.Name = "TxtCnae";
            this.TxtCnae.Size = new System.Drawing.Size(120, 20);
            this.TxtCnae.TabIndex = 30;
            // 
            // TxtIm
            // 
            this.TxtIm.Location = new System.Drawing.Point(329, 108);
            this.TxtIm.Name = "TxtIm";
            this.TxtIm.Size = new System.Drawing.Size(113, 20);
            this.TxtIm.TabIndex = 31;
            // 
            // TxtObservacao
            // 
            this.TxtObservacao.Location = new System.Drawing.Point(108, 343);
            this.TxtObservacao.Name = "TxtObservacao";
            this.TxtObservacao.Size = new System.Drawing.Size(334, 20);
            this.TxtObservacao.TabIndex = 88;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(35, 346);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(68, 13);
            this.label21.TabIndex = 87;
            this.label21.Text = "Observação:";
            // 
            // MtbFax
            // 
            this.MtbFax.Location = new System.Drawing.Point(309, 291);
            this.MtbFax.Mask = "(99) 0000-0000";
            this.MtbFax.Name = "MtbFax";
            this.MtbFax.Size = new System.Drawing.Size(133, 20);
            this.MtbFax.TabIndex = 86;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(108, 317);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(334, 20);
            this.TxtEmail.TabIndex = 85;
            // 
            // MtbTelefone
            // 
            this.MtbTelefone.Location = new System.Drawing.Point(109, 291);
            this.MtbTelefone.Mask = "(99) 0000-0000";
            this.MtbTelefone.Name = "MtbTelefone";
            this.MtbTelefone.Size = new System.Drawing.Size(133, 20);
            this.MtbTelefone.TabIndex = 84;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(65, 320);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(38, 13);
            this.label18.TabIndex = 83;
            this.label18.Text = "E-mail:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(265, 294);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(27, 13);
            this.label19.TabIndex = 82;
            this.label19.Text = "Fax:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(51, 294);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(52, 13);
            this.label20.TabIndex = 81;
            this.label20.Text = "Telefone:";
            // 
            // TxtComplemento
            // 
            this.TxtComplemento.Location = new System.Drawing.Point(109, 237);
            this.TxtComplemento.Name = "TxtComplemento";
            this.TxtComplemento.Size = new System.Drawing.Size(116, 20);
            this.TxtComplemento.TabIndex = 80;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(29, 238);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(74, 13);
            this.label17.TabIndex = 79;
            this.label17.Text = "Complemento:";
            // 
            // MtbCep
            // 
            this.MtbCep.Location = new System.Drawing.Point(355, 264);
            this.MtbCep.Mask = "0000-000";
            this.MtbCep.Name = "MtbCep";
            this.MtbCep.Size = new System.Drawing.Size(87, 20);
            this.MtbCep.TabIndex = 78;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(323, 266);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(26, 13);
            this.label16.TabIndex = 77;
            this.label16.Text = "Cep";
            // 
            // CmbCidade
            // 
            this.CmbCidade.FormattingEnabled = true;
            this.CmbCidade.Location = new System.Drawing.Point(277, 236);
            this.CmbCidade.Name = "CmbCidade";
            this.CmbCidade.Size = new System.Drawing.Size(165, 21);
            this.CmbCidade.TabIndex = 76;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(231, 238);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 75;
            this.label13.Text = "Cidade:";
            // 
            // CmbEstado
            // 
            this.CmbEstado.FormattingEnabled = true;
            this.CmbEstado.Location = new System.Drawing.Point(108, 263);
            this.CmbEstado.Name = "CmbEstado";
            this.CmbEstado.Size = new System.Drawing.Size(209, 21);
            this.CmbEstado.TabIndex = 74;
            this.CmbEstado.SelectedIndexChanged += new System.EventHandler(this.CmbEstado_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(60, 266);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 73;
            this.label14.Text = "Estado:";
            // 
            // TxtBairro
            // 
            this.TxtBairro.Location = new System.Drawing.Point(109, 211);
            this.TxtBairro.Name = "TxtBairro";
            this.TxtBairro.Size = new System.Drawing.Size(174, 20);
            this.TxtBairro.TabIndex = 72;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(66, 214);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 13);
            this.label15.TabIndex = 71;
            this.label15.Text = "Bairro:";
            // 
            // TxtNumero
            // 
            this.TxtNumero.Location = new System.Drawing.Point(345, 211);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(97, 20);
            this.TxtNumero.TabIndex = 70;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(289, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 69;
            this.label10.Text = "Número:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(47, 189);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 67;
            this.label11.Text = "Endereço:";
            // 
            // TxtEndereco
            // 
            this.TxtEndereco.Location = new System.Drawing.Point(109, 186);
            this.TxtEndereco.Name = "TxtEndereco";
            this.TxtEndereco.Size = new System.Drawing.Size(333, 20);
            this.TxtEndereco.TabIndex = 68;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 89;
            this.label7.Text = "Razão Social:";
            // 
            // TxtRazaoSocial
            // 
            this.TxtRazaoSocial.Location = new System.Drawing.Point(109, 134);
            this.TxtRazaoSocial.Name = "TxtRazaoSocial";
            this.TxtRazaoSocial.Size = new System.Drawing.Size(333, 20);
            this.TxtRazaoSocial.TabIndex = 90;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 91;
            this.label8.Text = "Nome Fantasia:";
            // 
            // TxtNomeFantasia
            // 
            this.TxtNomeFantasia.Location = new System.Drawing.Point(109, 160);
            this.TxtNomeFantasia.Name = "TxtNomeFantasia";
            this.TxtNomeFantasia.Size = new System.Drawing.Size(333, 20);
            this.TxtNomeFantasia.TabIndex = 92;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.BackColor = System.Drawing.SystemColors.Control;
            this.BtnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnExcluir.Location = new System.Drawing.Point(241, 398);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(98, 23);
            this.BtnExcluir.TabIndex = 93;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = false;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // FrmEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(481, 451);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.TxtNomeFantasia);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtRazaoSocial);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtObservacao);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.MtbFax);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.MtbTelefone);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.TxtComplemento);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.MtbCep);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.CmbCidade);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.CmbEstado);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.TxtBairro);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.TxtNumero);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TxtEndereco);
            this.Controls.Add(this.TxtIm);
            this.Controls.Add(this.TxtCnae);
            this.Controls.Add(this.MtbCnpj);
            this.Controls.Add(this.TxtIe);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
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
            this.Name = "FrmEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empresa";
            this.Load += new System.EventHandler(this.FrmEmpresa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.CheckBox CkbStatus;
        private System.Windows.Forms.DateTimePicker DtpDataCadastro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtIe;
        private System.Windows.Forms.MaskedTextBox MtbCnpj;
        private System.Windows.Forms.TextBox TxtCnae;
        private System.Windows.Forms.TextBox TxtIm;
        private System.Windows.Forms.TextBox TxtObservacao;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.MaskedTextBox MtbFax;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.MaskedTextBox MtbTelefone;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox TxtComplemento;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.MaskedTextBox MtbCep;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox CmbCidade;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox CmbEstado;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TxtBairro;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtEndereco;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtRazaoSocial;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtNomeFantasia;
        private System.Windows.Forms.Button BtnExcluir;
    }
}
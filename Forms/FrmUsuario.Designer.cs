namespace SysFood.Forms
{
    partial class FrmUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuario));
            this.TbUsuario = new System.Windows.Forms.TabControl();
            this.TpDadosLogin = new System.Windows.Forms.TabPage();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.TxtRepetirSenha = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.CmbTipoPerfil = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CkbStatus = new System.Windows.Forms.CheckBox();
            this.DtpDataCadastro = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TbDadosPessoais = new System.Windows.Forms.TabPage();
            this.TxtObservacao = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.MtbCelular = new System.Windows.Forms.MaskedTextBox();
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
            this.DtpDatanascimento = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtEndereco = new System.Windows.Forms.TextBox();
            this.CmbSexo = new System.Windows.Forms.ComboBox();
            this.TxtRg = new System.Windows.Forms.TextBox();
            this.MtbCpf = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TbUsuario.SuspendLayout();
            this.TpDadosLogin.SuspendLayout();
            this.TbDadosPessoais.SuspendLayout();
            this.SuspendLayout();
            // 
            // TbUsuario
            // 
            this.TbUsuario.Controls.Add(this.TpDadosLogin);
            this.TbUsuario.Controls.Add(this.TbDadosPessoais);
            this.TbUsuario.Location = new System.Drawing.Point(12, 12);
            this.TbUsuario.Name = "TbUsuario";
            this.TbUsuario.SelectedIndex = 0;
            this.TbUsuario.Size = new System.Drawing.Size(440, 318);
            this.TbUsuario.TabIndex = 0;
            // 
            // TpDadosLogin
            // 
            this.TpDadosLogin.Controls.Add(this.TxtRepetirSenha);
            this.TpDadosLogin.Controls.Add(this.label22);
            this.TpDadosLogin.Controls.Add(this.CmbTipoPerfil);
            this.TpDadosLogin.Controls.Add(this.label5);
            this.TpDadosLogin.Controls.Add(this.TxtSenha);
            this.TpDadosLogin.Controls.Add(this.label4);
            this.TpDadosLogin.Controls.Add(this.TxtLogin);
            this.TpDadosLogin.Controls.Add(this.label3);
            this.TpDadosLogin.Controls.Add(this.CkbStatus);
            this.TpDadosLogin.Controls.Add(this.DtpDataCadastro);
            this.TpDadosLogin.Controls.Add(this.label2);
            this.TpDadosLogin.Controls.Add(this.TxtCodigo);
            this.TpDadosLogin.Controls.Add(this.label1);
            this.TpDadosLogin.Location = new System.Drawing.Point(4, 22);
            this.TpDadosLogin.Name = "TpDadosLogin";
            this.TpDadosLogin.Padding = new System.Windows.Forms.Padding(3);
            this.TpDadosLogin.Size = new System.Drawing.Size(432, 292);
            this.TpDadosLogin.TabIndex = 0;
            this.TpDadosLogin.Text = "Dados de Login";
            this.TpDadosLogin.UseVisualStyleBackColor = true;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.BackColor = System.Drawing.SystemColors.Control;
            this.BtnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnExcluir.Location = new System.Drawing.Point(235, 345);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(98, 23);
            this.BtnExcluir.TabIndex = 17;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = false;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // TxtRepetirSenha
            // 
            this.TxtRepetirSenha.Location = new System.Drawing.Point(290, 121);
            this.TxtRepetirSenha.Name = "TxtRepetirSenha";
            this.TxtRepetirSenha.PasswordChar = '•';
            this.TxtRepetirSenha.Size = new System.Drawing.Size(112, 20);
            this.TxtRepetirSenha.TabIndex = 16;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(206, 124);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(78, 13);
            this.label22.TabIndex = 15;
            this.label22.Text = "Repetir Senha:";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCancelar.Location = new System.Drawing.Point(339, 345);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(98, 23);
            this.BtnCancelar.TabIndex = 14;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBuscar.Location = new System.Drawing.Point(131, 345);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(98, 23);
            this.BtnBuscar.TabIndex = 13;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.BackColor = System.Drawing.SystemColors.Control;
            this.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSalvar.Location = new System.Drawing.Point(27, 345);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(98, 23);
            this.BtnSalvar.TabIndex = 12;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = false;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // CmbTipoPerfil
            // 
            this.CmbTipoPerfil.FormattingEnabled = true;
            this.CmbTipoPerfil.Location = new System.Drawing.Point(93, 94);
            this.CmbTipoPerfil.Name = "CmbTipoPerfil";
            this.CmbTipoPerfil.Size = new System.Drawing.Size(168, 21);
            this.CmbTipoPerfil.TabIndex = 11;
            this.CmbTipoPerfil.SelectedIndexChanged += new System.EventHandler(this.CmbTipoPerfil_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tipo de Perfil:";
            // 
            // TxtSenha
            // 
            this.TxtSenha.Location = new System.Drawing.Point(93, 121);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.PasswordChar = '•';
            this.TxtSenha.Size = new System.Drawing.Size(112, 20);
            this.TxtSenha.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Senha:";
            // 
            // TxtLogin
            // 
            this.TxtLogin.Location = new System.Drawing.Point(93, 68);
            this.TxtLogin.Name = "TxtLogin";
            this.TxtLogin.Size = new System.Drawing.Size(309, 20);
            this.TxtLogin.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Login:";
            // 
            // CkbStatus
            // 
            this.CkbStatus.AutoSize = true;
            this.CkbStatus.Checked = true;
            this.CkbStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CkbStatus.Enabled = false;
            this.CkbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CkbStatus.Location = new System.Drawing.Point(354, 15);
            this.CkbStatus.Name = "CkbStatus";
            this.CkbStatus.Size = new System.Drawing.Size(48, 17);
            this.CkbStatus.TabIndex = 5;
            this.CkbStatus.Text = "Ativo";
            this.CkbStatus.UseVisualStyleBackColor = true;
            // 
            // DtpDataCadastro
            // 
            this.DtpDataCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDataCadastro.Location = new System.Drawing.Point(274, 42);
            this.DtpDataCadastro.Name = "DtpDataCadastro";
            this.DtpDataCadastro.Size = new System.Drawing.Size(128, 20);
            this.DtpDataCadastro.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data Cadastro:";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Enabled = false;
            this.TxtCodigo.Location = new System.Drawing.Point(93, 42);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(85, 20);
            this.TxtCodigo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // TbDadosPessoais
            // 
            this.TbDadosPessoais.Controls.Add(this.TxtObservacao);
            this.TbDadosPessoais.Controls.Add(this.label21);
            this.TbDadosPessoais.Controls.Add(this.MtbCelular);
            this.TbDadosPessoais.Controls.Add(this.TxtEmail);
            this.TbDadosPessoais.Controls.Add(this.MtbTelefone);
            this.TbDadosPessoais.Controls.Add(this.label18);
            this.TbDadosPessoais.Controls.Add(this.label19);
            this.TbDadosPessoais.Controls.Add(this.label20);
            this.TbDadosPessoais.Controls.Add(this.TxtComplemento);
            this.TbDadosPessoais.Controls.Add(this.label17);
            this.TbDadosPessoais.Controls.Add(this.MtbCep);
            this.TbDadosPessoais.Controls.Add(this.label16);
            this.TbDadosPessoais.Controls.Add(this.CmbCidade);
            this.TbDadosPessoais.Controls.Add(this.label13);
            this.TbDadosPessoais.Controls.Add(this.CmbEstado);
            this.TbDadosPessoais.Controls.Add(this.label14);
            this.TbDadosPessoais.Controls.Add(this.TxtBairro);
            this.TbDadosPessoais.Controls.Add(this.label15);
            this.TbDadosPessoais.Controls.Add(this.TxtNumero);
            this.TbDadosPessoais.Controls.Add(this.DtpDatanascimento);
            this.TbDadosPessoais.Controls.Add(this.label10);
            this.TbDadosPessoais.Controls.Add(this.label12);
            this.TbDadosPessoais.Controls.Add(this.label11);
            this.TbDadosPessoais.Controls.Add(this.TxtEndereco);
            this.TbDadosPessoais.Controls.Add(this.CmbSexo);
            this.TbDadosPessoais.Controls.Add(this.TxtRg);
            this.TbDadosPessoais.Controls.Add(this.MtbCpf);
            this.TbDadosPessoais.Controls.Add(this.label9);
            this.TbDadosPessoais.Controls.Add(this.label8);
            this.TbDadosPessoais.Controls.Add(this.label7);
            this.TbDadosPessoais.Controls.Add(this.TxtNome);
            this.TbDadosPessoais.Controls.Add(this.label6);
            this.TbDadosPessoais.Location = new System.Drawing.Point(4, 22);
            this.TbDadosPessoais.Name = "TbDadosPessoais";
            this.TbDadosPessoais.Padding = new System.Windows.Forms.Padding(3);
            this.TbDadosPessoais.Size = new System.Drawing.Size(432, 292);
            this.TbDadosPessoais.TabIndex = 1;
            this.TbDadosPessoais.Text = "Dados Pessoais";
            this.TbDadosPessoais.UseVisualStyleBackColor = true;
            // 
            // TxtObservacao
            // 
            this.TxtObservacao.Location = new System.Drawing.Point(86, 257);
            this.TxtObservacao.Name = "TxtObservacao";
            this.TxtObservacao.Size = new System.Drawing.Size(334, 20);
            this.TxtObservacao.TabIndex = 66;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(13, 260);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(68, 13);
            this.label21.TabIndex = 65;
            this.label21.Text = "Observação:";
            // 
            // MtbCelular
            // 
            this.MtbCelular.Location = new System.Drawing.Point(287, 205);
            this.MtbCelular.Mask = "(99) 0000-0000";
            this.MtbCelular.Name = "MtbCelular";
            this.MtbCelular.Size = new System.Drawing.Size(133, 20);
            this.MtbCelular.TabIndex = 64;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(86, 231);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(334, 20);
            this.TxtEmail.TabIndex = 63;
            // 
            // MtbTelefone
            // 
            this.MtbTelefone.Location = new System.Drawing.Point(87, 205);
            this.MtbTelefone.Mask = "(99) 0000-0000";
            this.MtbTelefone.Name = "MtbTelefone";
            this.MtbTelefone.Size = new System.Drawing.Size(133, 20);
            this.MtbTelefone.TabIndex = 61;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(43, 234);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(38, 13);
            this.label18.TabIndex = 60;
            this.label18.Text = "E-mail:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(243, 208);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(39, 13);
            this.label19.TabIndex = 59;
            this.label19.Text = "Celular";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(29, 208);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(52, 13);
            this.label20.TabIndex = 58;
            this.label20.Text = "Telefone:";
            // 
            // TxtComplemento
            // 
            this.TxtComplemento.Location = new System.Drawing.Point(87, 151);
            this.TxtComplemento.Name = "TxtComplemento";
            this.TxtComplemento.Size = new System.Drawing.Size(116, 20);
            this.TxtComplemento.TabIndex = 57;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 152);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(74, 13);
            this.label17.TabIndex = 56;
            this.label17.Text = "Complemento:";
            // 
            // MtbCep
            // 
            this.MtbCep.Location = new System.Drawing.Point(333, 178);
            this.MtbCep.Mask = "00000-000";
            this.MtbCep.Name = "MtbCep";
            this.MtbCep.Size = new System.Drawing.Size(87, 20);
            this.MtbCep.TabIndex = 55;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(301, 180);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(26, 13);
            this.label16.TabIndex = 54;
            this.label16.Text = "Cep";
            // 
            // CmbCidade
            // 
            this.CmbCidade.FormattingEnabled = true;
            this.CmbCidade.Location = new System.Drawing.Point(255, 150);
            this.CmbCidade.Name = "CmbCidade";
            this.CmbCidade.Size = new System.Drawing.Size(165, 21);
            this.CmbCidade.TabIndex = 53;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(209, 152);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 52;
            this.label13.Text = "Cidade";
            // 
            // CmbEstado
            // 
            this.CmbEstado.FormattingEnabled = true;
            this.CmbEstado.Location = new System.Drawing.Point(86, 177);
            this.CmbEstado.Name = "CmbEstado";
            this.CmbEstado.Size = new System.Drawing.Size(209, 21);
            this.CmbEstado.TabIndex = 51;
            this.CmbEstado.SelectedIndexChanged += new System.EventHandler(this.CmbEstado_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(38, 180);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 50;
            this.label14.Text = "Estado:";
            // 
            // TxtBairro
            // 
            this.TxtBairro.Location = new System.Drawing.Point(87, 125);
            this.TxtBairro.Name = "TxtBairro";
            this.TxtBairro.Size = new System.Drawing.Size(174, 20);
            this.TxtBairro.TabIndex = 49;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(44, 128);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 13);
            this.label15.TabIndex = 48;
            this.label15.Text = "Bairro:";
            // 
            // TxtNumero
            // 
            this.TxtNumero.Location = new System.Drawing.Point(323, 125);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(97, 20);
            this.TxtNumero.TabIndex = 43;
            // 
            // DtpDatanascimento
            // 
            this.DtpDatanascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDatanascimento.Location = new System.Drawing.Point(292, 74);
            this.DtpDatanascimento.Name = "DtpDatanascimento";
            this.DtpDatanascimento.Size = new System.Drawing.Size(128, 20);
            this.DtpDatanascimento.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(267, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 42;
            this.label10.Text = "Número:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(194, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Data Nascimento:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 40;
            this.label11.Text = "Endereço:";
            // 
            // TxtEndereco
            // 
            this.TxtEndereco.Location = new System.Drawing.Point(87, 100);
            this.TxtEndereco.Name = "TxtEndereco";
            this.TxtEndereco.Size = new System.Drawing.Size(333, 20);
            this.TxtEndereco.TabIndex = 41;
            // 
            // CmbSexo
            // 
            this.CmbSexo.FormattingEnabled = true;
            this.CmbSexo.Items.AddRange(new object[] {
            "Feminino",
            "Masculino"});
            this.CmbSexo.Location = new System.Drawing.Point(86, 73);
            this.CmbSexo.Name = "CmbSexo";
            this.CmbSexo.Size = new System.Drawing.Size(101, 21);
            this.CmbSexo.TabIndex = 9;
            // 
            // TxtRg
            // 
            this.TxtRg.Location = new System.Drawing.Point(320, 21);
            this.TxtRg.Name = "TxtRg";
            this.TxtRg.Size = new System.Drawing.Size(100, 20);
            this.TxtRg.TabIndex = 8;
            // 
            // MtbCpf
            // 
            this.MtbCpf.Location = new System.Drawing.Point(182, 21);
            this.MtbCpf.Mask = "000.000.000-00";
            this.MtbCpf.Name = "MtbCpf";
            this.MtbCpf.Size = new System.Drawing.Size(100, 20);
            this.MtbCpf.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(47, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Sexo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(288, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "RG:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(146, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "CPF:";
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(87, 47);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(333, 20);
            this.TxtNome.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nome:";
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(464, 380);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.TbUsuario);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.BtnBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuário";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            this.TbUsuario.ResumeLayout(false);
            this.TpDadosLogin.ResumeLayout(false);
            this.TpDadosLogin.PerformLayout();
            this.TbDadosPessoais.ResumeLayout(false);
            this.TbDadosPessoais.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TbUsuario;
        private System.Windows.Forms.TabPage TpDadosLogin;
        private System.Windows.Forms.TabPage TbDadosPessoais;
        private System.Windows.Forms.DateTimePicker DtpDataCadastro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CkbStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbTipoPerfil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtLogin;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.DateTimePicker DtpDatanascimento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox CmbSexo;
        private System.Windows.Forms.TextBox TxtRg;
        private System.Windows.Forms.MaskedTextBox MtbCpf;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label label6;
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
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.MaskedTextBox MtbTelefone;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox TxtObservacao;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.MaskedTextBox MtbCelular;
        private System.Windows.Forms.TextBox TxtRepetirSenha;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button BtnExcluir;
    }
}